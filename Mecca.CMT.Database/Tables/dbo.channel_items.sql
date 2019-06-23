CREATE TABLE [dbo].[channel_items]
(
[channel_item_id] [int] NOT NULL IDENTITY(1, 1),
[channel_id] [int] NOT NULL,
[product_id] [int] NOT NULL,
[tester_merch_qty] [int] NULL,
[live_merch_qty] [int] NULL,
[num_stores] [int] NULL,
[comments] [varchar] (500) COLLATE Latin1_General_CI_AS NULL,
[sample_qty] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[channel_items] ADD CONSTRAINT [PK_channel_items_channel_item_id] PRIMARY KEY CLUSTERED  ([channel_item_id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[channel_items] ADD CONSTRAINT [channel_items$UX_channel_id_product_id] UNIQUE NONCLUSTERED  ([channel_id], [product_id]) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [product_id] ON [dbo].[channel_items] ([product_id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[channel_items] WITH NOCHECK ADD CONSTRAINT [FK_channel_items_channels] FOREIGN KEY ([channel_id]) REFERENCES [dbo].[channels] ([channel_id])
GO
ALTER TABLE [dbo].[channel_items] WITH NOCHECK ADD CONSTRAINT [FK_channel_items_products] FOREIGN KEY ([product_id]) REFERENCES [dbo].[products] ([product_id])
GO
EXEC sp_addextendedproperty N'MS_SSMA_SOURCE', N'dev_cmt.channel_items', 'SCHEMA', N'dbo', 'TABLE', N'channel_items', NULL, NULL
GO
