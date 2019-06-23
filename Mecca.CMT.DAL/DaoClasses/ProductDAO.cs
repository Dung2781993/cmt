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
using System.Data;
using System.Data.Common;
using System.Collections;
using Mecca.CMT.DAL.EntityClasses;
using Mecca.CMT.DAL.FactoryClasses;
using Mecca.CMT.DAL.CollectionClasses;
using Mecca.CMT.DAL.HelperClasses;
using Mecca.CMT.DAL;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.DQE.SqlServer;


namespace Mecca.CMT.DAL.DaoClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>General DAO class for the Product Entity. It will perform database oriented actions for a entity of type 'ProductEntity'.</summary>
	public partial class ProductDAO : CommonDaoBase
	{
		/// <summary>CTor</summary>
		public ProductDAO() : base(InheritanceHierarchyType.None, "ProductEntity", new ProductEntityFactory())
		{
		}


		/// <summary>Reads an entity based on a unique constraint. Which entity is read is determined from the passed in fields for the UniqueConstraint.</summary>
		/// <param name="entityToFetch">The entity to fetch. Contained data will be overwritten.</param>
		/// <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or null if not.</param>
		/// <param name="itemCode">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <param name="contextToUse">The context to fetch the prefetch path with.</param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		public void FetchProductUsingUCItemCode(IEntity entityToFetch, ITransaction containingTransaction, System.String itemCode, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			IPredicateExpression selectFilter = new PredicateExpression();
			selectFilter.Add(new FieldCompareValuePredicate(entityToFetch.Fields[(int)ProductFieldIndex.ItemCode], ComparisonOperator.Equal, itemCode)); 
			this.PerformFetchEntityAction(entityToFetch, containingTransaction, selectFilter, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}







		
		#region Custom DAO code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomDAOCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Included Code

		#endregion
	}
}
