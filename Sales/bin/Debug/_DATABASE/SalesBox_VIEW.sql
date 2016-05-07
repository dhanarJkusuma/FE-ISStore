CREATE VIEW V_STOCK
AS 
SELECT 
	box_master_item.item_barcode as Barcode,
	box_master_item.item_name as Name,
	box_category.category_name as Category,
	box_master_stock.item_qty as Stock 
FROM box_master_item 
	INNER JOIN box_master_stock 
		ON box_master_item.item_barcode=box_master_stock.item_barcode 
	LEFT JOIN box_category 
		ON box_master_item.category_code=box_category.category_code
GO
		
CREATE VIEW V_PROFIT_TRX
AS		
SELECT trx_payment.trx_no, trx_payment.created_at, SUM(trx_profit.profit) AS profit FROM trx_payment 
INNER JOIN trx_profit 
	ON trx_payment.trx_no=trx_profit.trx_no
	GROUP BY trx_payment.trx_no,trx_payment.created_at
GO


CREATE VIEW V_PROFIT_MONTH
AS 
SELECT DATEPART(yyyy,created_at) AS profit_year, DATEPART(mm,created_at) as profit_month, 
	SUM(trx_profit.profit) AS profit  
FROM trx_profit 
GROUP BY DATEPART(yyyy,created_at), DATEPART(mm,created_at)

GO

CREATE VIEW V_TOP_10_ITEM
AS
SELECT TOP item_barcode, SUM(item_qty) AS qty FROM trx_payment_item  
	INNER JOIN trx_payment
	ON 
		trx_payment_item.trx_no=trx_payment.trx_no
	WHERE DATEPART(mm,trx_payment.created_at) = DATEPART(mm,GETDATE())
	GROUP BY item_barcode ORDER BY qty DESC
GO

CREATE VIEW V_DOWN_10_ITEM
AS
SELECT TOP item_barcode, SUM(item_qty) AS qty FROM trx_payment_item  
	INNER JOIN trx_payment
	ON 
		trx_payment_item.trx_no=trx_payment.trx_no
	WHERE DATEPART(mm,trx_payment.created_at) = DATEPART(mm,GETDATE())
	GROUP BY item_barcode ORDER BY qty ASC
GO

CREATE VIEW V_PAYMENT_ITEM
AS
SELECT 
	trx_payment_item.trx_no,
	trx_payment_item.item_barcode,
	box_master_item.item_name,
	trx_payment_item.item_qty,
	box_master_item.item_price,
	trx_payment_item.item_qty * box_master_item.item_price as sub_total
FROM
trx_payment_item
INNER JOIN box_master_item
ON
	box_master_item.item_barcode = trx_payment_item.item_barcode
GO