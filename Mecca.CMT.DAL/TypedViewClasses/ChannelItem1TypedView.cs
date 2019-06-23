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
	/// <summary>Typed datatable for the view 'ChannelItem1'.</summary>
	[Serializable, System.ComponentModel.DesignerCategory("Code")]
	[ToolboxItem(true)]
	[DesignTimeVisible(true)]
	public partial class ChannelItem1TypedView : TypedViewBase<ChannelItem1Row>, ITypedView
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView 
	// __LLBLGENPRO_USER_CODE_REGION_END 
	{
		#region Class Member Declarations
		private DataColumn _columnChannelItemId;
		private DataColumn _columnChannelId;
		private DataColumn _columnProductId;
		private DataColumn _columnTesterMerchQty;
		private DataColumn _columnLiveMerchQty;
		private DataColumn _columnNumStores;
		private DataColumn _columnComments;
		private DataColumn _columnSampleQty;
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers 
	// __LLBLGENPRO_USER_CODE_REGION_END 
		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		#endregion

		#region Class Constants
		private const int AmountOfFields = 8;
		#endregion

		/// <summary>Static CTor for setting up custom property hashtables.</summary>
		static ChannelItem1TypedView()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ChannelItem1TypedView():base("ChannelItem1")
		{
			InitClass();
		}
		
		/// <summary>Protected constructor for deserialization.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ChannelItem1TypedView(SerializationInfo info, StreamingContext context):base(info, context)
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
			IEntityFields fieldsInResultset = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.ChannelItem1TypedView);
			return DAOFactory.CreateTypedListDAO().GetDbCount(fieldsInResultset, null, filter, null, groupByClause, allowDuplicates);
		}

		/// <summary>Gets the fields of this typed view</summary>
		/// <returns>IEntityFields object</returns>
		public virtual IEntityFields GetFields()
		{
			return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.ChannelItem1TypedView);
		}

		/// <summary>Creates a new typed row during the build of the datatable during a Fill session by a dataadapter.</summary>
		/// <param name="rowBuilder">supplied row builder to pass to the typed row</param>
		/// <returns>the new typed datarow</returns>
		protected override DataRow NewRowFromBuilder(DataRowBuilder rowBuilder) 
		{
			return new ChannelItem1Row(rowBuilder);
		}

		/// <summary>Initializes the hashtables for the typed view type and typed view field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Hashtable();
			_fieldsCustomProperties = new Hashtable();
			Hashtable fieldHashtable;
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("ChannelItemId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("ChannelId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("ProductId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("TesterMerchQty", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("LiveMerchQty", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("NumStores", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("Comments", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("SampleQty", fieldHashtable);
		}

		/// <summary>Initialize the datastructures.</summary>
		protected override void InitClass()
		{
			TableName = "ChannelItem1";
			_columnChannelItemId = GeneralUtils.CreateTypedDataTableColumn("ChannelItemId", @"ChannelItemId", typeof(System.Int32), this.Columns);
			_columnChannelId = GeneralUtils.CreateTypedDataTableColumn("ChannelId", @"ChannelId", typeof(System.Int32), this.Columns);
			_columnProductId = GeneralUtils.CreateTypedDataTableColumn("ProductId", @"ProductId", typeof(System.Int32), this.Columns);
			_columnTesterMerchQty = GeneralUtils.CreateTypedDataTableColumn("TesterMerchQty", @"TesterMerchQty", typeof(System.Int32), this.Columns);
			_columnLiveMerchQty = GeneralUtils.CreateTypedDataTableColumn("LiveMerchQty", @"LiveMerchQty", typeof(System.Int32), this.Columns);
			_columnNumStores = GeneralUtils.CreateTypedDataTableColumn("NumStores", @"NumStores", typeof(System.Int32), this.Columns);
			_columnComments = GeneralUtils.CreateTypedDataTableColumn("Comments", @"Comments", typeof(System.String), this.Columns);
			_columnSampleQty = GeneralUtils.CreateTypedDataTableColumn("SampleQty", @"SampleQty", typeof(System.Int32), this.Columns);
	// __LLBLGENPRO_USER_CODE_REGION_START InitClass 
	// __LLBLGENPRO_USER_CODE_REGION_END 
			OnInitialized();
		}

		/// <summary>Initializes the members, after a clone action.</summary>
		private void InitMembers()
		{
			_columnChannelItemId = this.Columns["ChannelItemId"];
			_columnChannelId = this.Columns["ChannelId"];
			_columnProductId = this.Columns["ProductId"];
			_columnTesterMerchQty = this.Columns["TesterMerchQty"];
			_columnLiveMerchQty = this.Columns["LiveMerchQty"];
			_columnNumStores = this.Columns["NumStores"];
			_columnComments = this.Columns["Comments"];
			_columnSampleQty = this.Columns["SampleQty"];
	// __LLBLGENPRO_USER_CODE_REGION_START InitMembers 
	// __LLBLGENPRO_USER_CODE_REGION_END 
		}

		/// <summary>Clones this instance.</summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			ChannelItem1TypedView cloneToReturn = ((ChannelItem1TypedView)(base.Clone()));
			cloneToReturn.InitMembers();
			return cloneToReturn;
		}

		/// <summary>Creates a new instance of the DataTable class.</summary>
		/// <returns>a new instance of a datatable with this schema.</returns>
		protected override DataTable CreateInstance() 
		{
			return new ChannelItem1TypedView();
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
			get { return ChannelItem1TypedView.CustomProperties;}
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
			get { return ChannelItem1TypedView.FieldsCustomProperties;}
		}
		
		/// <summary>Returns the column object belonging to the TypedView field 'ChannelItemId'</summary>
		internal DataColumn ChannelItemIdColumn 
		{
			get { return _columnChannelItemId; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'ChannelId'</summary>
		internal DataColumn ChannelIdColumn 
		{
			get { return _columnChannelId; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'ProductId'</summary>
		internal DataColumn ProductIdColumn 
		{
			get { return _columnProductId; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'TesterMerchQty'</summary>
		internal DataColumn TesterMerchQtyColumn 
		{
			get { return _columnTesterMerchQty; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'LiveMerchQty'</summary>
		internal DataColumn LiveMerchQtyColumn 
		{
			get { return _columnLiveMerchQty; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'NumStores'</summary>
		internal DataColumn NumStoresColumn 
		{
			get { return _columnNumStores; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'Comments'</summary>
		internal DataColumn CommentsColumn 
		{
			get { return _columnComments; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'SampleQty'</summary>
		internal DataColumn SampleQtyColumn 
		{
			get { return _columnSampleQty; }
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


	/// <summary>Typed datarow for the typed datatable ChannelItem1</summary>
	public partial class ChannelItem1Row : DataRow
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow 
	// __LLBLGENPRO_USER_CODE_REGION_END 
	{
		#region Class Member Declarations
		private ChannelItem1TypedView	_parent;
		#endregion

		/// <summary>CTor</summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		protected internal ChannelItem1Row(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((ChannelItem1TypedView)(this.Table));
		}

		#region Class Property Declarations
		/// <summary>Gets / sets the value of the TypedView field ChannelItemId</summary>
		/// <remarks>Mapped on view field: "channel_items"."channel_item_id"<br/>
		/// View field characteristics (type, precision, scale, length): Int, 10, 0, 0</remarks>
		public System.Int32 ChannelItemId
		{
			get { return IsChannelItemIdNull() ? (System.Int32)TypeDefaultValue.GetDefaultValue(typeof(System.Int32)) : (System.Int32)this[_parent.ChannelItemIdColumn]; }
			set { this[_parent.ChannelItemIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field ChannelItemId is NULL, false otherwise.</summary>
		public bool IsChannelItemIdNull() 
		{
			return IsNull(_parent.ChannelItemIdColumn);
		}

		/// <summary>Sets the TypedView field ChannelItemId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetChannelItemIdNull() 
		{
			this[_parent.ChannelItemIdColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field ChannelId</summary>
		/// <remarks>Mapped on view field: "channel_items"."channel_id"<br/>
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
		
		/// <summary>Gets / sets the value of the TypedView field ProductId</summary>
		/// <remarks>Mapped on view field: "channel_items"."product_id"<br/>
		/// View field characteristics (type, precision, scale, length): Int, 10, 0, 0</remarks>
		public System.Int32 ProductId
		{
			get { return IsProductIdNull() ? (System.Int32)TypeDefaultValue.GetDefaultValue(typeof(System.Int32)) : (System.Int32)this[_parent.ProductIdColumn]; }
			set { this[_parent.ProductIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field ProductId is NULL, false otherwise.</summary>
		public bool IsProductIdNull() 
		{
			return IsNull(_parent.ProductIdColumn);
		}

		/// <summary>Sets the TypedView field ProductId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetProductIdNull() 
		{
			this[_parent.ProductIdColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field TesterMerchQty</summary>
		/// <remarks>Mapped on view field: "channel_items"."tester_merch_qty"<br/>
		/// View field characteristics (type, precision, scale, length): Int, 10, 0, 0</remarks>
		public System.Int32 TesterMerchQty
		{
			get { return IsTesterMerchQtyNull() ? (System.Int32)TypeDefaultValue.GetDefaultValue(typeof(System.Int32)) : (System.Int32)this[_parent.TesterMerchQtyColumn]; }
			set { this[_parent.TesterMerchQtyColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field TesterMerchQty is NULL, false otherwise.</summary>
		public bool IsTesterMerchQtyNull() 
		{
			return IsNull(_parent.TesterMerchQtyColumn);
		}

		/// <summary>Sets the TypedView field TesterMerchQty to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetTesterMerchQtyNull() 
		{
			this[_parent.TesterMerchQtyColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field LiveMerchQty</summary>
		/// <remarks>Mapped on view field: "channel_items"."live_merch_qty"<br/>
		/// View field characteristics (type, precision, scale, length): Int, 10, 0, 0</remarks>
		public System.Int32 LiveMerchQty
		{
			get { return IsLiveMerchQtyNull() ? (System.Int32)TypeDefaultValue.GetDefaultValue(typeof(System.Int32)) : (System.Int32)this[_parent.LiveMerchQtyColumn]; }
			set { this[_parent.LiveMerchQtyColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field LiveMerchQty is NULL, false otherwise.</summary>
		public bool IsLiveMerchQtyNull() 
		{
			return IsNull(_parent.LiveMerchQtyColumn);
		}

		/// <summary>Sets the TypedView field LiveMerchQty to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetLiveMerchQtyNull() 
		{
			this[_parent.LiveMerchQtyColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field NumStores</summary>
		/// <remarks>Mapped on view field: "channel_items"."num_stores"<br/>
		/// View field characteristics (type, precision, scale, length): Int, 10, 0, 0</remarks>
		public System.Int32 NumStores
		{
			get { return IsNumStoresNull() ? (System.Int32)TypeDefaultValue.GetDefaultValue(typeof(System.Int32)) : (System.Int32)this[_parent.NumStoresColumn]; }
			set { this[_parent.NumStoresColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field NumStores is NULL, false otherwise.</summary>
		public bool IsNumStoresNull() 
		{
			return IsNull(_parent.NumStoresColumn);
		}

		/// <summary>Sets the TypedView field NumStores to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetNumStoresNull() 
		{
			this[_parent.NumStoresColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field Comments</summary>
		/// <remarks>Mapped on view field: "channel_items"."comments"<br/>
		/// View field characteristics (type, precision, scale, length): VarChar, 0, 0, 500</remarks>
		public System.String Comments
		{
			get { return IsCommentsNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.CommentsColumn]; }
			set { this[_parent.CommentsColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field Comments is NULL, false otherwise.</summary>
		public bool IsCommentsNull() 
		{
			return IsNull(_parent.CommentsColumn);
		}

		/// <summary>Sets the TypedView field Comments to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetCommentsNull() 
		{
			this[_parent.CommentsColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field SampleQty</summary>
		/// <remarks>Mapped on view field: "channel_items"."sample_qty"<br/>
		/// View field characteristics (type, precision, scale, length): Int, 10, 0, 0</remarks>
		public System.Int32 SampleQty
		{
			get { return IsSampleQtyNull() ? (System.Int32)TypeDefaultValue.GetDefaultValue(typeof(System.Int32)) : (System.Int32)this[_parent.SampleQtyColumn]; }
			set { this[_parent.SampleQtyColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field SampleQty is NULL, false otherwise.</summary>
		public bool IsSampleQtyNull() 
		{
			return IsNull(_parent.SampleQtyColumn);
		}

		/// <summary>Sets the TypedView field SampleQty to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetSampleQtyNull() 
		{
			this[_parent.SampleQtyColumn] = System.Convert.DBNull;
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
