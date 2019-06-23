CREATE TABLE [dbo].[channel_types]
(
[channel_type_id] [int] NOT NULL IDENTITY(16, 1),
[channel_type_name] [nvarchar] (50) COLLATE Latin1_General_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[channel_types] ADD CONSTRAINT [PK_channel_types_channel_type_id] PRIMARY KEY CLUSTERED  ([channel_type_id]) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [channel_type] ON [dbo].[channel_types] ([channel_type_name]) ON [PRIMARY]
GO
EXEC sp_addextendedproperty N'MS_SSMA_SOURCE', N'dev_cmt.channel_types', 'SCHEMA', N'dbo', 'TABLE', N'channel_types', NULL, NULL
GO
