CREATE TABLE [dbo].[campaign_items]
(
[campaign_item_id] [int] NOT NULL IDENTITY(1391, 1),
[campaign_id] [int] NOT NULL,
[product_id] [int] NOT NULL,
[date_added] [date] NULL CONSTRAINT [DF__campaign___date___1B0907CE] DEFAULT (NULL),
[start_date] [date] NULL,
[end_date] [date] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[campaign_items] ADD CONSTRAINT [PK_campaign_items_campaign_item_id] PRIMARY KEY CLUSTERED  ([campaign_item_id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[campaign_items] ADD CONSTRAINT [campaign_items$UX_campaign_id_product_id] UNIQUE NONCLUSTERED  ([campaign_id], [product_id]) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [product_id] ON [dbo].[campaign_items] ([product_id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[campaign_items] ADD CONSTRAINT [FK_campaign_items_campaigns] FOREIGN KEY ([campaign_id]) REFERENCES [dbo].[campaigns] ([campaign_id])
GO
ALTER TABLE [dbo].[campaign_items] ADD CONSTRAINT [FK_campaign_items_products] FOREIGN KEY ([product_id]) REFERENCES [dbo].[products] ([product_id])
GO
EXEC sp_addextendedproperty N'MS_SSMA_SOURCE', N'dev_cmt.campaign_items', 'SCHEMA', N'dbo', 'TABLE', N'campaign_items', NULL, NULL
GO
