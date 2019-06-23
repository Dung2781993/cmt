///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Data;
using System.Collections;
using System.Runtime.Serialization;
using Mecca.CMT.DAL;
using Mecca.CMT.DAL.HelperClasses;
using Mecca.CMT.DAL.DaoClasses;
using Mecca.CMT.DAL.EntityClasses;
using Mecca.CMT.DAL.FactoryClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Mecca.CMT.DAL.TypedViewClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces 
	// __LLBLGENPRO_USER_CODE_REGION_END 
	/// <summary>Typed datatable for the view 'Channel1'.</summary>
	[Serializable, System.ComponentModel.DesignerCategory("Code")]
	[ToolboxItem(true)]
	[DesignTimeVisible(true)]
	public partial class Channel1TypedView : TypedViewBase<Channel1Row>, ITypedView
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView 
	// __LLBLGENPRO_USER_CODE_REGION_END 
	{
		#region Class Member Declarations
		private DataColumn _columnChannelId;
		private DataColumn _columnCampaignId;
		private DataColumn _columnChannelName;
		private DataColumn _columnChannelTypeId;
		private DataColumn _columnDescription;
		private DataColumn _columnStartDate;
		private DataColumn _columnEndDate;
		private DataColumn _columnChannelCode;
		private DataColumn _columnRedemptionCodeId;
		private DataColumn _columnIsLocked;
		private DataColumn _columnCreatedBy;
		private DataColumn _columnStoreOptionId;
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers 
	// __LLBLGENPRO_USER_CODE_REGION_END 
		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		#endregion

		#region Class Constants
		private const int AmountOfFields = 12;
		#endregion

		/// <summary>Static CTor for setting up custom property hashtables.</summary>
		static Channel1TypedView()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public Channel1TypedView():base("Channel1")
		{
			InitClass();
		}
		
		/// <summary>Protected constructor for deserialization.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected Channel1TypedView(SerializationInfo info, StreamingContext context):base(info, context)
		{
			InitMembers();
		}

		/// <summary> Fills itself with data. it builds a dynamic query and loads itself with that query. 
		/// Will use no sort filter, no select filter, will allow duplicate rows and will not limit the amount of rows returned</summary>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public bool Fill()
		{
			return Fill(0, null, true, null, null, null, 0, 0);
		}

		/// <summary>Fills itself with data. it builds a dynamic query and loads itself with that query. Will not use a filter, will allow duplicate rows.</summary>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. specifying 0 means all rows are returned</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public bool Fill(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return Fill(maxNumberOfItemsToReturn, sortClauses, true, null, null, null, 0, 0);
		}

		/// <summary>Fills itself with data. it builds a dynamic query and loads itself with that query. Will not use a filter.</summary>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. specifying 0 means all rows are returned</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public bool Fill(long maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates)
		{
			return Fill(maxNumberOfItemsToReturn, sortClauses, allowDuplicates, null, null, null, 0, 0);
		}

		/// <summary>Fills itself with data. it builds a dynamic query and loads itself with that query, using the specified filter</summary>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. specifying 0 means all rows are returned</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <param name="selectFilter">Predicate expression to filter on the rows inserted in this TypedView object.</param>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public bool Fill(long maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates, IPredicate selectFilter)
		{
			return Fill(maxNumberOfItemsToReturn, sortClauses, allowDuplicates, selectFilter, null, null, 0, 0);
		}

		/// <summary>Fills itself with data. it builds a dynamic query and loads itself with that query, using the specified filter</summary>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. specifying 0 means all rows are returned</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <param name="selectFilter">Predicate expression to filter on the rows inserted in this TypedView object.</param>
		/// <param name="transactionToUse">The transaction object to use. Can be null. If specified, the connection object of the transaction is
		/// used to fill the TypedView, which avoids deadlocks on SqlServer.</param>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public bool Fill(long maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates, IPredicate selectFilter, ITransaction transactionToUse)
		{
			return Fill(maxNumberOfItemsToReturn, sortClauses, allowDuplicates, selectFilter, transactionToUse, null, 0, 0);
		}

		/// <summary>Fills itself with data. it builds a dynamic query and loads itself with that query, using the specified filter</summary>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. specifying 0 means all rows are returned</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <param name="selectFilter">Predicate expression to filter on the rows inserted in this TypedView object.</param>
		/// <param name="transactionToUse">The transaction object to use. Can be null. If specified, the connection object of the transaction is
		/// used to fill the TypedView, which avoids deadlocks on SqlServer.</param>
		/// <param name="groupByClause">GroupByCollection with fields to group by on.</param>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public bool Fill(long maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates, IPredicate selectFilter, ITransaction transactionToUse, 	IGroupByCollection groupByClause)
		{
			return Fill(maxNumberOfItemsToReturn, sortClauses, allowDuplicates, selectFilter, transactionToUse, groupByClause, 0, 0);
		}

		/// <summary>Fills itself with data. it builds a dynamic query and loads itself with that query, using the specified filter</summary>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. specifying 0 means all rows are returned</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <param name="selectFilter">Predicate expression to filter on the rows inserted in this TypedView object.</param>
		/// <param name="transactionToUse">The transaction object to use. Can be null. If specified, the connection object of the transaction is used to fill the TypedView, which avoids deadlocks on SqlServer.</param>
		/// <param name="groupByClause">GroupByCollection with fields to group by on.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public virtual bool Fill(long maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates, IPredicate selectFilter, ITransaction transactionToUse, 
								 IGroupByCollection groupByClause, int pageNumber, int pageSize)
		{
			IEntityFields fieldsInResultset = GetFields();
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalFields 
	// __LLBLGENPRO_USER_CODE_REGION_END 
			return DAOFactory.CreateTypedListDAO().GetMultiAsDataTable(fieldsInResultset, this, maxNumberOfItemsToReturn, sortClauses, selectFilter, null, allowDuplicates, groupByClause, transactionToUse, pageNumber, pageSize);
		}

		/// <summary>Gets the amount of rows in the database for this typed view, not skipping duplicates</summary>
		/// <returns>the number of rows in the set defined by the passed in query elements</returns>
		public int GetDbCount()
		{
			return GetDbCount(true, null);
		}
		
		/// <summary>Gets the amount of rows in the database for this typed view.</summary>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <returns>the number of rows in the set defined by the passed in query elements</returns>
		public int GetDbCount(bool allowDuplicates)
		{
			return GetDbCount(allowDuplicates, null);
		}
		
		/// <summary>Gets the amount of rows in the database for this typed view.</summary>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <param name="filter">The filter to apply for the count retrieval</param>
		/// <returns>the number of rows in the set defined by the passed in query elements</returns>
		public int GetDbCount(bool allowDuplicates, IPredicateExpression filter)
		{
			return GetDbCount(allowDuplicates, filter, null);
		}

		/// <summary>Gets the amount of rows in the database for this typed view.</summary>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <param name="filter">The filter to apply for the count retrieval</param>
		/// <param name="groupByClause">group by clause to embed in the query</param>
		/// <returns>the number of rows in the set defined by the passed in query elements</returns>
		public virtual int GetDbCount(bool allowDuplicates, IPredicateExpression filter, GroupByCollection groupByClause)
		{
			IEntityFields fieldsInResultset = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.Channel1TypedView);
			return DAOFactory.CreateTypedListDAO().GetDbCount(fieldsInResultset, null, filter, null, groupByClause, allowDuplicates);
		}

		/// <summary>Gets the fields of this typed view</summary>
		/// <returns>IEntityFields object</returns>
		public virtual IEntityFields GetFields()
		{
			return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.Channel1TypedView);
		}

		/// <summary>Creates a new typed row during the build of the datatable during a Fill session by a dataadapter.</summary>
		/// <param name="rowBuilder">supplied row builder to pass to the typed row</param>
		/// <returns>the new typed datarow</returns>
		protected override DataRow NewRowFromBuilder(DataRowBuilder rowBuilder) 
		{
			return new Channel1Row(rowBuilder);
		}

		/// <summary>Initializes the hashtables for the typed view type and typed view field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Hashtable();
			_fieldsCustomProperties = new Hashtable();
			Hashtable fieldHashtable;
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("ChannelId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("CampaignId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("ChannelName", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("ChannelTypeId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("Description", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("StartDate", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("EndDate", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("ChannelCode", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("RedemptionCodeId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("IsLocked", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("CreatedBy", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("StoreOptionId", fieldHashtable);
		}

		/// <summary>Initialize the datastructures.</summary>
		protected override void InitClass()
		{
			TableName = "Channel1";
			_columnChannelId = GeneralUtils.CreateTypedDataTableColumn("ChannelId", @"ChannelId", typeof(System.Int32), this.Columns);
			_columnCampaignId = GeneralUtils.CreateTypedDataTableColumn("CampaignId", @"CampaignId", typeof(System.Int32), this.Columns);
			_columnChannelName = GeneralUtils.CreateTypedDataTableColumn("ChannelName", @"ChannelName", typeof(System.String), this.Columns);
			_columnChannelTypeId = GeneralUtils.CreateTypedDataTableColumn("ChannelTypeId", @"ChannelTypeId", typeof(System.Int32), this.Columns);
			_columnDescription = GeneralUtils.CreateTypedDataTableColumn("Description", @"Description", typeof(System.String), this.Columns);
			_columnStartDate = GeneralUtils.CreateTypedDataTableColumn("StartDate", @"StartDate", typeof(System.DateTime), this.Columns);
			_columnEndDate = GeneralUtils.CreateTypedDataTableColumn("EndDate", @"EndDate", typeof(System.DateTime), this.Columns);
			_columnChannelCode = GeneralUtils.CreateTypedDataTableColumn("ChannelCode", @"ChannelCode", typeof(System.String), this.Columns);
			_columnRedemptionCodeId = GeneralUtils.CreateTypedDataTableColumn("RedemptionCodeId", @"RedemptionCodeId", typeof(System.Int32), this.Columns);
			_columnIsLocked = GeneralUtils.CreateTypedDataTableColumn("IsLocked", @"IsLocked", typeof(System.Int32), this.Columns);
			_columnCreatedBy = GeneralUtils.CreateTypedDataTableColumn("CreatedBy", @"CreatedBy", typeof(System.String), this.Columns);
			_columnStoreOptionId = GeneralUtils.CreateTypedDataTableColumn("StoreOptionId", @"StoreOptionId", typeof(System.Int32), this.Columns);
	// __LLBLGENPRO_USER_CODE_REGION_START InitClass 
	// __LLBLGENPRO_USER_CODE_REGION_END 
			OnInitialized();
		}

		/// <summary>Initializes the members, after a clone action.</summary>
		private void InitMembers()
		{
			_columnChannelId = this.Columns["ChannelId"];
			_columnCampaignId = this.Columns["CampaignId"];
			_columnChannelName = this.Columns["ChannelName"];
			_columnChannelTypeId = this.Columns["ChannelTypeId"];
			_columnDescription = this.Columns["Description"];
			_columnStartDate = this.Columns["StartDate"];
			_columnEndDate = this.Columns["EndDate"];
			_columnChannelCode = this.Columns["ChannelCode"];
			_columnRedemptionCodeId = this.Columns["RedemptionCodeId"];
			_columnIsLocked = this.Columns["IsLocked"];
			_columnCreatedBy = this.Columns["CreatedBy"];
			_columnStoreOptionId = this.Columns["StoreOptionId"];
	// __LLBLGENPRO_USER_CODE_REGION_START InitMembers 
	// __LLBLGENPRO_USER_CODE_REGION_END 
		}

		/// <summary>Clones this instance.</summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			Channel1TypedView cloneToReturn = ((Channel1TypedView)(base.Clone()));
			cloneToReturn.InitMembers();
			return cloneToReturn;
		}

		/// <summary>Creates a new instance of the DataTable class.</summary>
		/// <returns>a new instance of a datatable with this schema.</returns>
		protected override DataTable CreateInstance() 
		{
			return new Channel1TypedView();
		}

		#region Class Property Declarations
		/// <summary>The custom properties for this TypedView type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public static Hashtable CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary>The custom properties for the type of this TypedView instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[System.ComponentModel.Browsable(false)]
		public virtual Hashtable CustomPropertiesOfType
		{
			get { return Channel1TypedView.CustomProperties;}
		}

		/// <summary>The custom properties for the fields of this TypedView type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public static Hashtable FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary>The custom properties for the fields of the type of this TypedView instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[System.ComponentModel.Browsable(false)]
		public virtual Hashtable FieldsCustomPropertiesOfType
		{
			get { return Channel1TypedView.FieldsCustomProperties;}
		}
		
		/// <summary>Returns the column object belonging to the TypedView field 'ChannelId'</summary>
		internal DataColumn ChannelIdColumn 
		{
			get { return _columnChannelId; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'CampaignId'</summary>
		internal DataColumn CampaignIdColumn 
		{
			get { return _columnCampaignId; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'ChannelName'</summary>
		internal DataColumn ChannelNameColumn 
		{
			get { return _columnChannelName; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'ChannelTypeId'</summary>
		internal DataColumn ChannelTypeIdColumn 
		{
			get { return _columnChannelTypeId; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'Description'</summary>
		internal DataColumn DescriptionColumn 
		{
			get { return _columnDescription; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'StartDate'</summary>
		internal DataColumn StartDateColumn 
		{
			get { return _columnStartDate; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'EndDate'</summary>
		internal DataColumn EndDateColumn 
		{
			get { return _columnEndDate; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'ChannelCode'</summary>
		internal DataColumn ChannelCodeColumn 
		{
			get { return _columnChannelCode; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'RedemptionCodeId'</summary>
		internal DataColumn RedemptionCodeIdColumn 
		{
			get { return _columnRedemptionCodeId; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'IsLocked'</summary>
		internal DataColumn IsLockedColumn 
		{
			get { return _columnIsLocked; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'CreatedBy'</summary>
		internal DataColumn CreatedByColumn 
		{
			get { return _columnCreatedBy; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'StoreOptionId'</summary>
		internal DataColumn StoreOptionIdColumn 
		{
			get { return _columnStoreOptionId; }
		}
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalColumnProperties 
	// __LLBLGENPRO_USER_CODE_REGION_END 
		#endregion
		
		#region Custom Typed View code
	// __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewCode 
	// __LLBLGENPRO_USER_CODE_REGION_END 
		#endregion

		#region Included Code

		#endregion
	}


	/// <summary>Typed datarow for the typed datatable Channel1</summary>
	public partial class Channel1Row : DataRow
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow 
	// __LLBLGENPRO_USER_CODE_REGION_END 
	{
		#region Class Member Declarations
		private Channel1TypedView	_parent;
		#endregion

		/// <summary>CTor</summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		protected internal Channel1Row(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((Channel1TypedView)(this.Table));
		}

		#region Class Property Declarations
		/// <summary>Gets / sets the value of the TypedView field ChannelId</summary>
		/// <remarks>Mapped on view field: "channels"."channel_id"<br/>
		/// View field characteristics (type, precision, scale, length): Int, 10, 0, 0</remarks>
		public System.Int32 ChannelId
		{
			get { return IsChannelIdNull() ? (System.Int32)TypeDefaultValue.GetDefaultValue(typeof(System.Int32)) : (System.Int32)this[_parent.ChannelIdColumn]; }
			set { this[_parent.ChannelIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field ChannelId is NULL, false otherwise.</summary>
		public bool IsChannelIdNull() 
		{
			return IsNull(_parent.ChannelIdColumn);
		}

		/// <summary>Sets the TypedView field ChannelId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetChannelIdNull() 
		{
			this[_parent.ChannelIdColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field CampaignId</summary>
		/// <remarks>Mapped on view field: "channels"."campaign_id"<br/>
		/// View field characteristics (type, precision, scale, length): Int, 10, 0, 0</remarks>
		public System.Int32 CampaignId
		{
			get { return IsCampaignIdNull() ? (System.Int32)TypeDefaultValue.GetDefaultValue(typeof(System.Int32)) : (System.Int32)this[_parent.CampaignIdColumn]; }
			set { this[_parent.CampaignIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field CampaignId is NULL, false otherwise.</summary>
		public bool IsCampaignIdNull() 
		{
			return IsNull(_parent.CampaignIdColumn);
		}

		/// <summary>Sets the TypedView field CampaignId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetCampaignIdNull() 
		{
			this[_parent.CampaignIdColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field ChannelName</summary>
		/// <remarks>Mapped on view field: "channels"."channel_name"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 250</remarks>
		public System.String ChannelName
		{
			get { return IsChannelNameNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.ChannelNameColumn]; }
			set { this[_parent.ChannelNameColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field ChannelName is NULL, false otherwise.</summary>
		public bool IsChannelNameNull() 
		{
			return IsNull(_parent.ChannelNameColumn);
		}

		/// <summary>Sets the TypedView field ChannelName to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetChannelNameNull() 
		{
			this[_parent.ChannelNameColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field ChannelTypeId</summary>
		/// <remarks>Mapped on view field: "channels"."channel_type_id"<br/>
		/// View field characteristics (type, precision, scale, length): Int, 10, 0, 0</remarks>
		public System.Int32 ChannelTypeId
		{
			get { return IsChannelTypeIdNull() ? (System.Int32)TypeDefaultValue.GetDefaultValue(typeof(System.Int32)) : (System.Int32)this[_parent.ChannelTypeIdColumn]; }
			set { this[_parent.ChannelTypeIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field ChannelTypeId is NULL, false otherwise.</summary>
		public bool IsChannelTypeIdNull() 
		{
			return IsNull(_parent.ChannelTypeIdColumn);
		}

		/// <summary>Sets the TypedView field ChannelTypeId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetChannelTypeIdNull() 
		{
			this[_parent.ChannelTypeIdColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field Description</summary>
		/// <remarks>Mapped on view field: "channels"."description"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 250</remarks>
		public System.String Description
		{
			get { return IsDescriptionNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.DescriptionColumn]; }
			set { this[_parent.DescriptionColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field Description is NULL, false otherwise.</summary>
		public bool IsDescriptionNull() 
		{
			return IsNull(_parent.DescriptionColumn);
		}

		/// <summary>Sets the TypedView field Description to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetDescriptionNull() 
		{
			this[_parent.DescriptionColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field StartDate</summary>
		/// <remarks>Mapped on view field: "channels"."start_date"<br/>
		/// View field characteristics (type, precision, scale, length): Date, 0, 0, 0</remarks>
		public System.DateTime StartDate
		{
			get { return IsStartDateNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.StartDateColumn]; }
			set { this[_parent.StartDateColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field StartDate is NULL, false otherwise.</summary>
		public bool IsStartDateNull() 
		{
			return IsNull(_parent.StartDateColumn);
		}

		/// <summary>Sets the TypedView field StartDate to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetStartDateNull() 
		{
			this[_parent.StartDateColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field EndDate</summary>
		/// <remarks>Mapped on view field: "channels"."end_date"<br/>
		/// View field characteristics (type, precision, scale, length): Date, 0, 0, 0</remarks>
		public System.DateTime EndDate
		{
			get { return IsEndDateNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.EndDateColumn]; }
			set { this[_parent.EndDateColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field EndDate is NULL, false otherwise.</summary>
		public bool IsEndDateNull() 
		{
			return IsNull(_parent.EndDateColumn);
		}

		/// <summary>Sets the TypedView field EndDate to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetEndDateNull() 
		{
			this[_parent.EndDateColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field ChannelCode</summary>
		/// <remarks>Mapped on view field: "channels"."channel_code"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 10</remarks>
		public System.String ChannelCode
		{
			get { return IsChannelCodeNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.ChannelCodeColumn]; }
			set { this[_parent.ChannelCodeColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field ChannelCode is NULL, false otherwise.</summary>
		public bool IsChannelCodeNull() 
		{
			return IsNull(_parent.ChannelCodeColumn);
		}

		/// <summary>Sets the TypedView field ChannelCode to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetChannelCodeNull() 
		{
			this[_parent.ChannelCodeColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field RedemptionCodeId</summary>
		/// <remarks>Mapped on view field: "channels"."redemption_code_id"<br/>
		/// View field characteristics (type, precision, scale, length): Int, 10, 0, 0</remarks>
		public System.Int32 RedemptionCodeId
		{
			get { return IsRedemptionCodeIdNull() ? (System.Int32)TypeDefaultValue.GetDefaultValue(typeof(System.Int32)) : (System.Int32)this[_parent.RedemptionCodeIdColumn]; }
			set { this[_parent.RedemptionCodeIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field RedemptionCodeId is NULL, false otherwise.</summary>
		public bool IsRedemptionCodeIdNull() 
		{
			return IsNull(_parent.RedemptionCodeIdColumn);
		}

		/// <summary>Sets the TypedView field RedemptionCodeId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetRedemptionCodeIdNull() 
		{
			this[_parent.RedemptionCodeIdColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field IsLocked</summary>
		/// <remarks>Mapped on view field: "channels"."is_locked"<br/>
		/// View field characteristics (type, precision, scale, length): Int, 10, 0, 0</remarks>
		public System.Int32 IsLocked
		{
			get { return IsIsLockedNull() ? (System.Int32)TypeDefaultValue.GetDefaultValue(typeof(System.Int32)) : (System.Int32)this[_parent.IsLockedColumn]; }
			set { this[_parent.IsLockedColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field IsLocked is NULL, false otherwise.</summary>
		public bool IsIsLockedNull() 
		{
			return IsNull(_parent.IsLockedColumn);
		}

		/// <summary>Sets the TypedView field IsLocked to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetIsLockedNull() 
		{
			this[_parent.IsLockedColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field CreatedBy</summary>
		/// <remarks>Mapped on view field: "channels"."created_by"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 200</remarks>
		public System.String CreatedBy
		{
			get { return IsCreatedByNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.CreatedByColumn]; }
			set { this[_parent.CreatedByColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field CreatedBy is NULL, false otherwise.</summary>
		public bool IsCreatedByNull() 
		{
			return IsNull(_parent.CreatedByColumn);
		}

		/// <summary>Sets the TypedView field CreatedBy to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetCreatedByNull() 
		{
			this[_parent.CreatedByColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field StoreOptionId</summary>
		/// <remarks>Mapped on view field: "channels"."store_option_id"<br/>
		/// View field characteristics (type, precision, scale, length): Int, 10, 0, 0</remarks>
		public System.Int32 StoreOptionId
		{
			get { return IsStoreOptionIdNull() ? (System.Int32)TypeDefaultValue.GetDefaultValue(typeof(System.Int32)) : (System.Int32)this[_parent.StoreOptionIdColumn]; }
			set { this[_parent.StoreOptionIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field StoreOptionId is NULL, false otherwise.</summary>
		public bool IsStoreOptionIdNull() 
		{
			return IsNull(_parent.StoreOptionIdColumn);
		}

		/// <summary>Sets the TypedView field StoreOptionId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetStoreOptionIdNull() 
		{
			this[_parent.StoreOptionIdColumn] = System.Convert.DBNull;
		}
		
		#endregion
		
		#region Custom Typed View Row Code
	// __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode 
	// __LLBLGENPRO_USER_CODE_REGION_END 
		#endregion
		
		#region Included Row Code

		#endregion		
	}
}
