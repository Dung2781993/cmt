CREATE TABLE [dbo].[store]
(
[store_id] [int] NOT NULL IDENTITY(1, 1),
[store_code] [nvarchar] (20) COLLATE Latin1_General_CI_AS NOT NULL,
[store_name] [nvarchar] (50) COLLATE Latin1_General_CI_AS NOT NULL,
[business_name] [nvarchar] (50) COLLATE Latin1_General_CI_AS NOT NULL,
[open_date] [datetime] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[store] ADD CONSTRAINT [PK_store] PRIMARY KEY CLUSTERED  ([store_id]) ON [PRIMARY]
GO
