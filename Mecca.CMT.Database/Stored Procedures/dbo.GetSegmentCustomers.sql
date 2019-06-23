SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
-- =============================================
-- Author:		Vu Cao
-- Create date: 05/07/2013
-- Description:	This procedure returns count of customer_sid's based on a given channel_id
-- =============================================
CREATE PROCEDURE [dbo].[GetSegmentCustomers] 
	-- Add the parameters for the stored procedure here
	@channelId int,
	@totalCustomers INT OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Statements for procedure here
	set @totalCustomers = (select count(*)
	from channel_customers
	where channel_id = @channelId)
END
GO
