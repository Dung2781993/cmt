CREATE TABLE [dbo].[campaign_stores]
(
[campaign_store_id] [int] NOT NULL IDENTITY(1, 1),
[campaign_id] [int] NOT NULL,
[store_id] [int] NOT NULL,
[date_added] [date] NULL,
[is_selected] [int] NOT NULL CONSTRAINT [DF_campaign_stores_is_selected] DEFAULT ((0))
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[campaign_stores] ADD CONSTRAINT [PK_campaign_stores] PRIMARY KEY CLUSTERED  ([campaign_store_id]) ON [PRIMARY]
GO
