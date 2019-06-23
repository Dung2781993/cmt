CREATE TABLE [dbo].[products]
(
[product_id] [int] NOT NULL IDENTITY(10585, 1),
[item_code] [nvarchar] (20) COLLATE Latin1_General_CI_AS NOT NULL,
[description] [nvarchar] (30) COLLATE Latin1_General_CI_AS NOT NULL,
[vendor_code] [nvarchar] (20) COLLATE Latin1_General_CI_AS NOT NULL,
[department_name] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL,
[category_name] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL,
[lifestage] [nvarchar] (5) COLLATE Latin1_General_CI_AS NULL CONSTRAINT [DF__products__lifest__29572725] DEFAULT (NULL),
[limited_edition] [nvarchar] (3) COLLATE Latin1_General_CI_AS NULL CONSTRAINT [DF__products__limite__2A4B4B5E] DEFAULT (NULL),
[unit_price] [decimal] (12, 3) NULL CONSTRAINT [DF__products__unit_p__2B3F6F97] DEFAULT (NULL),
[nz_unit_price] [decimal] (12, 3) NULL CONSTRAINT [DF__products__nz_uni__2C3393D0] DEFAULT (NULL),
[launch_date] [date] NULL CONSTRAINT [DF__products__launch__2D27B809] DEFAULT (NULL),
[ranging_code_mecca] [nvarchar] (342) COLLATE Latin1_General_CI_AS NULL CONSTRAINT [DF__products__rangin__2E1BDC42] DEFAULT (NULL),
[ranging_code_kit] [nvarchar] (342) COLLATE Latin1_General_CI_AS NULL CONSTRAINT [DF__products__rangin__2F10007B] DEFAULT (NULL),
[ranging_code_imo] [nvarchar] (342) COLLATE Latin1_General_CI_AS NULL CONSTRAINT [DF__products__rangin__300424B4] DEFAULT (NULL),
[ranging_code_maxima] [nvarchar] (342) COLLATE Latin1_General_CI_AS NULL CONSTRAINT [DF__products__rangin__30F848ED] DEFAULT (NULL),
[company_soh] [int] NULL CONSTRAINT [DF__products__compan__31EC6D26] DEFAULT ((0)),
[transition_item_code] [varchar] (20) COLLATE Latin1_General_CI_AS NULL,
[no_tester] [varchar] (50) COLLATE Latin1_General_CI_AS NULL,
[stock_on_order] [int] NULL,
[expected_receipt_date] [datetime] NULL,
[travel_size] [varchar] (5) COLLATE Latin1_General_CI_AS NULL,
[termination_date] [varchar] (10) COLLATE Latin1_General_CI_AS NULL,
[item_sid] [decimal] (19, 0) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[products] ADD CONSTRAINT [PK_products_product_id] PRIMARY KEY CLUSTERED  ([product_id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[products] ADD CONSTRAINT [products$item_code] UNIQUE NONCLUSTERED  ([item_code]) ON [PRIMARY]
GO
EXEC sp_addextendedproperty N'MS_SSMA_SOURCE', N'dev_cmt.products', 'SCHEMA', N'dbo', 'TABLE', N'products', NULL, NULL
GO
