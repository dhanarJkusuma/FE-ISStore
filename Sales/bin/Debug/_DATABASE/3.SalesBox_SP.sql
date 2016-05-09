if exists (select * from sysobjects where id = object_id('dbo.SP_TRX_INV_INCOME_ITEM') and sysstat & 0xf = 4)
	drop procedure dbo.SP_TRX_INV_INCOME_ITEM
GO
CREATE PROCEDURE [dbo].[SP_TRX_INV_INCOME_ITEM] 
	@pStrTrxNo          	varchar(30)
	
AS
BEGIN
	DECLARE @status INT
	DECLARE @item_no BIGINT
	DECLARE @item_barcode VARCHAR(255)
	DECLARE @item_quantity INT
	DECLARE @item_quantity_old INT
	DECLARE @is_processed_item INT
	DECLARE @purchase NUMERIC(10,2)
	
	SET @status = (SELECT is_processed FROM trx_inv_income WHERE trx_no=@pStrTrxNo)
	IF @status = 0 
		BEGIN 
		DECLARE ItemCursor CURSOR FOR
		SELECT item_no,item_barcode,item_qty,item_purchase_price,is_processed 
				FROM trx_inv_income_item WHERE trx_no=@pStrTrxNo
			OPEN ItemCursor
				FETCH NEXT FROM ItemCursor INTO @item_no,@item_barcode,@item_quantity,@purchase,@is_processed_item
				WHILE(@@fetch_status=0)
					BEGIN
						IF @is_processed_item = 0
							BEGIN
								SET @item_quantity_old = (SELECT item_qty FROM box_master_stock WHERE item_barcode=@item_barcode)
								UPDATE box_master_stock SET item_qty=@item_quantity_old+@item_quantity WHERE item_barcode=@item_barcode
								INSERT INTO box_inv_stock_queue (item_barcode, item_purchase_price, item_qty) VALUES (@item_barcode,@purchase,@item_quantity)
								UPDATE trx_inv_income_item SET is_processed=1 WHERE item_no=@item_no
							END
						FETCH NEXT FROM ItemCursor INTO @item_no,@item_barcode,@item_quantity,@purchase,@is_processed_item
					END
					UPDATE trx_inv_income SET is_processed=1 WHERE trx_no=@pStrTrxNo
		CLOSE ItemCursor
		DEALLOCATE ItemCursor
		END
END
GO


if exists (select * from sysobjects where id = object_id('dbo.SP_TRX_PAYMENT') and sysstat & 0xf = 4)
	drop procedure dbo.SP_TRX_PAYMENT
GO
CREATE PROCEDURE [dbo].[SP_TRX_PAYMENT] 
	@pStrTrxNo          	varchar(30)
	
AS
BEGIN
	DECLARE @status INT
	DECLARE @item_no BIGINT
	DECLARE @item_barcode VARCHAR(255)
	DECLARE @item_quantity INT
	DECLARE @item_quantity_old INT
	DECLARE @is_processed_item INT
	DECLARE @qty_queue INT
	DECLARE @item_queue BIGINT
	DECLARE @qty_check INT
	DECLARE @qty_tmp INT
	DECLARE @purchase NUMERIC(10,2)
	DECLARE @sellprice NUMERIC(10,2)
	DECLARE @profit NUMERIC(10,2)
	
	SET @status = (SELECT is_processed FROM trx_payment WHERE trx_no=@pStrTrxNo)
	IF @status = 0 
		BEGIN 
		DECLARE ItemCursor CURSOR FOR
		SELECT item_no,item_barcode,item_qty,is_processed 
				FROM trx_payment_item WHERE trx_no=@pStrTrxNo
			OPEN ItemCursor
				FETCH NEXT FROM ItemCursor INTO @item_no,@item_barcode,@item_quantity,@is_processed_item
				WHILE(@@fetch_status=0)
					BEGIN
						IF @is_processed_item = 0
							BEGIN
								SET @item_quantity_old = (SELECT item_qty FROM box_master_stock WHERE item_barcode=@item_barcode)
								SET @sellprice = (SELECT item_price FROM box_master_item WHERE item_barcode=@item_barcode)
								DECLARE queueCursor CURSOR FOR 
									SELECT TOP 1 item_no,item_qty,item_purchase_price FROM box_inv_stock_queue WHERE item_barcode=@item_barcode AND item_qty<>0 ORDER BY created_at ASC
									OPEN queueCursor
										FETCH NEXT FROM queueCursor INTO @item_queue,@qty_queue,@purchase
										--SET @qty_queue = (SELECT TOP 1 item_qty FROM box_inv_stock_queue WHERE item_barcode=@item_barcode AND item_qty<>0 ORDER BY created_at ASC)
										--SET @item_queue = (SELECT TOP 1 item_no FROM box_inv_stock_queue WHERE item_barcode=@item_barcode AND item_qty<>0 ORDER BY created_at ASC)
											
										SET @qty_check = @qty_queue-@item_quantity
										SET @profit = @item_quantity * (@sellprice-@purchase)
									CLOSE queueCursor
									DEALLOCATE queueCursor
									WHILE @qty_check < 0 
										BEGIN
											SET @profit = @qty_queue * (@sellprice-@purchase)
											INSERT INTO trx_profit (trx_no,item_barcode,profit) VALUES (@pStrTrxNo,@item_barcode,@profit)
											SET @qty_tmp = @item_quantity - @qty_queue
											UPDATE box_inv_stock_queue SET item_qty=0, updated_at=GETDATE() WHERE item_no=@item_queue
											DECLARE queueCursor CURSOR FOR 
												SELECT TOP 1 item_no,item_qty,item_purchase_price FROM box_inv_stock_queue WHERE item_barcode=@item_barcode AND item_qty<>0 ORDER BY created_at ASC
												OPEN queueCursor
											
												FETCH NEXT FROM queueCursor INTO @item_queue,@qty_queue,@purchase
												--SET @qty_queue = (SELECT TOP 1 item_qty FROM box_inv_stock_queue WHERE item_barcode=@item_barcode AND item_qty<>0 ORDER BY created_at ASC)
												--SET @item_queue = (SELECT TOP 1 item_no FROM box_inv_stock_queue WHERE item_barcode=@item_barcode AND item_qty<>0 ORDER BY created_at ASC)
												
												SET @qty_check = @qty_queue - @qty_tmp
												SET @profit = @qty_tmp * (@sellprice-@purchase)
											CLOSE queueCursor
											DEALLOCATE queueCursor
										END
								INSERT INTO trx_profit (trx_no,item_barcode,profit) VALUES (@pStrTrxNo,@item_barcode,@profit)
								
								UPDATE box_inv_stock_queue SET item_qty=@qty_check, updated_at=GETDATE() WHERE item_no=@item_queue
							
								UPDATE box_master_stock SET item_qty=@item_quantity_old-@item_quantity WHERE item_barcode=@item_barcode
								
								UPDATE trx_payment_item SET is_processed=1 WHERE item_no=@item_no
							END
						FETCH NEXT FROM ItemCursor INTO @item_no,@item_barcode,@item_quantity,@is_processed_item
					END
					UPDATE trx_payment SET is_processed=1 WHERE trx_no=@pStrTrxNo
		CLOSE ItemCursor
		DEALLOCATE ItemCursor
		END
END
GO


if exists (select * from sysobjects where id = object_id('dbo.SP_NEW_ITEM') and sysstat & 0xf = 4)
	drop procedure dbo.SP_NEW_ITEM
GO
CREATE PROCEDURE [dbo].[SP_NEW_ITEM] 
	   @item_barcode		BIGINT,
	   @item_name			VARCHAR(255),
	   @category_code		VARCHAR(100),
	   @unit_code			VARCHAR(100),
	   @item_price			NUMERIC(10,2),
	   @item_stock_alert	INT
AS
BEGIN
	DECLARE @Now DATETIME
	DECLARE @item_qty INT
	DECLARE @selected_item INT
	SET @item_qty=0
	SET @Now=GETDATE()	
	SET @selected_item = (SELECT count(item_barcode) FROM box_master_item WHERE item_barcode=@item_barcode)
	IF @selected_item = 0
		BEGIN
			INSERT INTO box_master_item(item_barcode,item_name,category_code,unit_code,item_price,item_stock_alert,created_at,updated_at) VALUES (@item_barcode,@item_name,@category_code,@unit_code,@item_price,@item_stock_alert,@Now,@Now)
			SET @selected_item = (SELECT count(item_barcode) FROM box_master_stock WHERE item_barcode=@item_barcode)
			IF @selected_item = 0
				BEGIN
				INSERT INTO box_master_stock(item_barcode,item_qty,created_at,updated_at) VALUES (@item_barcode,@item_qty,@Now,@Now)
				END
		END
END 
GO

if exists (select * from sysobjects where id = object_id('dbo.SP_DELETE_ITEM') and sysstat & 0xf = 4)
	drop procedure dbo.SP_DELETE_ITEM
GO
CREATE PROCEDURE [dbo].[SP_DELETE_ITEM]
	@item_barcode		VARCHAR(255)
AS
BEGIN
	DECLARE @selected_item INT
	SET @selected_item = (SELECT COUNT(item_barcode) FROM box_master_item WHERE item_barcode=@item_barcode)
	IF @selected_item > 0
		BEGIN
			DELETE FROM box_master_item WHERE item_barcode=@item_barcode
			SET @selected_item = (SELECT item_barcode FROM box_master_stock WHERE item_barcode=@item_barcode)
			IF @selected_item > 0
				BEGIN
					DELETE FROM box_master_stock where item_barcode=@item_barcode
				END
		END
END
GO


if exists (select * from sysobjects where id = object_id('dbo.SP_NEW_GROUP') and sysstat & 0xf = 4)
	drop procedure dbo.SP_NEW_GROUP
GO
CREATE PROCEDURE [dbo].[SP_NEW_GROUP]
	@groupName VARCHAR(40)
AS
BEGIN
	DECLARE @menu_id VARCHAR(100)
	DECLARE @group_id INT
	INSERT INTO box_user_group (group_name,created_at) VALUES (@groupName,GETDATE())
	SET @group_id =  (SELECT SCOPE_IDENTITY())
	DECLARE menuCursor CURSOR FOR
		SELECT menu_id FROM box_menu
		OPEN menuCursor
				FETCH NEXT FROM menuCursor INTO @menu_id
				WHILE(@@fetch_status=0)
					BEGIN
						INSERT INTO box_role (group_id,menu_id) VALUES (@group_id,@menu_id)
					FETCH NEXT FROM menuCursor INTO @menu_id
					END
		CLOSE menuCursor
		DEALLOCATE menuCursor
END
GO

