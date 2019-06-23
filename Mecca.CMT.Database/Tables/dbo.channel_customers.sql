CREATE TABLE [dbo].[channel_customers]
(
[channel_customer_id] [int] NOT NULL IDENTITY(1, 1),
[channel_id] [int] NOT NULL,
[customer_sid] [bigint] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[channel_customers] ADD CONSTRAINT [PK_channel_customers_channel_customer_id] PRIMARY KEY CLUSTERED  ([channel_customer_id]) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_channel_id] ON [dbo].[channel_customers] ([channel_id]) ON [PRIMARY]
GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_channel_id_customer_sid] ON [dbo].[channel_customers] ([channel_id], [customer_sid]) WITH (IGNORE_DUP_KEY=ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[channel_customers] WITH NOCHECK ADD CONSTRAINT [FK_channel_customers_channels] FOREIGN KEY ([channel_id]) REFERENCES [dbo].[channels] ([channel_id])
GO
EXEC sp_addextendedproperty N'MS_SSMA_SOURCE', N'dev_cmt.channel_customers', 'SCHEMA', N'dbo', 'TABLE', N'channel_customers', NULL, NULL
GO
