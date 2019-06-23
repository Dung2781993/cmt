CREATE TABLE [dbo].[campaign_owners]
(
[campaign_owner_id] [int] NOT NULL IDENTITY(60, 1),
[campaign_id] [int] NOT NULL,
[owner] [nvarchar] (200) COLLATE Latin1_General_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[campaign_owners] ADD CONSTRAINT [PK_campaign_owners_campaign_owner_id] PRIMARY KEY CLUSTERED  ([campaign_owner_id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[campaign_owners] ADD CONSTRAINT [campaign_owners$UX_campaign_id_owner] UNIQUE NONCLUSTERED  ([campaign_id], [owner]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[campaign_owners] WITH NOCHECK ADD CONSTRAINT [FK_campaign_owners_campaigns] FOREIGN KEY ([campaign_id]) REFERENCES [dbo].[campaigns] ([campaign_id])
GO
EXEC sp_addextendedproperty N'MS_SSMA_SOURCE', N'dev_cmt.campaign_owners', 'SCHEMA', N'dbo', 'TABLE', N'campaign_owners', NULL, NULL
GO
