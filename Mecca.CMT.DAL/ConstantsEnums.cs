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

namespace Mecca.CMT.DAL
{
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Campaign.</summary>
	public enum CampaignFieldIndex
	{
		///<summary>BusinessFormat. </summary>
		BusinessFormat,
		///<summary>CampaignCode. </summary>
		CampaignCode,
		///<summary>CampaignId. </summary>
		CampaignId,
		///<summary>CampaignName. </summary>
		CampaignName,
		///<summary>CampaignTypeId. </summary>
		CampaignTypeId,
		///<summary>CreatedBy. </summary>
		CreatedBy,
		///<summary>Description. </summary>
		Description,
		///<summary>EndDate. </summary>
		EndDate,
		///<summary>IsLocked. </summary>
		IsLocked,
		///<summary>RedemptionCodeId. </summary>
		RedemptionCodeId,
		///<summary>StartDate. </summary>
		StartDate,
		///<summary>StoreOptionId. </summary>
		StoreOptionId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CampaignItem.</summary>
	public enum CampaignItemFieldIndex
	{
		///<summary>CampaignId. </summary>
		CampaignId,
		///<summary>CampaignItemId. </summary>
		CampaignItemId,
		///<summary>DateAdded. </summary>
		DateAdded,
		///<summary>EndDate. </summary>
		EndDate,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>StartDate. </summary>
		StartDate,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CampaignOwner.</summary>
	public enum CampaignOwnerFieldIndex
	{
		///<summary>CampaignId. </summary>
		CampaignId,
		///<summary>CampaignOwnerId. </summary>
		CampaignOwnerId,
		///<summary>Owner. </summary>
		Owner,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CampaignStore.</summary>
	public enum CampaignStoreFieldIndex
	{
		///<summary>CampaignId. </summary>
		CampaignId,
		///<summary>CampaignStoreId. </summary>
		CampaignStoreId,
		///<summary>DateAdded. </summary>
		DateAdded,
		///<summary>IsSelected. </summary>
		IsSelected,
		///<summary>StoreId. </summary>
		StoreId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CampaignType.</summary>
	public enum CampaignTypeFieldIndex
	{
		///<summary>CampaignTypeId. </summary>
		CampaignTypeId,
		///<summary>CampaignTypeName. </summary>
		CampaignTypeName,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Channel.</summary>
	public enum ChannelFieldIndex
	{
		///<summary>CampaignId. </summary>
		CampaignId,
		///<summary>ChannelCode. </summary>
		ChannelCode,
		///<summary>ChannelId. </summary>
		ChannelId,
		///<summary>ChannelName. </summary>
		ChannelName,
		///<summary>ChannelTypeId. </summary>
		ChannelTypeId,
		///<summary>CreatedBy. </summary>
		CreatedBy,
		///<summary>Description. </summary>
		Description,
		///<summary>EndDate. </summary>
		EndDate,
		///<summary>IsLocked. </summary>
		IsLocked,
		///<summary>RedemptionCodeId. </summary>
		RedemptionCodeId,
		///<summary>StartDate. </summary>
		StartDate,
		///<summary>StoreOptionId. </summary>
		StoreOptionId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ChannelCustomer.</summary>
	public enum ChannelCustomerFieldIndex
	{
		///<summary>ChannelCustomerId. </summary>
		ChannelCustomerId,
		///<summary>ChannelId. </summary>
		ChannelId,
		///<summary>CustomerSid. </summary>
		CustomerSid,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ChannelItem.</summary>
	public enum ChannelItemFieldIndex
	{
		///<summary>ChannelId. </summary>
		ChannelId,
		///<summary>ChannelItemId. </summary>
		ChannelItemId,
		///<summary>Comments. </summary>
		Comments,
		///<summary>LiveMerchQty. </summary>
		LiveMerchQty,
		///<summary>NumStores. </summary>
		NumStores,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>SampleQty. </summary>
		SampleQty,
		///<summary>TesterMerchQty. </summary>
		TesterMerchQty,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ChannelOwner.</summary>
	public enum ChannelOwnerFieldIndex
	{
		///<summary>CampaignId. </summary>
		CampaignId,
		///<summary>ChannelId. </summary>
		ChannelId,
		///<summary>ChannelOwnerId. </summary>
		ChannelOwnerId,
		///<summary>Owner. </summary>
		Owner,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ChannelStore.</summary>
	public enum ChannelStoreFieldIndex
	{
		///<summary>CampaignId. </summary>
		CampaignId,
		///<summary>ChannelId. </summary>
		ChannelId,
		///<summary>ChannelStoreId. </summary>
		ChannelStoreId,
		///<summary>DateAdded. </summary>
		DateAdded,
		///<summary>IsSelected. </summary>
		IsSelected,
		///<summary>StoreId. </summary>
		StoreId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ChannelType.</summary>
	public enum ChannelTypeFieldIndex
	{
		///<summary>ChannelTypeId. </summary>
		ChannelTypeId,
		///<summary>ChannelTypeName. </summary>
		ChannelTypeName,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Product.</summary>
	public enum ProductFieldIndex
	{
		///<summary>CategoryName. </summary>
		CategoryName,
		///<summary>CompanySoh. </summary>
		CompanySoh,
		///<summary>DepartmentName. </summary>
		DepartmentName,
		///<summary>Description. </summary>
		Description,
		///<summary>ExpectedReceiptDate. </summary>
		ExpectedReceiptDate,
		///<summary>ItemCode. </summary>
		ItemCode,
		///<summary>ItemSid. </summary>
		ItemSid,
		///<summary>LaunchDate. </summary>
		LaunchDate,
		///<summary>Lifestage. </summary>
		Lifestage,
		///<summary>LimitedEdition. </summary>
		LimitedEdition,
		///<summary>NoTester. </summary>
		NoTester,
		///<summary>NzUnitPrice. </summary>
		NzUnitPrice,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>RangingCodeImo. </summary>
		RangingCodeImo,
		///<summary>RangingCodeKit. </summary>
		RangingCodeKit,
		///<summary>RangingCodeMaxima. </summary>
		RangingCodeMaxima,
		///<summary>RangingCodeMecca. </summary>
		RangingCodeMecca,
		///<summary>StockOnOrder. </summary>
		StockOnOrder,
		///<summary>TerminationDate. </summary>
		TerminationDate,
		///<summary>TransitionItemCode. </summary>
		TransitionItemCode,
		///<summary>TravelSize. </summary>
		TravelSize,
		///<summary>UnitPrice. </summary>
		UnitPrice,
		///<summary>VendorCode. </summary>
		VendorCode,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: RedemptionCode.</summary>
	public enum RedemptionCodeFieldIndex
	{
		///<summary>Description. </summary>
		Description,
		///<summary>OfferCode. </summary>
		OfferCode,
		///<summary>RedemptionCodeId. </summary>
		RedemptionCodeId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Store.</summary>
	public enum StoreFieldIndex
	{
		///<summary>BusinessName. </summary>
		BusinessName,
		///<summary>OpenDate. </summary>
		OpenDate,
		///<summary>StoreCode. </summary>
		StoreCode,
		///<summary>StoreId. </summary>
		StoreId,
		///<summary>StoreName. </summary>
		StoreName,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: StoreOption.</summary>
	public enum StoreOptionFieldIndex
	{
		///<summary>StoreOptionId. </summary>
		StoreOptionId,
		///<summary>StoreOptionName. </summary>
		StoreOptionName,
		/// <summary></summary>
		AmountOfFields
	}

	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : Campaign1.</summary>
	public enum Campaign1FieldIndex
	{
		///<summary>CampaignId</summary>
		CampaignId,
		///<summary>BusinessFormat</summary>
		BusinessFormat,
		///<summary>CampaignCode</summary>
		CampaignCode,
		///<summary>CampaignName</summary>
		CampaignName,
		///<summary>CampaignTypeId</summary>
		CampaignTypeId,
		///<summary>Description</summary>
		Description,
		///<summary>StartDate</summary>
		StartDate,
		///<summary>EndDate</summary>
		EndDate,
		///<summary>RedemptionCodeId</summary>
		RedemptionCodeId,
		///<summary>IsLocked</summary>
		IsLocked,
		///<summary>CreatedBy</summary>
		CreatedBy,
		///<summary>StoreOptionId</summary>
		StoreOptionId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : CampaignOwner1.</summary>
	public enum CampaignOwner1FieldIndex
	{
		///<summary>CampaignOwnerId</summary>
		CampaignOwnerId,
		///<summary>CampaignId</summary>
		CampaignId,
		///<summary>Owner</summary>
		Owner,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : CampaignType1.</summary>
	public enum CampaignType1FieldIndex
	{
		///<summary>CampaignTypeId</summary>
		CampaignTypeId,
		///<summary>CampaignTypeName</summary>
		CampaignTypeName,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : Channel1.</summary>
	public enum Channel1FieldIndex
	{
		///<summary>ChannelId</summary>
		ChannelId,
		///<summary>CampaignId</summary>
		CampaignId,
		///<summary>ChannelName</summary>
		ChannelName,
		///<summary>ChannelTypeId</summary>
		ChannelTypeId,
		///<summary>Description</summary>
		Description,
		///<summary>StartDate</summary>
		StartDate,
		///<summary>EndDate</summary>
		EndDate,
		///<summary>ChannelCode</summary>
		ChannelCode,
		///<summary>RedemptionCodeId</summary>
		RedemptionCodeId,
		///<summary>IsLocked</summary>
		IsLocked,
		///<summary>CreatedBy</summary>
		CreatedBy,
		///<summary>StoreOptionId</summary>
		StoreOptionId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : ChannelCustomer1.</summary>
	public enum ChannelCustomer1FieldIndex
	{
		///<summary>ChannelCustomerId</summary>
		ChannelCustomerId,
		///<summary>ChannelId</summary>
		ChannelId,
		///<summary>CustomerSid</summary>
		CustomerSid,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : ChannelItem1.</summary>
	public enum ChannelItem1FieldIndex
	{
		///<summary>ChannelItemId</summary>
		ChannelItemId,
		///<summary>ChannelId</summary>
		ChannelId,
		///<summary>ProductId</summary>
		ProductId,
		///<summary>TesterMerchQty</summary>
		TesterMerchQty,
		///<summary>LiveMerchQty</summary>
		LiveMerchQty,
		///<summary>NumStores</summary>
		NumStores,
		///<summary>Comments</summary>
		Comments,
		///<summary>SampleQty</summary>
		SampleQty,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : ChannelOwner1.</summary>
	public enum ChannelOwner1FieldIndex
	{
		///<summary>ChannelOwnerId</summary>
		ChannelOwnerId,
		///<summary>CampaignId</summary>
		CampaignId,
		///<summary>ChannelId</summary>
		ChannelId,
		///<summary>Owner</summary>
		Owner,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : ChannelType1.</summary>
	public enum ChannelType1FieldIndex
	{
		///<summary>ChannelTypeId</summary>
		ChannelTypeId,
		///<summary>ChannelTypeName</summary>
		ChannelTypeName,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : RedemptionCode1.</summary>
	public enum RedemptionCode1FieldIndex
	{
		///<summary>RedemptionCodeId</summary>
		RedemptionCodeId,
		///<summary>OfferCode</summary>
		OfferCode,
		///<summary>Description</summary>
		Description,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>Enum definition for all the entity types defined in this namespace. Used by the entityfields factory.</summary>
	public enum EntityType
	{
		///<summary>Campaign</summary>
		CampaignEntity,
		///<summary>CampaignItem</summary>
		CampaignItemEntity,
		///<summary>CampaignOwner</summary>
		CampaignOwnerEntity,
		///<summary>CampaignStore</summary>
		CampaignStoreEntity,
		///<summary>CampaignType</summary>
		CampaignTypeEntity,
		///<summary>Channel</summary>
		ChannelEntity,
		///<summary>ChannelCustomer</summary>
		ChannelCustomerEntity,
		///<summary>ChannelItem</summary>
		ChannelItemEntity,
		///<summary>ChannelOwner</summary>
		ChannelOwnerEntity,
		///<summary>ChannelStore</summary>
		ChannelStoreEntity,
		///<summary>ChannelType</summary>
		ChannelTypeEntity,
		///<summary>Product</summary>
		ProductEntity,
		///<summary>RedemptionCode</summary>
		RedemptionCodeEntity,
		///<summary>Store</summary>
		StoreEntity,
		///<summary>StoreOption</summary>
		StoreOptionEntity
	}

	/// <summary>Enum definition for all the typed view types defined in this namespace. Used by the entityfields factory.</summary>
	public enum TypedViewType
	{
		///<summary>Campaign1</summary>
		Campaign1TypedView,
		///<summary>CampaignOwner1</summary>
		CampaignOwner1TypedView,
		///<summary>CampaignType1</summary>
		CampaignType1TypedView,
		///<summary>Channel1</summary>
		Channel1TypedView,
		///<summary>ChannelCustomer1</summary>
		ChannelCustomer1TypedView,
		///<summary>ChannelItem1</summary>
		ChannelItem1TypedView,
		///<summary>ChannelOwner1</summary>
		ChannelOwner1TypedView,
		///<summary>ChannelType1</summary>
		ChannelType1TypedView,
		///<summary>RedemptionCode1</summary>
		RedemptionCode1TypedView
	}

	#region Custom ConstantsEnums Code
	
	// __LLBLGENPRO_USER_CODE_REGION_START CustomUserConstants
	// __LLBLGENPRO_USER_CODE_REGION_END
	#endregion

	#region Included code

	#endregion
}

