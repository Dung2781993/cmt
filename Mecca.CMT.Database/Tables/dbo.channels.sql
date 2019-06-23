CREATE TABLE [dbo].[channels]
(
[channel_id] [int] NOT NULL IDENTITY(312, 1),
[campaign_id] [int] NOT NULL,
[channel_name] [nvarchar] (250) COLLATE Latin1_General_CI_AS NOT NULL,
[channel_type_id] [int] NOT NULL,
[description] [nvarchar] (250) COLLATE Latin1_General_CI_AS NULL CONSTRAINT [DF__channels__descri__25869641] DEFAULT (NULL),
[start_date] [date] NOT NULL,
[end_date] [date] NOT NULL,
[channel_code] [nvarchar] (10) COLLATE Latin1_General_CI_AS NULL,
[redemption_code_id] [int] NOT NULL,
[is_locked] [int] NOT NULL CONSTRAINT [DF__channels__is_loc__267ABA7A] DEFAULT ((0)),
[created_by] [nvarchar] (200) COLLATE Latin1_General_CI_AS NOT NULL,
[store_option_id] [int] NOT NULL CONSTRAINT [DF_channels_store_option_id] DEFAULT ((1))
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[channels] ADD CONSTRAINT [PK_channels_channel_id] PRIMARY KEY CLUSTERED  ([channel_id]) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [campaign_id] ON [dbo].[channels] ([campaign_id]) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [channel_type_id] ON [dbo].[channels] ([channel_type_id]) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [redemption_code_id] ON [dbo].[channels] ([redemption_code_id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[channels] ADD CONSTRAINT [FK_channels_campaigns] FOREIGN KEY ([campaign_id]) REFERENCES [dbo].[campaigns] ([campaign_id])
GO
ALTER TABLE [dbo].[channels] WITH NOCHECK ADD CONSTRAINT [FK_channels_channel_types] FOREIGN KEY ([channel_type_id]) REFERENCES [dbo].[channel_types] ([channel_type_id])
GO
ALTER TABLE [dbo].[channels] WITH NOCHECK ADD CONSTRAINT [FK_channels_redemption_codes] FOREIGN KEY ([redemption_code_id]) REFERENCES [dbo].[redemption_codes] ([redemption_code_id])
GO
EXEC sp_addextendedproperty N'MS_SSMA_SOURCE', N'dev_cmt.channels', 'SCHEMA', N'dbo', 'TABLE', N'channels', NULL, NULL
GO
