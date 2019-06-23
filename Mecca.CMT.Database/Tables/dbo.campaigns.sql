CREATE TABLE [dbo].[campaigns]
(
[campaign_id] [int] NOT NULL IDENTITY(60, 1),
[business_format] [nvarchar] (10) COLLATE Latin1_General_CI_AS NOT NULL,
[campaign_code] [nvarchar] (10) COLLATE Latin1_General_CI_AS NULL,
[campaign_name] [nvarchar] (100) COLLATE Latin1_General_CI_AS NOT NULL,
[campaign_type_id] [int] NOT NULL,
[description] [nvarchar] (250) COLLATE Latin1_General_CI_AS NULL CONSTRAINT [DF__campaigns__descr__1ED998B2] DEFAULT (NULL),
[start_date] [date] NOT NULL,
[end_date] [date] NOT NULL,
[redemption_code_id] [int] NOT NULL,
[is_locked] [int] NOT NULL CONSTRAINT [DF__campaigns__is_lo__1FCDBCEB] DEFAULT ((0)),
[created_by] [nvarchar] (200) COLLATE Latin1_General_CI_AS NOT NULL,
[store_option_id] [int] NOT NULL CONSTRAINT [DF_campaigns_store_option_id] DEFAULT ((1))
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[campaigns] ADD CONSTRAINT [PK_campaigns_campaign_id] PRIMARY KEY CLUSTERED  ([campaign_id]) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [campaign_type_id] ON [dbo].[campaigns] ([campaign_type_id]) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [redemption_code_id] ON [dbo].[campaigns] ([redemption_code_id]) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [store_option_id] ON [dbo].[campaigns] ([store_option_id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[campaigns] ADD CONSTRAINT [FK_campaigns_campaign_types] FOREIGN KEY ([campaign_type_id]) REFERENCES [dbo].[campaign_types] ([campaign_type_id])
GO
ALTER TABLE [dbo].[campaigns] ADD CONSTRAINT [FK_campaigns_redemption_codes] FOREIGN KEY ([redemption_code_id]) REFERENCES [dbo].[redemption_codes] ([redemption_code_id])
GO
ALTER TABLE [dbo].[campaigns] ADD CONSTRAINT [FK_campaigns_store_option] FOREIGN KEY ([campaign_id]) REFERENCES [dbo].[campaigns] ([campaign_id])
GO
EXEC sp_addextendedproperty N'MS_SSMA_SOURCE', N'dev_cmt.campaigns', 'SCHEMA', N'dbo', 'TABLE', N'campaigns', NULL, NULL
GO
