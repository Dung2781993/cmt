SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
-- =============================================
-- Author:		Vu Cao
-- Create date: 05/07/2013
-- Description:	Deletes all customers based on a given channel_id
-- =============================================
CREATE PROCEDURE [dbo].[DeleteSegmentCustomers] 
	-- Add the parameters for the stored procedure here
	@channelId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete channel_customers
	where channel_id = @channelId
END
GO
