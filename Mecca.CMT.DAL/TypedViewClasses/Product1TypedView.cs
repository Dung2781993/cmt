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
	/// <summary>Typed datatable for the view 'Product1'.</summary>
	[Serializable, System.ComponentModel.DesignerCategory("Code")]
	[ToolboxItem(true)]
	[DesignTimeVisible(true)]
	public partial class Product1TypedView : TypedViewBase<Product1Row>, ITypedView
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView 
	// __LLBLGENPRO_USER_CODE_REGION_END 
	{
		#region Class Member Declarations
		private DataColumn _columnProductId;
		private DataColumn _columnItemCode;
		private DataColumn _columnDescription;
		private DataColumn _columnVendorCode;
		private DataColumn _columnDepartmentName;
		private DataColumn _columnCategoryName;
		private DataColumn _columnLifestage;
		private DataColumn _columnLimitedEdition;
		private DataColumn _columnUnitPrice;
		private DataColumn _columnNzUnitPrice;
		private DataColumn _columnLaunchDate;
		private DataColumn _columnRangingCodeMecca;
		private DataColumn _columnRangingCodeKit;
		private DataColumn _columnRangingCodeImo;
		private DataColumn _columnRangingCodeMaxima;
		private DataColumn _columnCompanySoh;
		private DataColumn _columnTransitionItemCode;
		private DataColumn _columnNoTester;
		private DataColumn _columnStockOnOrder;
		private DataColumn _columnExpectedReceiptDate;
		private DataColumn _columnTravelSize;
		private DataColumn _columnTerminationDate;
		private DataColumn _columnItemSid;
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers 
	// __LLBLGENPRO_USER_CODE_REGION_END 
		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		#endregion

		#region Class Constants
		private const int AmountOfFields = 23;
		#endregion

		/// <summary>Static CTor for setting up custom property hashtables.</summary>
		static Product1TypedView()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public Product1TypedView():base("Product1")
		{
			InitClass();
		}
		
		/// <summary>Protected constructor for deserialization.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected Product1TypedView(SerializationInfo info, StreamingContext context):base(info, context)
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
			IEntityFields fieldsInResultset = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.Product1TypedView);
			return DAOFactory.CreateTypedListDAO().GetDbCount(fieldsInResultset, null, filter, null, groupByClause, allowDuplicates);
		}

		/// <summary>Gets the fields of this typed view</summary>
		/// <returns>IEntityFields object</returns>
		public virtual IEntityFields GetFields()
		{
			return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.Product1TypedView);
		}

		/// <summary>Creates a new typed row during the build of the datatable during a Fill session by a dataadapter.</summary>
		/// <param name="rowBuilder">supplied row builder to pass to the typed row</param>
		/// <returns>the new typed datarow</returns>
		protected override DataRow NewRowFromBuilder(DataRowBuilder rowBuilder) 
		{
			return new Product1Row(rowBuilder);
		}

		/// <summary>Initializes the hashtables for the typed view type and typed view field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Hashtable();
			_fieldsCustomProperties = new Hashtable();
			Hashtable fieldHashtable;
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("ProductId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("ItemCode", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("Description", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("VendorCode", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("DepartmentName", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("CategoryName", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("Lifestage", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("LimitedEdition", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("UnitPrice", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("NzUnitPrice", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("LaunchDate", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("RangingCodeMecca", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("RangingCodeKit", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("RangingCodeImo", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("RangingCodeMaxima", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("CompanySoh", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("TransitionItemCode", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("NoTester", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("StockOnOrder", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("ExpectedReceiptDate", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("TravelSize", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("TerminationDate", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("ItemSid", fieldHashtable);
		}

		/// <summary>Initialize the datastructures.</summary>
		protected override void InitClass()
		{
			TableName = "Product1";
			_columnProductId = GeneralUtils.CreateTypedDataTableColumn("ProductId", @"ProductId", typeof(System.Int32), this.Columns);
			_columnItemCode = GeneralUtils.CreateTypedDataTableColumn("ItemCode", @"ItemCode", typeof(System.String), this.Columns);
			_columnDescription = GeneralUtils.CreateTypedDataTableColumn("Description", @"Description", typeof(System.String), this.Columns);
			_columnVendorCode = GeneralUtils.CreateTypedDataTableColumn("VendorCode", @"VendorCode", typeof(System.String), this.Columns);
			_columnDepartmentName = GeneralUtils.CreateTypedDataTableColumn("DepartmentName", @"DepartmentName", typeof(System.String), this.Columns);
			_columnCategoryName = GeneralUtils.CreateTypedDataTableColumn("CategoryName", @"CategoryName", typeof(System.String), this.Columns);
			_columnLifestage = GeneralUtils.CreateTypedDataTableColumn("Lifestage", @"Lifestage", typeof(System.String), this.Columns);
			_columnLimitedEdition = GeneralUtils.CreateTypedDataTableColumn("LimitedEdition", @"LimitedEdition", typeof(System.String), this.Columns);
			_columnUnitPrice = GeneralUtils.CreateTypedDataTableColumn("UnitPrice", @"UnitPrice", typeof(System.Decimal), this.Columns);
			_columnNzUnitPrice = GeneralUtils.CreateTypedDataTableColumn("NzUnitPrice", @"NzUnitPrice", typeof(System.Decimal), this.Columns);
			_columnLaunchDate = GeneralUtils.CreateTypedDataTableColumn("LaunchDate", @"LaunchDate", typeof(System.DateTime), this.Columns);
			_columnRangingCodeMecca = GeneralUtils.CreateTypedDataTableColumn("RangingCodeMecca", @"RangingCodeMecca", typeof(System.String), this.Columns);
			_columnRangingCodeKit = GeneralUtils.CreateTypedDataTableColumn("RangingCodeKit", @"RangingCodeKit", typeof(System.String), this.Columns);
			_columnRangingCodeImo = GeneralUtils.CreateTypedDataTableColumn("RangingCodeImo", @"RangingCodeImo", typeof(System.String), this.Columns);
			_columnRangingCodeMaxima = GeneralUtils.CreateTypedDataTableColumn("RangingCodeMaxima", @"RangingCodeMaxima", typeof(System.String), this.Columns);
			_columnCompanySoh = GeneralUtils.CreateTypedDataTableColumn("CompanySoh", @"CompanySoh", typeof(System.Int32), this.Columns);
			_columnTransitionItemCode = GeneralUtils.CreateTypedDataTableColumn("TransitionItemCode", @"TransitionItemCode", typeof(System.String), this.Columns);
			_columnNoTester = GeneralUtils.CreateTypedDataTableColumn("NoTester", @"NoTester", typeof(System.String), this.Columns);
			_columnStockOnOrder = GeneralUtils.CreateTypedDataTableColumn("StockOnOrder", @"StockOnOrder", typeof(System.Int32), this.Columns);
			_columnExpectedReceiptDate = GeneralUtils.CreateTypedDataTableColumn("ExpectedReceiptDate", @"ExpectedReceiptDate", typeof(System.DateTime), this.Columns);
			_columnTravelSize = GeneralUtils.CreateTypedDataTableColumn("TravelSize", @"TravelSize", typeof(System.String), this.Columns);
			_columnTerminationDate = GeneralUtils.CreateTypedDataTableColumn("TerminationDate", @"TerminationDate", typeof(System.String), this.Columns);
			_columnItemSid = GeneralUtils.CreateTypedDataTableColumn("ItemSid", @"ItemSid", typeof(System.Decimal), this.Columns);
	// __LLBLGENPRO_USER_CODE_REGION_START InitClass 
	// __LLBLGENPRO_USER_CODE_REGION_END 
			OnInitialized();
		}

		/// <summary>Initializes the members, after a clone action.</summary>
		private void InitMembers()
		{
			_columnProductId = this.Columns["ProductId"];
			_columnItemCode = this.Columns["ItemCode"];
			_columnDescription = this.Columns["Description"];
			_columnVendorCode = this.Columns["VendorCode"];
			_columnDepartmentName = this.Columns["DepartmentName"];
			_columnCategoryName = this.Columns["CategoryName"];
			_columnLifestage = this.Columns["Lifestage"];
			_columnLimitedEdition = this.Columns["LimitedEdition"];
			_columnUnitPrice = this.Columns["UnitPrice"];
			_columnNzUnitPrice = this.Columns["NzUnitPrice"];
			_columnLaunchDate = this.Columns["LaunchDate"];
			_columnRangingCodeMecca = this.Columns["RangingCodeMecca"];
			_columnRangingCodeKit = this.Columns["RangingCodeKit"];
			_columnRangingCodeImo = this.Columns["RangingCodeImo"];
			_columnRangingCodeMaxima = this.Columns["RangingCodeMaxima"];
			_columnCompanySoh = this.Columns["CompanySoh"];
			_columnTransitionItemCode = this.Columns["TransitionItemCode"];
			_columnNoTester = this.Columns["NoTester"];
			_columnStockOnOrder = this.Columns["StockOnOrder"];
			_columnExpectedReceiptDate = this.Columns["ExpectedReceiptDate"];
			_columnTravelSize = this.Columns["TravelSize"];
			_columnTerminationDate = this.Columns["TerminationDate"];
			_columnItemSid = this.Columns["ItemSid"];
	// __LLBLGENPRO_USER_CODE_REGION_START InitMembers 
	// __LLBLGENPRO_USER_CODE_REGION_END 
		}

		/// <summary>Clones this instance.</summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			Product1TypedView cloneToReturn = ((Product1TypedView)(base.Clone()));
			cloneToReturn.InitMembers();
			return cloneToReturn;
		}

		/// <summary>Creates a new instance of the DataTable class.</summary>
		/// <returns>a new instance of a datatable with this schema.</returns>
		protected override DataTable CreateInstance() 
		{
			return new Product1TypedView();
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
			get { return Product1TypedView.CustomProperties;}
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
			get { return Product1TypedView.FieldsCustomProperties;}
		}
		
		/// <summary>Returns the column object belonging to the TypedView field 'ProductId'</summary>
		internal DataColumn ProductIdColumn 
		{
			get { return _columnProductId; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'ItemCode'</summary>
		internal DataColumn ItemCodeColumn 
		{
			get { return _columnItemCode; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'Description'</summary>
		internal DataColumn DescriptionColumn 
		{
			get { return _columnDescription; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'VendorCode'</summary>
		internal DataColumn VendorCodeColumn 
		{
			get { return _columnVendorCode; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'DepartmentName'</summary>
		internal DataColumn DepartmentNameColumn 
		{
			get { return _columnDepartmentName; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'CategoryName'</summary>
		internal DataColumn CategoryNameColumn 
		{
			get { return _columnCategoryName; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'Lifestage'</summary>
		internal DataColumn LifestageColumn 
		{
			get { return _columnLifestage; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'LimitedEdition'</summary>
		internal DataColumn LimitedEditionColumn 
		{
			get { return _columnLimitedEdition; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'UnitPrice'</summary>
		internal DataColumn UnitPriceColumn 
		{
			get { return _columnUnitPrice; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'NzUnitPrice'</summary>
		internal DataColumn NzUnitPriceColumn 
		{
			get { return _columnNzUnitPrice; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'LaunchDate'</summary>
		internal DataColumn LaunchDateColumn 
		{
			get { return _columnLaunchDate; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'RangingCodeMecca'</summary>
		internal DataColumn RangingCodeMeccaColumn 
		{
			get { return _columnRangingCodeMecca; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'RangingCodeKit'</summary>
		internal DataColumn RangingCodeKitColumn 
		{
			get { return _columnRangingCodeKit; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'RangingCodeImo'</summary>
		internal DataColumn RangingCodeImoColumn 
		{
			get { return _columnRangingCodeImo; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'RangingCodeMaxima'</summary>
		internal DataColumn RangingCodeMaximaColumn 
		{
			get { return _columnRangingCodeMaxima; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'CompanySoh'</summary>
		internal DataColumn CompanySohColumn 
		{
			get { return _columnCompanySoh; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'TransitionItemCode'</summary>
		internal DataColumn TransitionItemCodeColumn 
		{
			get { return _columnTransitionItemCode; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'NoTester'</summary>
		internal DataColumn NoTesterColumn 
		{
			get { return _columnNoTester; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'StockOnOrder'</summary>
		internal DataColumn StockOnOrderColumn 
		{
			get { return _columnStockOnOrder; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'ExpectedReceiptDate'</summary>
		internal DataColumn ExpectedReceiptDateColumn 
		{
			get { return _columnExpectedReceiptDate; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'TravelSize'</summary>
		internal DataColumn TravelSizeColumn 
		{
			get { return _columnTravelSize; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'TerminationDate'</summary>
		internal DataColumn TerminationDateColumn 
		{
			get { return _columnTerminationDate; }
		}
		/// <summary>Returns the column object belonging to the TypedView field 'ItemSid'</summary>
		internal DataColumn ItemSidColumn 
		{
			get { return _columnItemSid; }
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


	/// <summary>Typed datarow for the typed datatable Product1</summary>
	public partial class Product1Row : DataRow
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow 
	// __LLBLGENPRO_USER_CODE_REGION_END 
	{
		#region Class Member Declarations
		private Product1TypedView	_parent;
		#endregion

		/// <summary>CTor</summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		protected internal Product1Row(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((Product1TypedView)(this.Table));
		}

		#region Class Property Declarations
		/// <summary>Gets / sets the value of the TypedView field ProductId</summary>
		/// <remarks>Mapped on view field: "products"."product_id"<br/>
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
		
		/// <summary>Gets / sets the value of the TypedView field ItemCode</summary>
		/// <remarks>Mapped on view field: "products"."item_code"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 20</remarks>
		public System.String ItemCode
		{
			get { return IsItemCodeNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.ItemCodeColumn]; }
			set { this[_parent.ItemCodeColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field ItemCode is NULL, false otherwise.</summary>
		public bool IsItemCodeNull() 
		{
			return IsNull(_parent.ItemCodeColumn);
		}

		/// <summary>Sets the TypedView field ItemCode to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetItemCodeNull() 
		{
			this[_parent.ItemCodeColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field Description</summary>
		/// <remarks>Mapped on view field: "products"."description"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 30</remarks>
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
		
		/// <summary>Gets / sets the value of the TypedView field VendorCode</summary>
		/// <remarks>Mapped on view field: "products"."vendor_code"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 20</remarks>
		public System.String VendorCode
		{
			get { return IsVendorCodeNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.VendorCodeColumn]; }
			set { this[_parent.VendorCodeColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field VendorCode is NULL, false otherwise.</summary>
		public bool IsVendorCodeNull() 
		{
			return IsNull(_parent.VendorCodeColumn);
		}

		/// <summary>Sets the TypedView field VendorCode to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetVendorCodeNull() 
		{
			this[_parent.VendorCodeColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field DepartmentName</summary>
		/// <remarks>Mapped on view field: "products"."department_name"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 50</remarks>
		public System.String DepartmentName
		{
			get { return IsDepartmentNameNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.DepartmentNameColumn]; }
			set { this[_parent.DepartmentNameColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field DepartmentName is NULL, false otherwise.</summary>
		public bool IsDepartmentNameNull() 
		{
			return IsNull(_parent.DepartmentNameColumn);
		}

		/// <summary>Sets the TypedView field DepartmentName to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetDepartmentNameNull() 
		{
			this[_parent.DepartmentNameColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field CategoryName</summary>
		/// <remarks>Mapped on view field: "products"."category_name"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 50</remarks>
		public System.String CategoryName
		{
			get { return IsCategoryNameNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.CategoryNameColumn]; }
			set { this[_parent.CategoryNameColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field CategoryName is NULL, false otherwise.</summary>
		public bool IsCategoryNameNull() 
		{
			return IsNull(_parent.CategoryNameColumn);
		}

		/// <summary>Sets the TypedView field CategoryName to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetCategoryNameNull() 
		{
			this[_parent.CategoryNameColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field Lifestage</summary>
		/// <remarks>Mapped on view field: "products"."lifestage"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 5</remarks>
		public System.String Lifestage
		{
			get { return IsLifestageNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.LifestageColumn]; }
			set { this[_parent.LifestageColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field Lifestage is NULL, false otherwise.</summary>
		public bool IsLifestageNull() 
		{
			return IsNull(_parent.LifestageColumn);
		}

		/// <summary>Sets the TypedView field Lifestage to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetLifestageNull() 
		{
			this[_parent.LifestageColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field LimitedEdition</summary>
		/// <remarks>Mapped on view field: "products"."limited_edition"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 3</remarks>
		public System.String LimitedEdition
		{
			get { return IsLimitedEditionNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.LimitedEditionColumn]; }
			set { this[_parent.LimitedEditionColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field LimitedEdition is NULL, false otherwise.</summary>
		public bool IsLimitedEditionNull() 
		{
			return IsNull(_parent.LimitedEditionColumn);
		}

		/// <summary>Sets the TypedView field LimitedEdition to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetLimitedEditionNull() 
		{
			this[_parent.LimitedEditionColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field UnitPrice</summary>
		/// <remarks>Mapped on view field: "products"."unit_price"<br/>
		/// View field characteristics (type, precision, scale, length): Decimal, 12, 3, 0</remarks>
		public System.Decimal UnitPrice
		{
			get { return IsUnitPriceNull() ? (System.Decimal)TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)) : (System.Decimal)this[_parent.UnitPriceColumn]; }
			set { this[_parent.UnitPriceColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field UnitPrice is NULL, false otherwise.</summary>
		public bool IsUnitPriceNull() 
		{
			return IsNull(_parent.UnitPriceColumn);
		}

		/// <summary>Sets the TypedView field UnitPrice to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetUnitPriceNull() 
		{
			this[_parent.UnitPriceColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field NzUnitPrice</summary>
		/// <remarks>Mapped on view field: "products"."nz_unit_price"<br/>
		/// View field characteristics (type, precision, scale, length): Decimal, 12, 3, 0</remarks>
		public System.Decimal NzUnitPrice
		{
			get { return IsNzUnitPriceNull() ? (System.Decimal)TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)) : (System.Decimal)this[_parent.NzUnitPriceColumn]; }
			set { this[_parent.NzUnitPriceColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field NzUnitPrice is NULL, false otherwise.</summary>
		public bool IsNzUnitPriceNull() 
		{
			return IsNull(_parent.NzUnitPriceColumn);
		}

		/// <summary>Sets the TypedView field NzUnitPrice to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetNzUnitPriceNull() 
		{
			this[_parent.NzUnitPriceColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field LaunchDate</summary>
		/// <remarks>Mapped on view field: "products"."launch_date"<br/>
		/// View field characteristics (type, precision, scale, length): Date, 0, 0, 0</remarks>
		public System.DateTime LaunchDate
		{
			get { return IsLaunchDateNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.LaunchDateColumn]; }
			set { this[_parent.LaunchDateColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field LaunchDate is NULL, false otherwise.</summary>
		public bool IsLaunchDateNull() 
		{
			return IsNull(_parent.LaunchDateColumn);
		}

		/// <summary>Sets the TypedView field LaunchDate to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetLaunchDateNull() 
		{
			this[_parent.LaunchDateColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field RangingCodeMecca</summary>
		/// <remarks>Mapped on view field: "products"."ranging_code_mecca"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 342</remarks>
		public System.String RangingCodeMecca
		{
			get { return IsRangingCodeMeccaNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.RangingCodeMeccaColumn]; }
			set { this[_parent.RangingCodeMeccaColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field RangingCodeMecca is NULL, false otherwise.</summary>
		public bool IsRangingCodeMeccaNull() 
		{
			return IsNull(_parent.RangingCodeMeccaColumn);
		}

		/// <summary>Sets the TypedView field RangingCodeMecca to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetRangingCodeMeccaNull() 
		{
			this[_parent.RangingCodeMeccaColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field RangingCodeKit</summary>
		/// <remarks>Mapped on view field: "products"."ranging_code_kit"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 342</remarks>
		public System.String RangingCodeKit
		{
			get { return IsRangingCodeKitNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.RangingCodeKitColumn]; }
			set { this[_parent.RangingCodeKitColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field RangingCodeKit is NULL, false otherwise.</summary>
		public bool IsRangingCodeKitNull() 
		{
			return IsNull(_parent.RangingCodeKitColumn);
		}

		/// <summary>Sets the TypedView field RangingCodeKit to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetRangingCodeKitNull() 
		{
			this[_parent.RangingCodeKitColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field RangingCodeImo</summary>
		/// <remarks>Mapped on view field: "products"."ranging_code_imo"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 342</remarks>
		public System.String RangingCodeImo
		{
			get { return IsRangingCodeImoNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.RangingCodeImoColumn]; }
			set { this[_parent.RangingCodeImoColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field RangingCodeImo is NULL, false otherwise.</summary>
		public bool IsRangingCodeImoNull() 
		{
			return IsNull(_parent.RangingCodeImoColumn);
		}

		/// <summary>Sets the TypedView field RangingCodeImo to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetRangingCodeImoNull() 
		{
			this[_parent.RangingCodeImoColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field RangingCodeMaxima</summary>
		/// <remarks>Mapped on view field: "products"."ranging_code_maxima"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 342</remarks>
		public System.String RangingCodeMaxima
		{
			get { return IsRangingCodeMaximaNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.RangingCodeMaximaColumn]; }
			set { this[_parent.RangingCodeMaximaColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field RangingCodeMaxima is NULL, false otherwise.</summary>
		public bool IsRangingCodeMaximaNull() 
		{
			return IsNull(_parent.RangingCodeMaximaColumn);
		}

		/// <summary>Sets the TypedView field RangingCodeMaxima to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetRangingCodeMaximaNull() 
		{
			this[_parent.RangingCodeMaximaColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field CompanySoh</summary>
		/// <remarks>Mapped on view field: "products"."company_soh"<br/>
		/// View field characteristics (type, precision, scale, length): Int, 10, 0, 0</remarks>
		public System.Int32 CompanySoh
		{
			get { return IsCompanySohNull() ? (System.Int32)TypeDefaultValue.GetDefaultValue(typeof(System.Int32)) : (System.Int32)this[_parent.CompanySohColumn]; }
			set { this[_parent.CompanySohColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field CompanySoh is NULL, false otherwise.</summary>
		public bool IsCompanySohNull() 
		{
			return IsNull(_parent.CompanySohColumn);
		}

		/// <summary>Sets the TypedView field CompanySoh to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetCompanySohNull() 
		{
			this[_parent.CompanySohColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field TransitionItemCode</summary>
		/// <remarks>Mapped on view field: "products"."transition_item_code"<br/>
		/// View field characteristics (type, precision, scale, length): VarChar, 0, 0, 20</remarks>
		public System.String TransitionItemCode
		{
			get { return IsTransitionItemCodeNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.TransitionItemCodeColumn]; }
			set { this[_parent.TransitionItemCodeColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field TransitionItemCode is NULL, false otherwise.</summary>
		public bool IsTransitionItemCodeNull() 
		{
			return IsNull(_parent.TransitionItemCodeColumn);
		}

		/// <summary>Sets the TypedView field TransitionItemCode to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetTransitionItemCodeNull() 
		{
			this[_parent.TransitionItemCodeColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field NoTester</summary>
		/// <remarks>Mapped on view field: "products"."no_tester"<br/>
		/// View field characteristics (type, precision, scale, length): VarChar, 0, 0, 50</remarks>
		public System.String NoTester
		{
			get { return IsNoTesterNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.NoTesterColumn]; }
			set { this[_parent.NoTesterColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field NoTester is NULL, false otherwise.</summary>
		public bool IsNoTesterNull() 
		{
			return IsNull(_parent.NoTesterColumn);
		}

		/// <summary>Sets the TypedView field NoTester to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetNoTesterNull() 
		{
			this[_parent.NoTesterColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field StockOnOrder</summary>
		/// <remarks>Mapped on view field: "products"."stock_on_order"<br/>
		/// View field characteristics (type, precision, scale, length): Int, 10, 0, 0</remarks>
		public System.Int32 StockOnOrder
		{
			get { return IsStockOnOrderNull() ? (System.Int32)TypeDefaultValue.GetDefaultValue(typeof(System.Int32)) : (System.Int32)this[_parent.StockOnOrderColumn]; }
			set { this[_parent.StockOnOrderColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field StockOnOrder is NULL, false otherwise.</summary>
		public bool IsStockOnOrderNull() 
		{
			return IsNull(_parent.StockOnOrderColumn);
		}

		/// <summary>Sets the TypedView field StockOnOrder to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetStockOnOrderNull() 
		{
			this[_parent.StockOnOrderColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field ExpectedReceiptDate</summary>
		/// <remarks>Mapped on view field: "products"."expected_receipt_date"<br/>
		/// View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0</remarks>
		public System.DateTime ExpectedReceiptDate
		{
			get { return IsExpectedReceiptDateNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.ExpectedReceiptDateColumn]; }
			set { this[_parent.ExpectedReceiptDateColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field ExpectedReceiptDate is NULL, false otherwise.</summary>
		public bool IsExpectedReceiptDateNull() 
		{
			return IsNull(_parent.ExpectedReceiptDateColumn);
		}

		/// <summary>Sets the TypedView field ExpectedReceiptDate to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetExpectedReceiptDateNull() 
		{
			this[_parent.ExpectedReceiptDateColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field TravelSize</summary>
		/// <remarks>Mapped on view field: "products"."travel_size"<br/>
		/// View field characteristics (type, precision, scale, length): VarChar, 0, 0, 5</remarks>
		public System.String TravelSize
		{
			get { return IsTravelSizeNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.TravelSizeColumn]; }
			set { this[_parent.TravelSizeColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field TravelSize is NULL, false otherwise.</summary>
		public bool IsTravelSizeNull() 
		{
			return IsNull(_parent.TravelSizeColumn);
		}

		/// <summary>Sets the TypedView field TravelSize to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetTravelSizeNull() 
		{
			this[_parent.TravelSizeColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field TerminationDate</summary>
		/// <remarks>Mapped on view field: "products"."termination_date"<br/>
		/// View field characteristics (type, precision, scale, length): VarChar, 0, 0, 10</remarks>
		public System.String TerminationDate
		{
			get { return IsTerminationDateNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.TerminationDateColumn]; }
			set { this[_parent.TerminationDateColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field TerminationDate is NULL, false otherwise.</summary>
		public bool IsTerminationDateNull() 
		{
			return IsNull(_parent.TerminationDateColumn);
		}

		/// <summary>Sets the TypedView field TerminationDate to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetTerminationDateNull() 
		{
			this[_parent.TerminationDateColumn] = System.Convert.DBNull;
		}
		
		/// <summary>Gets / sets the value of the TypedView field ItemSid</summary>
		/// <remarks>Mapped on view field: "products"."item_sid"<br/>
		/// View field characteristics (type, precision, scale, length): Decimal, 19, 0, 0</remarks>
		public System.Decimal ItemSid
		{
			get { return IsItemSidNull() ? (System.Decimal)TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)) : (System.Decimal)this[_parent.ItemSidColumn]; }
			set { this[_parent.ItemSidColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field ItemSid is NULL, false otherwise.</summary>
		public bool IsItemSidNull() 
		{
			return IsNull(_parent.ItemSidColumn);
		}

		/// <summary>Sets the TypedView field ItemSid to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
		public void SetItemSidNull() 
		{
			this[_parent.ItemSidColumn] = System.Convert.DBNull;
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
