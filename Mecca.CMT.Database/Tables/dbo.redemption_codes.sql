CREATE TABLE [dbo].[redemption_codes]
(
[redemption_code_id] [int] NOT NULL IDENTITY(224, 1),
[offer_code] [nvarchar] (20) COLLATE Latin1_General_CI_AS NOT NULL,
[description] [nvarchar] (50) COLLATE Latin1_General_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[redemption_codes] ADD CONSTRAINT [PK_redemption_codes_redemption_code_id] PRIMARY KEY CLUSTERED  ([redemption_code_id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[redemption_codes] ADD CONSTRAINT [redemption_codes$offer_code] UNIQUE NONCLUSTERED  ([offer_code]) ON [PRIMARY]
GO
EXEC sp_addextendedproperty N'MS_SSMA_SOURCE', N'dev_cmt.redemption_codes', 'SCHEMA', N'dbo', 'TABLE', N'redemption_codes', NULL, NULL
GO
