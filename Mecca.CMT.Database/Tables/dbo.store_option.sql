CREATE TABLE [dbo].[store_option]
(
[StoreOptionID] [int] NOT NULL,
[StoreOptionName] [varchar] (50) COLLATE Latin1_General_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[store_option] ADD CONSTRAINT [PK_store_option] PRIMARY KEY CLUSTERED  ([StoreOptionID]) ON [PRIMARY]
GO
