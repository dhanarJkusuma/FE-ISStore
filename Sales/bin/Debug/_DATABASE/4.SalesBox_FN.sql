if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FN_GET_PROFIT_REPORT]') and xtype in (N'FN', N'IF', N'TF'))
	drop function [dbo].[FN_GET_PROFIT_REPORT]
GO

CREATE FUNCTION FN_GET_PROFIT_REPORT (@firstDate VARCHAR(10), @secondDate VARCHAR(10))
RETURNS TABLE
AS
RETURN
   SELECT * FROM V_PROFIT_TRX WHERE DATEADD(day, DATEDIFF(Day, 0, created_at), 0) 
	BETWEEN DATEADD(day, DATEDIFF(Day, 0, @firstDate), 0) AND DATEADD(day, DATEDIFF(Day, 0, @secondDate), 0)
GO



if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FN_GET_PROFIT_MONTH_REPORT]') and xtype in (N'FN', N'IF', N'TF'))
	drop function [dbo].[FN_GET_PROFIT_MONTH_REPORT]
GO

CREATE FUNCTION FN_GET_PROFIT_MONTH_REPORT (@firstMonth INT, @secondMonth INT, @firstYear INT, @secondYear INT)
RETURNS TABLE
AS
RETURN
  SELECT * FROM V_PROFIT_MONTH WHERE profit_month BETWEEN  @firstMonth AND @secondMonth AND profit_year BETWEEN @firstYear and @secondYear
GO