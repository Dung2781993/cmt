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
	/// <summary>Typed datatable for the view 'ChannelOwner1'.</summary>
	[Serializable, System.ComponentModel.DesignerCategory("Code")]
	[ToolboxItem(true)]
	[DesignTimeVisible(true)]
	public partial class ChannelOwner1TypedView : TypedViewBase<ChannelOwner1Row>, ITypedView
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView 
	// __LLBLGENPRO_USER_CODE_REGION_END 
	{
		#region Class Member Declarations
		private DataColumn _columnChannelOwnerId;
		private DataColumn _columnCampaignId;
		private DataColumn _columnChannelId;
		private DataColumn _columnOwner;
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers 
	// __LLBLGENPRO_USER_CODE_REGION_END 
		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		#endregion

		#region Class Constants
		private const int AmountOfFields = 4;
		#endregion

		/// <summary>Static CTor for setting up custom property hashtables.</summary>
		static ChannelOwner1TypedView()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ChannelOwner1TypedView():base("ChannelOwner1")
		{
			InitClass();
		}
		
		/// <summary>Protected constructor for deserialization.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ChannelOwner1TypedView(SerializationInfo info, StreamingContext context):base(info, context)
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
			IEntityFields fieldsInResultset = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.ChannelOwner1TypedView);
			return DAOFactory.CreateTypedListDAO().GetDbCount(fieldsInResultset, null, filter, null, groupByClause, allowDuplicates);
		}

		/// <summary>Gets the fields of this typed view</summary>
		/// <returns>IEntityFields object</returns>
		public virtual IEntityFields GetFields()
		{
			return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.ChannelOwner1TypedView);
		}

		/// <summary>Creates a new typed row during the build of the datatable during a Fill session by a dataadapter.</summary>
		/// <param name="rowBuilder">supplied row builder to pass to the typed row</param>
		/// <returns>the new typed datarow</returns>
		protected override DataRow NewRowFromBuilder(DataRowBuilder rowBuilder) 
		{
			return new ChannelOwner1Row(rowBuilder);
		}

		/// <summary>Initializes the hashtables for the typed view type and typed view field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Hashtable();
			_fieldsCustomProperties = new Hashtable();
			Hashtable fieldHashtable;
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("ChannelOwnerId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("CampaignId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("ChannelId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("Owner", fieldHashtable);
		}

		/// <summary>Initialize the datastructures.</summary>
		protected override void InitClass()
		{
			TableName = "ChannelOwner1";
			_columnChannelOwnerId = GeneralUtils.CreateTypedDataTableColumn("ChannelOwnerId", @"ChannelOwnerId", typeof(System.Int32), this.Columns);
			_columnCampaignId = GeneralUtils.CreateTypedDataTableColumn("CampaignId", @"CampaignId", typeof(System.Int32), this.Columns);
			_columnChannelId = GeneralUtils.CreateTypedDataTableColumn("ChannelId", @"ChannelId", typeof(System.Int32), this.Columns);
			_columnOwner = GeneralUtils.CreateTypedDataTableColumn("Owner", @"Owner", typeof(System.String), this.Columns);
	// __LLBLGENPRO_USER_CODE_REGION_START InitClass 
	// __LLBLGENPRO_USER_CODE_REGION_END 
			OnInitialized();
		}

		/// <summary>Initializes the members, after a clone action.</summary>
		private void InitMembers()
		{
			_columnChannelOwnerId = this.Columns["ChannelOwnerId"];
			_columnCampaignId = this.Columns["CampaignId"];
			_columnChannelId = this.Columns["ChannelId"];
			_columnOwner = this.Columns["Owner"];
	// __LLBLGENPRO_USER_CODE_REGION_START InitMembers 
	// __LLBLGENPRO_USER_CODE_REGION_END 
		}

		/// <summary>Clones this instance.</summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			ChannelOwner1TypedView cloneToReturn = ((ChannelOwner1TypedView)(base.Clone()));
			cloneToReturn.InitMembers();
			return cloneToReturn;
		}

		/// <summary>Creates a new instance of the DataTable class.</summary>
		/// <returns>a new instance of a datatable with this schema.</returns>
		protected override DataTable CreateInstance() 
		{
			return new ChannelOwner1TypedView();
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
			get { return ChannelOwner1TypedView.CustomProperties;}
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
			get { return ChannelOwner1TypedView.FieldsCustomProperties;}
		}
		
		/// <summary>Returns the column object belonging to the TypedView field 'ChannelOwnerId'</summary>
		internal DataColumn ChannelOwnerIdColumn 
		{
			get { return _columnChannelOwnerId; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'CampaignId'</summary>
		internal DataColumn CampaignIdColumn 
		{
			get { return _columnCampaignId; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'ChannelId'</summary>
		internal DataColumn ChannelIdColumn 
		{
			get { return _columnChannelId; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'Owner'</summary>
		internal DataColumn OwnerColumn 
		{
			get { return _columnOwner; }
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


	/// <summary>Typed datarow for the typed datatable ChannelOwner1</summary>
	public partial class ChannelOwner1Row : DataRow
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow 
	// __LLBLGENPRO_USER_CODE_REGION_END 
	{
		#region Class Member Declarations
		private ChannelOwner1TypedView	_parent;
		#endregion

		/// <summary>CTor</summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		protected internal ChannelOwner1Row(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((ChannelOwner1TypedView)(this.Table));
		}

		#region Class Property Declarations
		/// <summary>Gets / sets the value of the TypedView field ChannelOwnerId</summary>
		/// <remarks>Mapped on view field: "channel_owners"."channel_owner_id"<br/>
		/// View field characteristics (type, precision, scale, length): Int, 10, 0, 0</remarks>
		public System.Int32 ChannelOwnerId
		{
			get { return IsChannelOwnerIdNull() ? (System.Int32)TypeDefaultValue.GetDefaultValue(typeof(System.Int32)) : (System.Int32)this[_parent.ChannelOwnerIdColumn]; }
			set { this[_parent.ChannelOwnerIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field ChannelOwnerId is NULL, false otherwise.</summary>
		public bool IsChannelOwnerIdNull() 
		{
			return IsNull(_parent.ChannelOwnerIdColumn);
		}

		/// <summary>Sets the TypedView field ChannelOwnerId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetChannelOwnerIdNull() 
		{
			this[_parent.ChannelOwnerIdColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field CampaignId</summary>
		/// <remarks>Mapped on view field: "channel_owners"."campaign_id"<br/>
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
		
		/// <summary>Gets / sets the value of the TypedView field ChannelId</summary>
		/// <remarks>Mapped on view field: "channel_owners"."channel_id"<br/>
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
		
		/// <summary>Gets / sets the value of the TypedView field Owner</summary>
		/// <remarks>Mapped on view field: "channel_owners"."owner"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 200</remarks>
		public System.String Owner
		{
			get { return IsOwnerNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.OwnerColumn]; }
			set { this[_parent.OwnerColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field Owner is NULL, false otherwise.</summary>
		public bool IsOwnerNull() 
		{
			return IsNull(_parent.OwnerColumn);
		}

		/// <summary>Sets the TypedView field Owner to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetOwnerNull() 
		{
			this[_parent.OwnerColumn] = System.Convert.DBNull;
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
