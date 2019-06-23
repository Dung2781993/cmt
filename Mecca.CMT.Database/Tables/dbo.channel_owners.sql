CREATE TABLE [dbo].[channel_owners]
(
[channel_owner_id] [int] NOT NULL IDENTITY(1, 1),
[campaign_id] [int] NOT NULL,
[channel_id] [int] NOT NULL,
[owner] [nvarchar] (200) COLLATE Latin1_General_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[channel_owners] ADD CONSTRAINT [PK_channel_owners_channel_owner_id] PRIMARY KEY CLUSTERED  ([channel_owner_id]) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [campaign_id] ON [dbo].[channel_owners] ([campaign_id]) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [channel_id] ON [dbo].[channel_owners] ([channel_id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[channel_owners] WITH NOCHECK ADD CONSTRAINT [FK_channel_owners_campaigns] FOREIGN KEY ([campaign_id]) REFERENCES [dbo].[campaigns] ([campaign_id])
GO
ALTER TABLE [dbo].[channel_owners] WITH NOCHECK ADD CONSTRAINT [FK_channel_owners_channels] FOREIGN KEY ([channel_id]) REFERENCES [dbo].[channels] ([channel_id])
GO
EXEC sp_addextendedproperty N'MS_SSMA_SOURCE', N'dev_cmt.channel_owners', 'SCHEMA', N'dbo', 'TABLE', N'channel_owners', NULL, NULL
GO
