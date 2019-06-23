CREATE TABLE [dbo].[channel_stores]
(
[channel_store_id] [int] NOT NULL IDENTITY(1, 1),
[channel_id] [int] NOT NULL,
[campaign_id] [int] NOT NULL,
[store_id] [int] NOT NULL,
[date_added] [date] NULL,
[is_selected] [int] NOT NULL CONSTRAINT [DF_channel_stores_is_selected] DEFAULT ((0))
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[channel_stores] ADD CONSTRAINT [PK_channel_stores] PRIMARY KEY CLUSTERED  ([channel_store_id]) ON [PRIMARY]
GO
