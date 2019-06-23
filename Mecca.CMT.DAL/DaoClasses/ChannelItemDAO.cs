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

	/// <summary>General DAO class for the ChannelItem Entity. It will perform database oriented actions for a entity of type 'ChannelItemEntity'.</summary>
	public partial class ChannelItemDAO : CommonDaoBase
	{
		/// <summary>CTor</summary>
		public ChannelItemDAO() : base(InheritanceHierarchyType.None, "ChannelItemEntity", new ChannelItemEntityFactory())
		{
		}


		/// <summary>Reads an entity based on a unique constraint. Which entity is read is determined from the passed in fields for the UniqueConstraint.</summary>
		/// <param name="entityToFetch">The entity to fetch. Contained data will be overwritten.</param>
		/// <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or null if not.</param>
		/// <param name="channelId">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="productId">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch.</param>
		/// <param name="contextToUse">The context to fetch the prefetch path with.</param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		public void FetchChannelItemUsingUCChannelIdProductId(IEntity entityToFetch, ITransaction containingTransaction, System.Int32 channelId, System.Int32 productId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			IPredicateExpression selectFilter = new PredicateExpression();
			selectFilter.Add(new FieldCompareValuePredicate(entityToFetch.Fields[(int)ChannelItemFieldIndex.ChannelId], ComparisonOperator.Equal, channelId));
			selectFilter.Add(new FieldCompareValuePredicate(entityToFetch.Fields[(int)ChannelItemFieldIndex.ProductId], ComparisonOperator.Equal, productId)); 
			this.PerformFetchEntityAction(entityToFetch, containingTransaction, selectFilter, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}


		/// <summary>Retrieves in the calling ChannelItemCollection object all ChannelItemEntity objects which have data in common with the specified related Entities. If one is omitted, that entity is not used as a filter. </summary>
		/// <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or null if not.</param>
		/// <param name="collectionToFill">Collection to fill with the entity objects retrieved</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. When set to 0, no limitations are specified.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="filter">Extra filter to limit the resultset. Predicate expression can be null, in which case it will be ignored.</param>
		/// <param name="channelInstance">ChannelEntity instance to use as a filter for the ChannelItemEntity objects to return</param>
		/// <param name="productInstance">ProductEntity instance to use as a filter for the ChannelItemEntity objects to return</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		public bool GetMulti(ITransaction containingTransaction, IEntityCollection collectionToFill, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IEntityFactory entityFactoryToUse, IPredicateExpression filter, IEntity channelInstance, IEntity productInstance, int pageNumber, int pageSize)
		{
			this.EntityFactoryToUse = entityFactoryToUse;
			IEntityFields fieldsToReturn = EntityFieldsFactory.CreateEntityFieldsObject(Mecca.CMT.DAL.EntityType.ChannelItemEntity);
			IPredicateExpression selectFilter = CreateFilterUsingForeignKeys(channelInstance, productInstance, fieldsToReturn);
			if(filter!=null)
			{
				selectFilter.AddWithAnd(filter);
			}
			return this.PerformGetMultiAction(containingTransaction, collectionToFill, maxNumberOfItemsToReturn, sortClauses, selectFilter, null, null, null, pageNumber, pageSize);
		}




		/// <summary>Deletes from the persistent storage all 'ChannelItem' entities which have data in common with the specified related Entities. If one is omitted, that entity is not used as a filter.</summary>
		/// <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or null if not.</param>
		/// <param name="channelInstance">ChannelEntity instance to use as a filter for the ChannelItemEntity objects to delete</param>
		/// <param name="productInstance">ProductEntity instance to use as a filter for the ChannelItemEntity objects to delete</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int DeleteMulti(ITransaction containingTransaction, IEntity channelInstance, IEntity productInstance)
		{
			IEntityFields fields = EntityFieldsFactory.CreateEntityFieldsObject(Mecca.CMT.DAL.EntityType.ChannelItemEntity);
			IPredicateExpression deleteFilter = CreateFilterUsingForeignKeys(channelInstance, productInstance, fields);
			return this.DeleteMulti(containingTransaction, deleteFilter);
		}

		/// <summary>Updates all entities of the same type or subtype of the entity <i>entityWithNewValues</i> directly in the persistent storage if they match the filter
		/// supplied in <i>filterBucket</i>. Only the fields changed in entityWithNewValues are updated for these fields. Entities of a subtype of the type
		/// of <i>entityWithNewValues</i> which are affected by the filterBucket's filter will thus also be updated.</summary>
		/// <param name="entityWithNewValues">IEntity instance which holds the new values for the matching entities to update. Only changed fields are taken into account</param>
		/// <param name="containingTransaction">A containing transaction, if caller is added to a transaction, or null if not.</param>
		/// <param name="channelInstance">ChannelEntity instance to use as a filter for the ChannelItemEntity objects to update</param>
		/// <param name="productInstance">ProductEntity instance to use as a filter for the ChannelItemEntity objects to update</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int UpdateMulti(IEntity entityWithNewValues, ITransaction containingTransaction, IEntity channelInstance, IEntity productInstance)
		{
			IEntityFields fields = EntityFieldsFactory.CreateEntityFieldsObject(Mecca.CMT.DAL.EntityType.ChannelItemEntity);
			IPredicateExpression updateFilter = CreateFilterUsingForeignKeys(channelInstance, productInstance, fields);
			return this.UpdateMulti(entityWithNewValues, containingTransaction, updateFilter);
		}

		/// <summary>Creates a PredicateExpression which should be used as a filter when any combination of available foreign keys is specified.</summary>
		/// <param name="channelInstance">ChannelEntity instance to use as a filter for the ChannelItemEntity objects</param>
		/// <param name="productInstance">ProductEntity instance to use as a filter for the ChannelItemEntity objects</param>
		/// <param name="fieldsToReturn">IEntityFields implementation which forms the definition of the fieldset of the target entity.</param>
		/// <returns>A ready to use PredicateExpression based on the passed in foreign key value holders.</returns>
		private IPredicateExpression CreateFilterUsingForeignKeys(IEntity channelInstance, IEntity productInstance, IEntityFields fieldsToReturn)
		{
			IPredicateExpression selectFilter = new PredicateExpression();
			
			if(channelInstance != null)
			{
				selectFilter.Add(new FieldCompareValuePredicate(fieldsToReturn[(int)ChannelItemFieldIndex.ChannelId], ComparisonOperator.Equal, ((ChannelEntity)channelInstance).ChannelId));
			}
			if(productInstance != null)
			{
				selectFilter.Add(new FieldCompareValuePredicate(fieldsToReturn[(int)ChannelItemFieldIndex.ProductId], ComparisonOperator.Equal, ((ProductEntity)productInstance).ProductId));
			}
			return selectFilter;
		}
		
		#region Custom DAO code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomDAOCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Included Code

		#endregion
	}
}
