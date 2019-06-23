///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Data;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Mecca.CMT.DAL.HelperClasses
{
	/// <summary>Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the PersistenceInfoProviderBase class is threadsafe.</remarks>
	internal static class PersistenceInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			this.InitClass();
			InitCampaignEntityMappings();
			InitCampaignItemEntityMappings();
			InitCampaignOwnerEntityMappings();
			InitCampaignStoreEntityMappings();
			InitCampaignTypeEntityMappings();
			InitChannelEntityMappings();
			InitChannelCustomerEntityMappings();
			InitChannelItemEntityMappings();
			InitChannelOwnerEntityMappings();
			InitChannelStoreEntityMappings();
			InitChannelTypeEntityMappings();
			InitProductEntityMappings();
			InitRedemptionCodeEntityMappings();
			InitStoreEntityMappings();
			InitStoreOptionEntityMappings();
			InitCampaign1TypedViewMappings();
			InitCampaignOwner1TypedViewMappings();
			InitCampaignType1TypedViewMappings();
			InitChannel1TypedViewMappings();
			InitChannelCustomer1TypedViewMappings();
			InitChannelItem1TypedViewMappings();
			InitChannelOwner1TypedViewMappings();
			InitChannelType1TypedViewMappings();
			InitRedemptionCode1TypedViewMappings();
		}

		/// <summary>Inits CampaignEntity's mappings</summary>
		private void InitCampaignEntityMappings()
		{
			this.AddElementMapping("CampaignEntity", @"mecca_cmt", @"dbo", "campaigns", 12, 0);
			this.AddElementFieldMapping("CampaignEntity", "BusinessFormat", "business_format", false, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("CampaignEntity", "CampaignCode", "campaign_code", true, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("CampaignEntity", "CampaignId", "campaign_id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("CampaignEntity", "CampaignName", "campaign_name", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("CampaignEntity", "CampaignTypeId", "campaign_type_id", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("CampaignEntity", "CreatedBy", "created_by", false, "NVarChar", 200, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("CampaignEntity", "Description", "description", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 6);
			this.AddElementFieldMapping("CampaignEntity", "EndDate", "end_date", false, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 7);
			this.AddElementFieldMapping("CampaignEntity", "IsLocked", "is_locked", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 8);
			this.AddElementFieldMapping("CampaignEntity", "RedemptionCodeId", "redemption_code_id", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 9);
			this.AddElementFieldMapping("CampaignEntity", "StartDate", "start_date", false, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 10);
			this.AddElementFieldMapping("CampaignEntity", "StoreOptionId", "store_option_id", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 11);
		}

		/// <summary>Inits CampaignItemEntity's mappings</summary>
		private void InitCampaignItemEntityMappings()
		{
			this.AddElementMapping("CampaignItemEntity", @"mecca_cmt", @"dbo", "campaign_items", 6, 0);
			this.AddElementFieldMapping("CampaignItemEntity", "CampaignId", "campaign_id", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("CampaignItemEntity", "CampaignItemId", "campaign_item_id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("CampaignItemEntity", "DateAdded", "date_added", true, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("CampaignItemEntity", "EndDate", "end_date", true, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("CampaignItemEntity", "ProductId", "product_id", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("CampaignItemEntity", "StartDate", "start_date", true, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 5);
		}

		/// <summary>Inits CampaignOwnerEntity's mappings</summary>
		private void InitCampaignOwnerEntityMappings()
		{
			this.AddElementMapping("CampaignOwnerEntity", @"mecca_cmt", @"dbo", "campaign_owners", 3, 0);
			this.AddElementFieldMapping("CampaignOwnerEntity", "CampaignId", "campaign_id", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("CampaignOwnerEntity", "CampaignOwnerId", "campaign_owner_id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("CampaignOwnerEntity", "Owner", "owner", false, "NVarChar", 200, 0, 0, false, "", null, typeof(System.String), 2);
		}

		/// <summary>Inits CampaignStoreEntity's mappings</summary>
		private void InitCampaignStoreEntityMappings()
		{
			this.AddElementMapping("CampaignStoreEntity", @"mecca_cmt", @"dbo", "campaign_stores", 5, 0);
			this.AddElementFieldMapping("CampaignStoreEntity", "CampaignId", "campaign_id", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("CampaignStoreEntity", "CampaignStoreId", "campaign_store_id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("CampaignStoreEntity", "DateAdded", "date_added", true, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("CampaignStoreEntity", "IsSelected", "is_selected", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("CampaignStoreEntity", "StoreId", "store_id", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
		}

		/// <summary>Inits CampaignTypeEntity's mappings</summary>
		private void InitCampaignTypeEntityMappings()
		{
			this.AddElementMapping("CampaignTypeEntity", @"mecca_cmt", @"dbo", "campaign_types", 2, 0);
			this.AddElementFieldMapping("CampaignTypeEntity", "CampaignTypeId", "campaign_type_id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("CampaignTypeEntity", "CampaignTypeName", "campaign_type_name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
		}

		/// <summary>Inits ChannelEntity's mappings</summary>
		private void InitChannelEntityMappings()
		{
			this.AddElementMapping("ChannelEntity", @"mecca_cmt", @"dbo", "channels", 12, 0);
			this.AddElementFieldMapping("ChannelEntity", "CampaignId", "campaign_id", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("ChannelEntity", "ChannelCode", "channel_code", true, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("ChannelEntity", "ChannelId", "channel_id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("ChannelEntity", "ChannelName", "channel_name", false, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("ChannelEntity", "ChannelTypeId", "channel_type_id", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("ChannelEntity", "CreatedBy", "created_by", false, "NVarChar", 200, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("ChannelEntity", "Description", "description", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 6);
			this.AddElementFieldMapping("ChannelEntity", "EndDate", "end_date", false, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 7);
			this.AddElementFieldMapping("ChannelEntity", "IsLocked", "is_locked", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 8);
			this.AddElementFieldMapping("ChannelEntity", "RedemptionCodeId", "redemption_code_id", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 9);
			this.AddElementFieldMapping("ChannelEntity", "StartDate", "start_date", false, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 10);
			this.AddElementFieldMapping("ChannelEntity", "StoreOptionId", "store_option_id", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 11);
		}

		/// <summary>Inits ChannelCustomerEntity's mappings</summary>
		private void InitChannelCustomerEntityMappings()
		{
			this.AddElementMapping("ChannelCustomerEntity", @"mecca_cmt", @"dbo", "channel_customers", 3, 0);
			this.AddElementFieldMapping("ChannelCustomerEntity", "ChannelCustomerId", "channel_customer_id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("ChannelCustomerEntity", "ChannelId", "channel_id", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("ChannelCustomerEntity", "CustomerSid", "customer_sid", false, "BigInt", 0, 19, 0, false, "", null, typeof(System.Int64), 2);
		}

		/// <summary>Inits ChannelItemEntity's mappings</summary>
		private void InitChannelItemEntityMappings()
		{
			this.AddElementMapping("ChannelItemEntity", @"mecca_cmt", @"dbo", "channel_items", 8, 0);
			this.AddElementFieldMapping("ChannelItemEntity", "ChannelId", "channel_id", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("ChannelItemEntity", "ChannelItemId", "channel_item_id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("ChannelItemEntity", "Comments", "comments", true, "VarChar", 500, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("ChannelItemEntity", "LiveMerchQty", "live_merch_qty", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("ChannelItemEntity", "NumStores", "num_stores", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("ChannelItemEntity", "ProductId", "product_id", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("ChannelItemEntity", "SampleQty", "sample_qty", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 6);
			this.AddElementFieldMapping("ChannelItemEntity", "TesterMerchQty", "tester_merch_qty", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 7);
		}

		/// <summary>Inits ChannelOwnerEntity's mappings</summary>
		private void InitChannelOwnerEntityMappings()
		{
			this.AddElementMapping("ChannelOwnerEntity", @"mecca_cmt", @"dbo", "channel_owners", 4, 0);
			this.AddElementFieldMapping("ChannelOwnerEntity", "CampaignId", "campaign_id", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("ChannelOwnerEntity", "ChannelId", "channel_id", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("ChannelOwnerEntity", "ChannelOwnerId", "channel_owner_id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("ChannelOwnerEntity", "Owner", "owner", false, "NVarChar", 200, 0, 0, false, "", null, typeof(System.String), 3);
		}

		/// <summary>Inits ChannelStoreEntity's mappings</summary>
		private void InitChannelStoreEntityMappings()
		{
			this.AddElementMapping("ChannelStoreEntity", @"mecca_cmt", @"dbo", "channel_stores", 6, 0);
			this.AddElementFieldMapping("ChannelStoreEntity", "CampaignId", "campaign_id", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("ChannelStoreEntity", "ChannelId", "channel_id", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("ChannelStoreEntity", "ChannelStoreId", "channel_store_id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("ChannelStoreEntity", "DateAdded", "date_added", true, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 3);
			this.AddElementFieldMapping("ChannelStoreEntity", "IsSelected", "is_selected", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("ChannelStoreEntity", "StoreId", "store_id", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
		}

		/// <summary>Inits ChannelTypeEntity's mappings</summary>
		private void InitChannelTypeEntityMappings()
		{
			this.AddElementMapping("ChannelTypeEntity", @"mecca_cmt", @"dbo", "channel_types", 2, 0);
			this.AddElementFieldMapping("ChannelTypeEntity", "ChannelTypeId", "channel_type_id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("ChannelTypeEntity", "ChannelTypeName", "channel_type_name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
		}

		/// <summary>Inits ProductEntity's mappings</summary>
		private void InitProductEntityMappings()
		{
			this.AddElementMapping("ProductEntity", @"mecca_cmt", @"dbo", "products", 23, 0);
			this.AddElementFieldMapping("ProductEntity", "CategoryName", "category_name", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("ProductEntity", "CompanySoh", "company_soh", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("ProductEntity", "DepartmentName", "department_name", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("ProductEntity", "Description", "description", false, "NVarChar", 30, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("ProductEntity", "ExpectedReceiptDate", "expected_receipt_date", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4);
			this.AddElementFieldMapping("ProductEntity", "ItemCode", "item_code", false, "NVarChar", 20, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("ProductEntity", "ItemSid", "item_sid", true, "Decimal", 0, 19, 0, false, "", null, typeof(System.Decimal), 6);
			this.AddElementFieldMapping("ProductEntity", "LaunchDate", "launch_date", true, "Date", 0, 0, 0, false, "", null, typeof(System.DateTime), 7);
			this.AddElementFieldMapping("ProductEntity", "Lifestage", "lifestage", true, "NVarChar", 5, 0, 0, false, "", null, typeof(System.String), 8);
			this.AddElementFieldMapping("ProductEntity", "LimitedEdition", "limited_edition", true, "NVarChar", 3, 0, 0, false, "", null, typeof(System.String), 9);
			this.AddElementFieldMapping("ProductEntity", "NoTester", "no_tester", true, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 10);
			this.AddElementFieldMapping("ProductEntity", "NzUnitPrice", "nz_unit_price", true, "Decimal", 0, 12, 3, false, "", null, typeof(System.Decimal), 11);
			this.AddElementFieldMapping("ProductEntity", "ProductId", "product_id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 12);
			this.AddElementFieldMapping("ProductEntity", "RangingCodeImo", "ranging_code_imo", true, "NVarChar", 342, 0, 0, false, "", null, typeof(System.String), 13);
			this.AddElementFieldMapping("ProductEntity", "RangingCodeKit", "ranging_code_kit", true, "NVarChar", 342, 0, 0, false, "", null, typeof(System.String), 14);
			this.AddElementFieldMapping("ProductEntity", "RangingCodeMaxima", "ranging_code_maxima", true, "NVarChar", 342, 0, 0, false, "", null, typeof(System.String), 15);
			this.AddElementFieldMapping("ProductEntity", "RangingCodeMecca", "ranging_code_mecca", true, "NVarChar", 342, 0, 0, false, "", null, typeof(System.String), 16);
			this.AddElementFieldMapping("ProductEntity", "StockOnOrder", "stock_on_order", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 17);
			this.AddElementFieldMapping("ProductEntity", "TerminationDate", "termination_date", true, "VarChar", 10, 0, 0, false, "", null, typeof(System.String), 18);
			this.AddElementFieldMapping("ProductEntity", "TransitionItemCode", "transition_item_code", true, "VarChar", 20, 0, 0, false, "", null, typeof(System.String), 19);
			this.AddElementFieldMapping("ProductEntity", "TravelSize", "travel_size", true, "VarChar", 5, 0, 0, false, "", null, typeof(System.String), 20);
			this.AddElementFieldMapping("ProductEntity", "UnitPrice", "unit_price", true, "Decimal", 0, 12, 3, false, "", null, typeof(System.Decimal), 21);
			this.AddElementFieldMapping("ProductEntity", "VendorCode", "vendor_code", false, "NVarChar", 20, 0, 0, false, "", null, typeof(System.String), 22);
		}

		/// <summary>Inits RedemptionCodeEntity's mappings</summary>
		private void InitRedemptionCodeEntityMappings()
		{
			this.AddElementMapping("RedemptionCodeEntity", @"mecca_cmt", @"dbo", "redemption_codes", 3, 0);
			this.AddElementFieldMapping("RedemptionCodeEntity", "Description", "description", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("RedemptionCodeEntity", "OfferCode", "offer_code", false, "NVarChar", 20, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("RedemptionCodeEntity", "RedemptionCodeId", "redemption_code_id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 2);
		}

		/// <summary>Inits StoreEntity's mappings</summary>
		private void InitStoreEntityMappings()
		{
			this.AddElementMapping("StoreEntity", @"mecca_cmt", @"dbo", "store", 5, 0);
			this.AddElementFieldMapping("StoreEntity", "BusinessName", "business_name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("StoreEntity", "OpenDate", "open_date", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("StoreEntity", "StoreCode", "store_code", false, "NVarChar", 20, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("StoreEntity", "StoreId", "store_id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("StoreEntity", "StoreName", "store_name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 4);
		}

		/// <summary>Inits StoreOptionEntity's mappings</summary>
		private void InitStoreOptionEntityMappings()
		{
			this.AddElementMapping("StoreOptionEntity", @"mecca_cmt", @"dbo", "store_option", 2, 0);
			this.AddElementFieldMapping("StoreOptionEntity", "StoreOptionId", "StoreOptionID", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("StoreOptionEntity", "StoreOptionName", "StoreOptionName", false, "VarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
		}


		/// <summary>Inits Campaign1View's mappings</summary>
		private void InitCampaign1TypedViewMappings()
		{
			this.AddElementMapping("Campaign1TypedView", @"mecca_cmt", @"dbo", "campaigns", 12);
			this.AddElementFieldMapping("Campaign1TypedView", "CampaignId", "campaign_id", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("Campaign1TypedView", "BusinessFormat", "business_format", false, "NVarChar", 10, 0, 0, false, string.Empty, null, typeof(System.String), 1);
			this.AddElementFieldMapping("Campaign1TypedView", "CampaignCode", "campaign_code", false, "NVarChar", 10, 0, 0, false, string.Empty, null, typeof(System.String), 2);
			this.AddElementFieldMapping("Campaign1TypedView", "CampaignName", "campaign_name", false, "NVarChar", 100, 0, 0, false, string.Empty, null, typeof(System.String), 3);
			this.AddElementFieldMapping("Campaign1TypedView", "CampaignTypeId", "campaign_type_id", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("Campaign1TypedView", "Description", "description", false, "NVarChar", 250, 0, 0, false, string.Empty, null, typeof(System.String), 5);
			this.AddElementFieldMapping("Campaign1TypedView", "StartDate", "start_date", false, "Date", 0, 0, 0, false, string.Empty, null, typeof(System.DateTime), 6);
			this.AddElementFieldMapping("Campaign1TypedView", "EndDate", "end_date", false, "Date", 0, 0, 0, false, string.Empty, null, typeof(System.DateTime), 7);
			this.AddElementFieldMapping("Campaign1TypedView", "RedemptionCodeId", "redemption_code_id", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 8);
			this.AddElementFieldMapping("Campaign1TypedView", "IsLocked", "is_locked", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 9);
			this.AddElementFieldMapping("Campaign1TypedView", "CreatedBy", "created_by", false, "NVarChar", 200, 0, 0, false, string.Empty, null, typeof(System.String), 10);
			this.AddElementFieldMapping("Campaign1TypedView", "StoreOptionId", "store_option_id", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 11);
		}


		/// <summary>Inits CampaignOwner1View's mappings</summary>
		private void InitCampaignOwner1TypedViewMappings()
		{
			this.AddElementMapping("CampaignOwner1TypedView", @"mecca_cmt", @"dbo", "campaign_owners", 3);
			this.AddElementFieldMapping("CampaignOwner1TypedView", "CampaignOwnerId", "campaign_owner_id", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("CampaignOwner1TypedView", "CampaignId", "campaign_id", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("CampaignOwner1TypedView", "Owner", "owner", false, "NVarChar", 200, 0, 0, false, string.Empty, null, typeof(System.String), 2);
		}


		/// <summary>Inits CampaignType1View's mappings</summary>
		private void InitCampaignType1TypedViewMappings()
		{
			this.AddElementMapping("CampaignType1TypedView", @"mecca_cmt", @"dbo", "campaign_types", 2);
			this.AddElementFieldMapping("CampaignType1TypedView", "CampaignTypeId", "campaign_type_id", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("CampaignType1TypedView", "CampaignTypeName", "campaign_type_name", false, "NVarChar", 50, 0, 0, false, string.Empty, null, typeof(System.String), 1);
		}


		/// <summary>Inits Channel1View's mappings</summary>
		private void InitChannel1TypedViewMappings()
		{
			this.AddElementMapping("Channel1TypedView", @"mecca_cmt", @"dbo", "channels", 12);
			this.AddElementFieldMapping("Channel1TypedView", "ChannelId", "channel_id", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("Channel1TypedView", "CampaignId", "campaign_id", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("Channel1TypedView", "ChannelName", "channel_name", false, "NVarChar", 250, 0, 0, false, string.Empty, null, typeof(System.String), 2);
			this.AddElementFieldMapping("Channel1TypedView", "ChannelTypeId", "channel_type_id", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("Channel1TypedView", "Description", "description", false, "NVarChar", 250, 0, 0, false, string.Empty, null, typeof(System.String), 4);
			this.AddElementFieldMapping("Channel1TypedView", "StartDate", "start_date", false, "Date", 0, 0, 0, false, string.Empty, null, typeof(System.DateTime), 5);
			this.AddElementFieldMapping("Channel1TypedView", "EndDate", "end_date", false, "Date", 0, 0, 0, false, string.Empty, null, typeof(System.DateTime), 6);
			this.AddElementFieldMapping("Channel1TypedView", "ChannelCode", "channel_code", false, "NVarChar", 10, 0, 0, false, string.Empty, null, typeof(System.String), 7);
			this.AddElementFieldMapping("Channel1TypedView", "RedemptionCodeId", "redemption_code_id", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 8);
			this.AddElementFieldMapping("Channel1TypedView", "IsLocked", "is_locked", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 9);
			this.AddElementFieldMapping("Channel1TypedView", "CreatedBy", "created_by", false, "NVarChar", 200, 0, 0, false, string.Empty, null, typeof(System.String), 10);
			this.AddElementFieldMapping("Channel1TypedView", "StoreOptionId", "store_option_id", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 11);
		}


		/// <summary>Inits ChannelCustomer1View's mappings</summary>
		private void InitChannelCustomer1TypedViewMappings()
		{
			this.AddElementMapping("ChannelCustomer1TypedView", @"mecca_cmt", @"dbo", "channel_customers", 3);
			this.AddElementFieldMapping("ChannelCustomer1TypedView", "ChannelCustomerId", "channel_customer_id", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("ChannelCustomer1TypedView", "ChannelId", "channel_id", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("ChannelCustomer1TypedView", "CustomerSid", "customer_sid", false, "BigInt", 0, 19, 0, false, string.Empty, null, typeof(System.Int64), 2);
		}


		/// <summary>Inits ChannelItem1View's mappings</summary>
		private void InitChannelItem1TypedViewMappings()
		{
			this.AddElementMapping("ChannelItem1TypedView", @"mecca_cmt", @"dbo", "channel_items", 8);
			this.AddElementFieldMapping("ChannelItem1TypedView", "ChannelItemId", "channel_item_id", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("ChannelItem1TypedView", "ChannelId", "channel_id", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("ChannelItem1TypedView", "ProductId", "product_id", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("ChannelItem1TypedView", "TesterMerchQty", "tester_merch_qty", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("ChannelItem1TypedView", "LiveMerchQty", "live_merch_qty", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("ChannelItem1TypedView", "NumStores", "num_stores", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("ChannelItem1TypedView", "Comments", "comments", false, "VarChar", 500, 0, 0, false, string.Empty, null, typeof(System.String), 6);
			this.AddElementFieldMapping("ChannelItem1TypedView", "SampleQty", "sample_qty", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 7);
		}


		/// <summary>Inits ChannelOwner1View's mappings</summary>
		private void InitChannelOwner1TypedViewMappings()
		{
			this.AddElementMapping("ChannelOwner1TypedView", @"mecca_cmt", @"dbo", "channel_owners", 4);
			this.AddElementFieldMapping("ChannelOwner1TypedView", "ChannelOwnerId", "channel_owner_id", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("ChannelOwner1TypedView", "CampaignId", "campaign_id", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("ChannelOwner1TypedView", "ChannelId", "channel_id", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("ChannelOwner1TypedView", "Owner", "owner", false, "NVarChar", 200, 0, 0, false, string.Empty, null, typeof(System.String), 3);
		}


		/// <summary>Inits ChannelType1View's mappings</summary>
		private void InitChannelType1TypedViewMappings()
		{
			this.AddElementMapping("ChannelType1TypedView", @"mecca_cmt", @"dbo", "channel_types", 2);
			this.AddElementFieldMapping("ChannelType1TypedView", "ChannelTypeId", "channel_type_id", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("ChannelType1TypedView", "ChannelTypeName", "channel_type_name", false, "NVarChar", 50, 0, 0, false, string.Empty, null, typeof(System.String), 1);
		}


		/// <summary>Inits RedemptionCode1View's mappings</summary>
		private void InitRedemptionCode1TypedViewMappings()
		{
			this.AddElementMapping("RedemptionCode1TypedView", @"mecca_cmt", @"dbo", "redemption_codes", 3);
			this.AddElementFieldMapping("RedemptionCode1TypedView", "RedemptionCodeId", "redemption_code_id", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("RedemptionCode1TypedView", "OfferCode", "offer_code", false, "NVarChar", 20, 0, 0, false, string.Empty, null, typeof(System.String), 1);
			this.AddElementFieldMapping("RedemptionCode1TypedView", "Description", "description", false, "NVarChar", 50, 0, 0, false, string.Empty, null, typeof(System.String), 2);
		}

	}
}
