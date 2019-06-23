CREATE TABLE [dbo].[campaign_types]
(
[campaign_type_id] [int] NOT NULL IDENTITY(6, 1),
[campaign_type_name] [nvarchar] (50) COLLATE Latin1_General_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[campaign_types] ADD CONSTRAINT [PK_campaign_types_campaign_type_id] PRIMARY KEY CLUSTERED  ([campaign_type_id]) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [campaign_type_name] ON [dbo].[campaign_types] ([campaign_type_name]) ON [PRIMARY]
GO
EXEC sp_addextendedproperty N'MS_SSMA_SOURCE', N'dev_cmt.campaign_types', 'SCHEMA', N'dbo', 'TABLE', N'campaign_types', NULL, NULL
GO
