///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Mecca.CMT.DAL.HelperClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>Singleton implementation of the FieldInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the FieldInfoProviderBase class is threadsafe.</remarks>
	internal static class FieldInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IFieldInfoProvider _providerInstance = new FieldInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static FieldInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the FieldInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IFieldInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the FieldInfoProvider. Used by singleton wrapper.</summary>
	internal class FieldInfoProviderCore : FieldInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="FieldInfoProviderCore"/> class.</summary>
		internal FieldInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			this.InitClass();
			InitCampaignEntityInfos();
			InitCampaignItemEntityInfos();
			InitCampaignOwnerEntityInfos();
			InitCampaignStoreEntityInfos();
			InitCampaignTypeEntityInfos();
			InitChannelEntityInfos();
			InitChannelCustomerEntityInfos();
			InitChannelItemEntityInfos();
			InitChannelOwnerEntityInfos();
			InitChannelStoreEntityInfos();
			InitChannelTypeEntityInfos();
			InitProductEntityInfos();
			InitRedemptionCodeEntityInfos();
			InitStoreEntityInfos();
			InitStoreOptionEntityInfos();
			InitCampaign1TypedViewInfos();
			InitCampaignOwner1TypedViewInfos();
			InitCampaignType1TypedViewInfos();
			InitChannel1TypedViewInfos();
			InitChannelCustomer1TypedViewInfos();
			InitChannelItem1TypedViewInfos();
			InitChannelOwner1TypedViewInfos();
			InitChannelType1TypedViewInfos();
			InitRedemptionCode1TypedViewInfos();
			this.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits CampaignEntity's FieldInfo objects</summary>
		private void InitCampaignEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CampaignFieldIndex), "CampaignEntity");
			this.AddElementFieldInfo("CampaignEntity", "BusinessFormat", typeof(System.String), false, false, false, false,  (int)CampaignFieldIndex.BusinessFormat, 10, 0, 0);
			this.AddElementFieldInfo("CampaignEntity", "CampaignCode", typeof(System.String), false, false, false, true,  (int)CampaignFieldIndex.CampaignCode, 10, 0, 0);
			this.AddElementFieldInfo("CampaignEntity", "CampaignId", typeof(System.Int32), true, false, true, false,  (int)CampaignFieldIndex.CampaignId, 0, 0, 10);
			this.AddElementFieldInfo("CampaignEntity", "CampaignName", typeof(System.String), false, false, false, false,  (int)CampaignFieldIndex.CampaignName, 100, 0, 0);
			this.AddElementFieldInfo("CampaignEntity", "CampaignTypeId", typeof(System.Int32), false, true, false, false,  (int)CampaignFieldIndex.CampaignTypeId, 0, 0, 10);
			this.AddElementFieldInfo("CampaignEntity", "CreatedBy", typeof(System.String), false, false, false, false,  (int)CampaignFieldIndex.CreatedBy, 200, 0, 0);
			this.AddElementFieldInfo("CampaignEntity", "Description", typeof(System.String), false, false, false, true,  (int)CampaignFieldIndex.Description, 250, 0, 0);
			this.AddElementFieldInfo("CampaignEntity", "EndDate", typeof(System.DateTime), false, false, false, false,  (int)CampaignFieldIndex.EndDate, 0, 0, 0);
			this.AddElementFieldInfo("CampaignEntity", "IsLocked", typeof(System.Int32), false, false, false, false,  (int)CampaignFieldIndex.IsLocked, 0, 0, 10);
			this.AddElementFieldInfo("CampaignEntity", "RedemptionCodeId", typeof(System.Int32), false, true, false, false,  (int)CampaignFieldIndex.RedemptionCodeId, 0, 0, 10);
			this.AddElementFieldInfo("CampaignEntity", "StartDate", typeof(System.DateTime), false, false, false, false,  (int)CampaignFieldIndex.StartDate, 0, 0, 0);
			this.AddElementFieldInfo("CampaignEntity", "StoreOptionId", typeof(System.Int32), false, false, false, false,  (int)CampaignFieldIndex.StoreOptionId, 0, 0, 10);
		}
		/// <summary>Inits CampaignItemEntity's FieldInfo objects</summary>
		private void InitCampaignItemEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CampaignItemFieldIndex), "CampaignItemEntity");
			this.AddElementFieldInfo("CampaignItemEntity", "CampaignId", typeof(System.Int32), false, true, false, false,  (int)CampaignItemFieldIndex.CampaignId, 0, 0, 10);
			this.AddElementFieldInfo("CampaignItemEntity", "CampaignItemId", typeof(System.Int32), true, false, true, false,  (int)CampaignItemFieldIndex.CampaignItemId, 0, 0, 10);
			this.AddElementFieldInfo("CampaignItemEntity", "DateAdded", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)CampaignItemFieldIndex.DateAdded, 0, 0, 0);
			this.AddElementFieldInfo("CampaignItemEntity", "EndDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)CampaignItemFieldIndex.EndDate, 0, 0, 0);
			this.AddElementFieldInfo("CampaignItemEntity", "ProductId", typeof(System.Int32), false, true, false, false,  (int)CampaignItemFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("CampaignItemEntity", "StartDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)CampaignItemFieldIndex.StartDate, 0, 0, 0);
		}
		/// <summary>Inits CampaignOwnerEntity's FieldInfo objects</summary>
		private void InitCampaignOwnerEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CampaignOwnerFieldIndex), "CampaignOwnerEntity");
			this.AddElementFieldInfo("CampaignOwnerEntity", "CampaignId", typeof(System.Int32), false, true, false, false,  (int)CampaignOwnerFieldIndex.CampaignId, 0, 0, 10);
			this.AddElementFieldInfo("CampaignOwnerEntity", "CampaignOwnerId", typeof(System.Int32), true, false, true, false,  (int)CampaignOwnerFieldIndex.CampaignOwnerId, 0, 0, 10);
			this.AddElementFieldInfo("CampaignOwnerEntity", "Owner", typeof(System.String), false, false, false, false,  (int)CampaignOwnerFieldIndex.Owner, 200, 0, 0);
		}
		/// <summary>Inits CampaignStoreEntity's FieldInfo objects</summary>
		private void InitCampaignStoreEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CampaignStoreFieldIndex), "CampaignStoreEntity");
			this.AddElementFieldInfo("CampaignStoreEntity", "CampaignId", typeof(System.Int32), false, false, false, false,  (int)CampaignStoreFieldIndex.CampaignId, 0, 0, 10);
			this.AddElementFieldInfo("CampaignStoreEntity", "CampaignStoreId", typeof(System.Int32), true, false, true, false,  (int)CampaignStoreFieldIndex.CampaignStoreId, 0, 0, 10);
			this.AddElementFieldInfo("CampaignStoreEntity", "DateAdded", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)CampaignStoreFieldIndex.DateAdded, 0, 0, 0);
			this.AddElementFieldInfo("CampaignStoreEntity", "IsSelected", typeof(System.Int32), false, false, false, false,  (int)CampaignStoreFieldIndex.IsSelected, 0, 0, 10);
			this.AddElementFieldInfo("CampaignStoreEntity", "StoreId", typeof(System.Int32), false, false, false, false,  (int)CampaignStoreFieldIndex.StoreId, 0, 0, 10);
		}
		/// <summary>Inits CampaignTypeEntity's FieldInfo objects</summary>
		private void InitCampaignTypeEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CampaignTypeFieldIndex), "CampaignTypeEntity");
			this.AddElementFieldInfo("CampaignTypeEntity", "CampaignTypeId", typeof(System.Int32), true, false, true, false,  (int)CampaignTypeFieldIndex.CampaignTypeId, 0, 0, 10);
			this.AddElementFieldInfo("CampaignTypeEntity", "CampaignTypeName", typeof(System.String), false, false, false, false,  (int)CampaignTypeFieldIndex.CampaignTypeName, 50, 0, 0);
		}
		/// <summary>Inits ChannelEntity's FieldInfo objects</summary>
		private void InitChannelEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ChannelFieldIndex), "ChannelEntity");
			this.AddElementFieldInfo("ChannelEntity", "CampaignId", typeof(System.Int32), false, true, false, false,  (int)ChannelFieldIndex.CampaignId, 0, 0, 10);
			this.AddElementFieldInfo("ChannelEntity", "ChannelCode", typeof(System.String), false, false, false, true,  (int)ChannelFieldIndex.ChannelCode, 10, 0, 0);
			this.AddElementFieldInfo("ChannelEntity", "ChannelId", typeof(System.Int32), true, false, true, false,  (int)ChannelFieldIndex.ChannelId, 0, 0, 10);
			this.AddElementFieldInfo("ChannelEntity", "ChannelName", typeof(System.String), false, false, false, false,  (int)ChannelFieldIndex.ChannelName, 250, 0, 0);
			this.AddElementFieldInfo("ChannelEntity", "ChannelTypeId", typeof(System.Int32), false, true, false, false,  (int)ChannelFieldIndex.ChannelTypeId, 0, 0, 10);
			this.AddElementFieldInfo("ChannelEntity", "CreatedBy", typeof(System.String), false, false, false, false,  (int)ChannelFieldIndex.CreatedBy, 200, 0, 0);
			this.AddElementFieldInfo("ChannelEntity", "Description", typeof(System.String), false, false, false, true,  (int)ChannelFieldIndex.Description, 250, 0, 0);
			this.AddElementFieldInfo("ChannelEntity", "EndDate", typeof(System.DateTime), false, false, false, false,  (int)ChannelFieldIndex.EndDate, 0, 0, 0);
			this.AddElementFieldInfo("ChannelEntity", "IsLocked", typeof(System.Int32), false, false, false, false,  (int)ChannelFieldIndex.IsLocked, 0, 0, 10);
			this.AddElementFieldInfo("ChannelEntity", "RedemptionCodeId", typeof(System.Int32), false, true, false, false,  (int)ChannelFieldIndex.RedemptionCodeId, 0, 0, 10);
			this.AddElementFieldInfo("ChannelEntity", "StartDate", typeof(System.DateTime), false, false, false, false,  (int)ChannelFieldIndex.StartDate, 0, 0, 0);
			this.AddElementFieldInfo("ChannelEntity", "StoreOptionId", typeof(System.Int32), false, false, false, false,  (int)ChannelFieldIndex.StoreOptionId, 0, 0, 10);
		}
		/// <summary>Inits ChannelCustomerEntity's FieldInfo objects</summary>
		private void InitChannelCustomerEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ChannelCustomerFieldIndex), "ChannelCustomerEntity");
			this.AddElementFieldInfo("ChannelCustomerEntity", "ChannelCustomerId", typeof(System.Int32), true, false, true, false,  (int)ChannelCustomerFieldIndex.ChannelCustomerId, 0, 0, 10);
			this.AddElementFieldInfo("ChannelCustomerEntity", "ChannelId", typeof(System.Int32), false, true, false, false,  (int)ChannelCustomerFieldIndex.ChannelId, 0, 0, 10);
			this.AddElementFieldInfo("ChannelCustomerEntity", "CustomerSid", typeof(System.Int64), false, false, false, false,  (int)ChannelCustomerFieldIndex.CustomerSid, 0, 0, 19);
		}
		/// <summary>Inits ChannelItemEntity's FieldInfo objects</summary>
		private void InitChannelItemEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ChannelItemFieldIndex), "ChannelItemEntity");
			this.AddElementFieldInfo("ChannelItemEntity", "ChannelId", typeof(System.Int32), false, true, false, false,  (int)ChannelItemFieldIndex.ChannelId, 0, 0, 10);
			this.AddElementFieldInfo("ChannelItemEntity", "ChannelItemId", typeof(System.Int32), true, false, true, false,  (int)ChannelItemFieldIndex.ChannelItemId, 0, 0, 10);
			this.AddElementFieldInfo("ChannelItemEntity", "Comments", typeof(System.String), false, false, false, true,  (int)ChannelItemFieldIndex.Comments, 500, 0, 0);
			this.AddElementFieldInfo("ChannelItemEntity", "LiveMerchQty", typeof(Nullable<System.Int32>), false, false, false, true,  (int)ChannelItemFieldIndex.LiveMerchQty, 0, 0, 10);
			this.AddElementFieldInfo("ChannelItemEntity", "NumStores", typeof(Nullable<System.Int32>), false, false, false, true,  (int)ChannelItemFieldIndex.NumStores, 0, 0, 10);
			this.AddElementFieldInfo("ChannelItemEntity", "ProductId", typeof(System.Int32), false, true, false, false,  (int)ChannelItemFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("ChannelItemEntity", "SampleQty", typeof(Nullable<System.Int32>), false, false, false, true,  (int)ChannelItemFieldIndex.SampleQty, 0, 0, 10);
			this.AddElementFieldInfo("ChannelItemEntity", "TesterMerchQty", typeof(Nullable<System.Int32>), false, false, false, true,  (int)ChannelItemFieldIndex.TesterMerchQty, 0, 0, 10);
		}
		/// <summary>Inits ChannelOwnerEntity's FieldInfo objects</summary>
		private void InitChannelOwnerEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ChannelOwnerFieldIndex), "ChannelOwnerEntity");
			this.AddElementFieldInfo("ChannelOwnerEntity", "CampaignId", typeof(System.Int32), false, true, false, false,  (int)ChannelOwnerFieldIndex.CampaignId, 0, 0, 10);
			this.AddElementFieldInfo("ChannelOwnerEntity", "ChannelId", typeof(System.Int32), false, true, false, false,  (int)ChannelOwnerFieldIndex.ChannelId, 0, 0, 10);
			this.AddElementFieldInfo("ChannelOwnerEntity", "ChannelOwnerId", typeof(System.Int32), true, false, true, false,  (int)ChannelOwnerFieldIndex.ChannelOwnerId, 0, 0, 10);
			this.AddElementFieldInfo("ChannelOwnerEntity", "Owner", typeof(System.String), false, false, false, false,  (int)ChannelOwnerFieldIndex.Owner, 200, 0, 0);
		}
		/// <summary>Inits ChannelStoreEntity's FieldInfo objects</summary>
		private void InitChannelStoreEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ChannelStoreFieldIndex), "ChannelStoreEntity");
			this.AddElementFieldInfo("ChannelStoreEntity", "CampaignId", typeof(System.Int32), false, false, false, false,  (int)ChannelStoreFieldIndex.CampaignId, 0, 0, 10);
			this.AddElementFieldInfo("ChannelStoreEntity", "ChannelId", typeof(System.Int32), false, false, false, false,  (int)ChannelStoreFieldIndex.ChannelId, 0, 0, 10);
			this.AddElementFieldInfo("ChannelStoreEntity", "ChannelStoreId", typeof(System.Int32), true, false, true, false,  (int)ChannelStoreFieldIndex.ChannelStoreId, 0, 0, 10);
			this.AddElementFieldInfo("ChannelStoreEntity", "DateAdded", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ChannelStoreFieldIndex.DateAdded, 0, 0, 0);
			this.AddElementFieldInfo("ChannelStoreEntity", "IsSelected", typeof(System.Int32), false, false, false, false,  (int)ChannelStoreFieldIndex.IsSelected, 0, 0, 10);
			this.AddElementFieldInfo("ChannelStoreEntity", "StoreId", typeof(System.Int32), false, false, false, false,  (int)ChannelStoreFieldIndex.StoreId, 0, 0, 10);
		}
		/// <summary>Inits ChannelTypeEntity's FieldInfo objects</summary>
		private void InitChannelTypeEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ChannelTypeFieldIndex), "ChannelTypeEntity");
			this.AddElementFieldInfo("ChannelTypeEntity", "ChannelTypeId", typeof(System.Int32), true, false, true, false,  (int)ChannelTypeFieldIndex.ChannelTypeId, 0, 0, 10);
			this.AddElementFieldInfo("ChannelTypeEntity", "ChannelTypeName", typeof(System.String), false, false, false, false,  (int)ChannelTypeFieldIndex.ChannelTypeName, 50, 0, 0);
		}
		/// <summary>Inits ProductEntity's FieldInfo objects</summary>
		private void InitProductEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductFieldIndex), "ProductEntity");
			this.AddElementFieldInfo("ProductEntity", "CategoryName", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.CategoryName, 50, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "CompanySoh", typeof(Nullable<System.Int32>), false, false, false, true,  (int)ProductFieldIndex.CompanySoh, 0, 0, 10);
			this.AddElementFieldInfo("ProductEntity", "DepartmentName", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.DepartmentName, 50, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "Description", typeof(System.String), false, false, false, false,  (int)ProductFieldIndex.Description, 30, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "ExpectedReceiptDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ProductFieldIndex.ExpectedReceiptDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "ItemCode", typeof(System.String), false, false, false, false,  (int)ProductFieldIndex.ItemCode, 20, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "ItemSid", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)ProductFieldIndex.ItemSid, 0, 0, 19);
			this.AddElementFieldInfo("ProductEntity", "LaunchDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ProductFieldIndex.LaunchDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "Lifestage", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.Lifestage, 5, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "LimitedEdition", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.LimitedEdition, 3, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "NoTester", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.NoTester, 50, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "NzUnitPrice", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)ProductFieldIndex.NzUnitPrice, 0, 3, 12);
			this.AddElementFieldInfo("ProductEntity", "ProductId", typeof(System.Int32), true, false, true, false,  (int)ProductFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("ProductEntity", "RangingCodeImo", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.RangingCodeImo, 342, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "RangingCodeKit", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.RangingCodeKit, 342, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "RangingCodeMaxima", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.RangingCodeMaxima, 342, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "RangingCodeMecca", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.RangingCodeMecca, 342, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "StockOnOrder", typeof(Nullable<System.Int32>), false, false, false, true,  (int)ProductFieldIndex.StockOnOrder, 0, 0, 10);
			this.AddElementFieldInfo("ProductEntity", "TerminationDate", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.TerminationDate, 10, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "TransitionItemCode", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.TransitionItemCode, 20, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "TravelSize", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.TravelSize, 5, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "UnitPrice", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)ProductFieldIndex.UnitPrice, 0, 3, 12);
			this.AddElementFieldInfo("ProductEntity", "VendorCode", typeof(System.String), false, false, false, false,  (int)ProductFieldIndex.VendorCode, 20, 0, 0);
		}
		/// <summary>Inits RedemptionCodeEntity's FieldInfo objects</summary>
		private void InitRedemptionCodeEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(RedemptionCodeFieldIndex), "RedemptionCodeEntity");
			this.AddElementFieldInfo("RedemptionCodeEntity", "Description", typeof(System.String), false, false, false, false,  (int)RedemptionCodeFieldIndex.Description, 50, 0, 0);
			this.AddElementFieldInfo("RedemptionCodeEntity", "OfferCode", typeof(System.String), false, false, false, false,  (int)RedemptionCodeFieldIndex.OfferCode, 20, 0, 0);
			this.AddElementFieldInfo("RedemptionCodeEntity", "RedemptionCodeId", typeof(System.Int32), true, false, true, false,  (int)RedemptionCodeFieldIndex.RedemptionCodeId, 0, 0, 10);
		}
		/// <summary>Inits StoreEntity's FieldInfo objects</summary>
		private void InitStoreEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(StoreFieldIndex), "StoreEntity");
			this.AddElementFieldInfo("StoreEntity", "BusinessName", typeof(System.String), false, false, false, false,  (int)StoreFieldIndex.BusinessName, 50, 0, 0);
			this.AddElementFieldInfo("StoreEntity", "OpenDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)StoreFieldIndex.OpenDate, 0, 0, 0);
			this.AddElementFieldInfo("StoreEntity", "StoreCode", typeof(System.String), false, false, false, false,  (int)StoreFieldIndex.StoreCode, 20, 0, 0);
			this.AddElementFieldInfo("StoreEntity", "StoreId", typeof(System.Int32), true, false, true, false,  (int)StoreFieldIndex.StoreId, 0, 0, 10);
			this.AddElementFieldInfo("StoreEntity", "StoreName", typeof(System.String), false, false, false, false,  (int)StoreFieldIndex.StoreName, 50, 0, 0);
		}
		/// <summary>Inits StoreOptionEntity's FieldInfo objects</summary>
		private void InitStoreOptionEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(StoreOptionFieldIndex), "StoreOptionEntity");
			this.AddElementFieldInfo("StoreOptionEntity", "StoreOptionId", typeof(System.Int32), true, false, false, false,  (int)StoreOptionFieldIndex.StoreOptionId, 0, 0, 10);
			this.AddElementFieldInfo("StoreOptionEntity", "StoreOptionName", typeof(System.String), false, false, false, false,  (int)StoreOptionFieldIndex.StoreOptionName, 50, 0, 0);
		}

		/// <summary>Inits View's FieldInfo objects</summary>
		private void InitCampaign1TypedViewInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(Campaign1FieldIndex), "Campaign1TypedView");
			this.AddElementFieldInfo("Campaign1TypedView", "CampaignId", typeof(System.Int32), false, false, true, false, (int)Campaign1FieldIndex.CampaignId, 0, 0, 10);
			this.AddElementFieldInfo("Campaign1TypedView", "BusinessFormat", typeof(System.String), false, false, true, false, (int)Campaign1FieldIndex.BusinessFormat, 10, 0, 0);
			this.AddElementFieldInfo("Campaign1TypedView", "CampaignCode", typeof(System.String), false, false, true, false, (int)Campaign1FieldIndex.CampaignCode, 10, 0, 0);
			this.AddElementFieldInfo("Campaign1TypedView", "CampaignName", typeof(System.String), false, false, true, false, (int)Campaign1FieldIndex.CampaignName, 100, 0, 0);
			this.AddElementFieldInfo("Campaign1TypedView", "CampaignTypeId", typeof(System.Int32), false, false, true, false, (int)Campaign1FieldIndex.CampaignTypeId, 0, 0, 10);
			this.AddElementFieldInfo("Campaign1TypedView", "Description", typeof(System.String), false, false, true, false, (int)Campaign1FieldIndex.Description, 250, 0, 0);
			this.AddElementFieldInfo("Campaign1TypedView", "StartDate", typeof(System.DateTime), false, false, true, false, (int)Campaign1FieldIndex.StartDate, 0, 0, 0);
			this.AddElementFieldInfo("Campaign1TypedView", "EndDate", typeof(System.DateTime), false, false, true, false, (int)Campaign1FieldIndex.EndDate, 0, 0, 0);
			this.AddElementFieldInfo("Campaign1TypedView", "RedemptionCodeId", typeof(System.Int32), false, false, true, false, (int)Campaign1FieldIndex.RedemptionCodeId, 0, 0, 10);
			this.AddElementFieldInfo("Campaign1TypedView", "IsLocked", typeof(System.Int32), false, false, true, false, (int)Campaign1FieldIndex.IsLocked, 0, 0, 10);
			this.AddElementFieldInfo("Campaign1TypedView", "CreatedBy", typeof(System.String), false, false, true, false, (int)Campaign1FieldIndex.CreatedBy, 200, 0, 0);
			this.AddElementFieldInfo("Campaign1TypedView", "StoreOptionId", typeof(System.Int32), false, false, true, false, (int)Campaign1FieldIndex.StoreOptionId, 0, 0, 10);
		}
		/// <summary>Inits View's FieldInfo objects</summary>
		private void InitCampaignOwner1TypedViewInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CampaignOwner1FieldIndex), "CampaignOwner1TypedView");
			this.AddElementFieldInfo("CampaignOwner1TypedView", "CampaignOwnerId", typeof(System.Int32), false, false, true, false, (int)CampaignOwner1FieldIndex.CampaignOwnerId, 0, 0, 10);
			this.AddElementFieldInfo("CampaignOwner1TypedView", "CampaignId", typeof(System.Int32), false, false, true, false, (int)CampaignOwner1FieldIndex.CampaignId, 0, 0, 10);
			this.AddElementFieldInfo("CampaignOwner1TypedView", "Owner", typeof(System.String), false, false, true, false, (int)CampaignOwner1FieldIndex.Owner, 200, 0, 0);
		}
		/// <summary>Inits View's FieldInfo objects</summary>
		private void InitCampaignType1TypedViewInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CampaignType1FieldIndex), "CampaignType1TypedView");
			this.AddElementFieldInfo("CampaignType1TypedView", "CampaignTypeId", typeof(System.Int32), false, false, true, false, (int)CampaignType1FieldIndex.CampaignTypeId, 0, 0, 10);
			this.AddElementFieldInfo("CampaignType1TypedView", "CampaignTypeName", typeof(System.String), false, false, true, false, (int)CampaignType1FieldIndex.CampaignTypeName, 50, 0, 0);
		}
		/// <summary>Inits View's FieldInfo objects</summary>
		private void InitChannel1TypedViewInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(Channel1FieldIndex), "Channel1TypedView");
			this.AddElementFieldInfo("Channel1TypedView", "ChannelId", typeof(System.Int32), false, false, true, false, (int)Channel1FieldIndex.ChannelId, 0, 0, 10);
			this.AddElementFieldInfo("Channel1TypedView", "CampaignId", typeof(System.Int32), false, false, true, false, (int)Channel1FieldIndex.CampaignId, 0, 0, 10);
			this.AddElementFieldInfo("Channel1TypedView", "ChannelName", typeof(System.String), false, false, true, false, (int)Channel1FieldIndex.ChannelName, 250, 0, 0);
			this.AddElementFieldInfo("Channel1TypedView", "ChannelTypeId", typeof(System.Int32), false, false, true, false, (int)Channel1FieldIndex.ChannelTypeId, 0, 0, 10);
			this.AddElementFieldInfo("Channel1TypedView", "Description", typeof(System.String), false, false, true, false, (int)Channel1FieldIndex.Description, 250, 0, 0);
			this.AddElementFieldInfo("Channel1TypedView", "StartDate", typeof(System.DateTime), false, false, true, false, (int)Channel1FieldIndex.StartDate, 0, 0, 0);
			this.AddElementFieldInfo("Channel1TypedView", "EndDate", typeof(System.DateTime), false, false, true, false, (int)Channel1FieldIndex.EndDate, 0, 0, 0);
			this.AddElementFieldInfo("Channel1TypedView", "ChannelCode", typeof(System.String), false, false, true, false, (int)Channel1FieldIndex.ChannelCode, 10, 0, 0);
			this.AddElementFieldInfo("Channel1TypedView", "RedemptionCodeId", typeof(System.Int32), false, false, true, false, (int)Channel1FieldIndex.RedemptionCodeId, 0, 0, 10);
			this.AddElementFieldInfo("Channel1TypedView", "IsLocked", typeof(System.Int32), false, false, true, false, (int)Channel1FieldIndex.IsLocked, 0, 0, 10);
			this.AddElementFieldInfo("Channel1TypedView", "CreatedBy", typeof(System.String), false, false, true, false, (int)Channel1FieldIndex.CreatedBy, 200, 0, 0);
			this.AddElementFieldInfo("Channel1TypedView", "StoreOptionId", typeof(System.Int32), false, false, true, false, (int)Channel1FieldIndex.StoreOptionId, 0, 0, 10);
		}
		/// <summary>Inits View's FieldInfo objects</summary>
		private void InitChannelCustomer1TypedViewInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ChannelCustomer1FieldIndex), "ChannelCustomer1TypedView");
			this.AddElementFieldInfo("ChannelCustomer1TypedView", "ChannelCustomerId", typeof(System.Int32), false, false, true, false, (int)ChannelCustomer1FieldIndex.ChannelCustomerId, 0, 0, 10);
			this.AddElementFieldInfo("ChannelCustomer1TypedView", "ChannelId", typeof(System.Int32), false, false, true, false, (int)ChannelCustomer1FieldIndex.ChannelId, 0, 0, 10);
			this.AddElementFieldInfo("ChannelCustomer1TypedView", "CustomerSid", typeof(System.Int64), false, false, true, false, (int)ChannelCustomer1FieldIndex.CustomerSid, 0, 0, 19);
		}
		/// <summary>Inits View's FieldInfo objects</summary>
		private void InitChannelItem1TypedViewInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ChannelItem1FieldIndex), "ChannelItem1TypedView");
			this.AddElementFieldInfo("ChannelItem1TypedView", "ChannelItemId", typeof(System.Int32), false, false, true, false, (int)ChannelItem1FieldIndex.ChannelItemId, 0, 0, 10);
			this.AddElementFieldInfo("ChannelItem1TypedView", "ChannelId", typeof(System.Int32), false, false, true, false, (int)ChannelItem1FieldIndex.ChannelId, 0, 0, 10);
			this.AddElementFieldInfo("ChannelItem1TypedView", "ProductId", typeof(System.Int32), false, false, true, false, (int)ChannelItem1FieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("ChannelItem1TypedView", "TesterMerchQty", typeof(Nullable<System.Int32>), false, false, true, false, (int)ChannelItem1FieldIndex.TesterMerchQty, 0, 0, 10);
			this.AddElementFieldInfo("ChannelItem1TypedView", "LiveMerchQty", typeof(Nullable<System.Int32>), false, false, true, false, (int)ChannelItem1FieldIndex.LiveMerchQty, 0, 0, 10);
			this.AddElementFieldInfo("ChannelItem1TypedView", "NumStores", typeof(Nullable<System.Int32>), false, false, true, false, (int)ChannelItem1FieldIndex.NumStores, 0, 0, 10);
			this.AddElementFieldInfo("ChannelItem1TypedView", "Comments", typeof(System.String), false, false, true, false, (int)ChannelItem1FieldIndex.Comments, 500, 0, 0);
			this.AddElementFieldInfo("ChannelItem1TypedView", "SampleQty", typeof(Nullable<System.Int32>), false, false, true, false, (int)ChannelItem1FieldIndex.SampleQty, 0, 0, 10);
		}
		/// <summary>Inits View's FieldInfo objects</summary>
		private void InitChannelOwner1TypedViewInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ChannelOwner1FieldIndex), "ChannelOwner1TypedView");
			this.AddElementFieldInfo("ChannelOwner1TypedView", "ChannelOwnerId", typeof(System.Int32), false, false, true, false, (int)ChannelOwner1FieldIndex.ChannelOwnerId, 0, 0, 10);
			this.AddElementFieldInfo("ChannelOwner1TypedView", "CampaignId", typeof(System.Int32), false, false, true, false, (int)ChannelOwner1FieldIndex.CampaignId, 0, 0, 10);
			this.AddElementFieldInfo("ChannelOwner1TypedView", "ChannelId", typeof(System.Int32), false, false, true, false, (int)ChannelOwner1FieldIndex.ChannelId, 0, 0, 10);
			this.AddElementFieldInfo("ChannelOwner1TypedView", "Owner", typeof(System.String), false, false, true, false, (int)ChannelOwner1FieldIndex.Owner, 200, 0, 0);
		}
		/// <summary>Inits View's FieldInfo objects</summary>
		private void InitChannelType1TypedViewInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ChannelType1FieldIndex), "ChannelType1TypedView");
			this.AddElementFieldInfo("ChannelType1TypedView", "ChannelTypeId", typeof(System.Int32), false, false, true, false, (int)ChannelType1FieldIndex.ChannelTypeId, 0, 0, 10);
			this.AddElementFieldInfo("ChannelType1TypedView", "ChannelTypeName", typeof(System.String), false, false, true, false, (int)ChannelType1FieldIndex.ChannelTypeName, 50, 0, 0);
		}
		/// <summary>Inits View's FieldInfo objects</summary>
		private void InitRedemptionCode1TypedViewInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(RedemptionCode1FieldIndex), "RedemptionCode1TypedView");
			this.AddElementFieldInfo("RedemptionCode1TypedView", "RedemptionCodeId", typeof(System.Int32), false, false, true, false, (int)RedemptionCode1FieldIndex.RedemptionCodeId, 0, 0, 10);
			this.AddElementFieldInfo("RedemptionCode1TypedView", "OfferCode", typeof(System.String), false, false, true, false, (int)RedemptionCode1FieldIndex.OfferCode, 20, 0, 0);
			this.AddElementFieldInfo("RedemptionCode1TypedView", "Description", typeof(System.String), false, false, true, false, (int)RedemptionCode1FieldIndex.Description, 50, 0, 0);
		}		
	}
}




