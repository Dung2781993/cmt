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
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Data;
using System.Xml.Serialization;
using Mecca.CMT.DAL;
using Mecca.CMT.DAL.FactoryClasses;
using Mecca.CMT.DAL.DaoClasses;
using Mecca.CMT.DAL.RelationClasses;
using Mecca.CMT.DAL.HelperClasses;
using Mecca.CMT.DAL.CollectionClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Mecca.CMT.DAL.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'Product'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class ProductEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private Mecca.CMT.DAL.CollectionClasses.CampaignItemCollection	_campaignItems;
		private bool	_alwaysFetchCampaignItems, _alreadyFetchedCampaignItems;
		private Mecca.CMT.DAL.CollectionClasses.ChannelItemCollection	_channelItems;
		private bool	_alwaysFetchChannelItems, _alreadyFetchedChannelItems;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name CampaignItems</summary>
			public static readonly string CampaignItems = "CampaignItems";
			/// <summary>Member name ChannelItems</summary>
			public static readonly string ChannelItems = "ChannelItems";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ProductEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ProductEntity() :base("ProductEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		public ProductEntity(System.Int32 productId):base("ProductEntity")
		{
			InitClassFetch(productId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ProductEntity(System.Int32 productId, IPrefetchPath prefetchPathToUse):base("ProductEntity")
		{
			InitClassFetch(productId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="validator">The custom validator object for this ProductEntity</param>
		public ProductEntity(System.Int32 productId, IValidator validator):base("ProductEntity")
		{
			InitClassFetch(productId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProductEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_campaignItems = (Mecca.CMT.DAL.CollectionClasses.CampaignItemCollection)info.GetValue("_campaignItems", typeof(Mecca.CMT.DAL.CollectionClasses.CampaignItemCollection));
			_alwaysFetchCampaignItems = info.GetBoolean("_alwaysFetchCampaignItems");
			_alreadyFetchedCampaignItems = info.GetBoolean("_alreadyFetchedCampaignItems");

			_channelItems = (Mecca.CMT.DAL.CollectionClasses.ChannelItemCollection)info.GetValue("_channelItems", typeof(Mecca.CMT.DAL.CollectionClasses.ChannelItemCollection));
			_alwaysFetchChannelItems = info.GetBoolean("_alwaysFetchChannelItems");
			_alreadyFetchedChannelItems = info.GetBoolean("_alreadyFetchedChannelItems");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedCampaignItems = (_campaignItems.Count > 0);
			_alreadyFetchedChannelItems = (_channelItems.Count > 0);
		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		protected override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		internal static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "CampaignItems":
					toReturn.Add(Relations.CampaignItemEntityUsingProductId);
					break;
				case "ChannelItems":
					toReturn.Add(Relations.ChannelItemEntityUsingProductId);
					break;
				default:
					break;				
			}
			return toReturn;
		}



		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_campaignItems", (!this.MarkedForDeletion?_campaignItems:null));
			info.AddValue("_alwaysFetchCampaignItems", _alwaysFetchCampaignItems);
			info.AddValue("_alreadyFetchedCampaignItems", _alreadyFetchedCampaignItems);
			info.AddValue("_channelItems", (!this.MarkedForDeletion?_channelItems:null));
			info.AddValue("_alwaysFetchChannelItems", _alwaysFetchChannelItems);
			info.AddValue("_alreadyFetchedChannelItems", _alreadyFetchedChannelItems);

			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "CampaignItems":
					_alreadyFetchedCampaignItems = true;
					if(entity!=null)
					{
						this.CampaignItems.Add((CampaignItemEntity)entity);
					}
					break;
				case "ChannelItems":
					_alreadyFetchedChannelItems = true;
					if(entity!=null)
					{
						this.ChannelItems.Add((ChannelItemEntity)entity);
					}
					break;
				default:
					this.OnSetRelatedEntityProperty(propertyName, entity);
					break;
			}
		}

		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void SetRelatedEntity(IEntityCore relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "CampaignItems":
					_campaignItems.Add((CampaignItemEntity)relatedEntity);
					break;
				case "ChannelItems":
					_channelItems.Add((ChannelItemEntity)relatedEntity);
					break;
				default:
					break;
			}
		}
		
		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void UnsetRelatedEntity(IEntityCore relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "CampaignItems":
					this.PerformRelatedEntityRemoval(_campaignItems, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ChannelItems":
					this.PerformRelatedEntityRemoval(_channelItems, relatedEntity, signalRelatedEntityManyToOne);
					break;
				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		protected override List<IEntity> GetDependingRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		protected override List<IEntity> GetDependentRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_campaignItems);
			toReturn.Add(_channelItems);

			return toReturn;
		}

		/// <summary> Method which will try to fetch the contents for this entity using a unique constraint. </summary>
		/// <remarks>All contents of the entity is lost.</remarks>
		/// <param name="itemCode">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public bool FetchUsingUCItemCode(System.String itemCode)
		{
			return FetchUsingUCItemCode( itemCode, null, null, null);
		}

		/// <summary> Method which will try to fetch the contents for this entity using a unique constraint. </summary>
		/// <remarks>All contents of the entity is lost.</remarks>
		/// <param name="itemCode">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public bool FetchUsingUCItemCode(System.String itemCode, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingUCItemCode( itemCode, prefetchPathToUse, null, null);
		}
	
		/// <summary> Method which will try to fetch the contents for this entity using a unique constraint. </summary>
		/// <remarks>All contents of the entity is lost.</remarks>
		/// <param name="itemCode">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public bool FetchUsingUCItemCode(System.String itemCode, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingUCItemCode( itemCode, prefetchPathToUse, contextToUse, null);
		}
	
		/// <summary> Method which will try to fetch the contents for this entity using a unique constraint. </summary>
		/// <remarks>All contents of the entity is lost.</remarks>
		/// <param name="itemCode">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public bool FetchUsingUCItemCode(System.String itemCode, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				((ProductDAO)CreateDAOInstance()).FetchProductUsingUCItemCode(this, this.Transaction, itemCode, prefetchPathToUse, contextToUse, excludedIncludedFields);
				return (this.Fields.State == EntityState.Fetched);
			}
			finally
			{
				OnFetchComplete();
			}
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productId)
		{
			return FetchUsingPK(productId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(productId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(productId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(productId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.ProductId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new ProductRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'CampaignItemEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CampaignItemEntity'</returns>
		public Mecca.CMT.DAL.CollectionClasses.CampaignItemCollection GetMultiCampaignItems(bool forceFetch)
		{
			return GetMultiCampaignItems(forceFetch, _campaignItems.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CampaignItemEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'CampaignItemEntity'</returns>
		public Mecca.CMT.DAL.CollectionClasses.CampaignItemCollection GetMultiCampaignItems(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiCampaignItems(forceFetch, _campaignItems.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'CampaignItemEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Mecca.CMT.DAL.CollectionClasses.CampaignItemCollection GetMultiCampaignItems(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiCampaignItems(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CampaignItemEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Mecca.CMT.DAL.CollectionClasses.CampaignItemCollection GetMultiCampaignItems(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
			if( ( (!_alreadyFetchedCampaignItems && EntityBase.EnableLazyLoading) || forceFetch || _alwaysFetchCampaignItems) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_campaignItems);
				_campaignItems.SuppressClearInGetMulti=!forceFetch;
				_campaignItems.EntityFactoryToUse = entityFactoryToUse;
				_campaignItems.GetMultiManyToOne(null, this, filter);
				_campaignItems.SuppressClearInGetMulti=false;
				_alreadyFetchedCampaignItems = true;
			}
			return _campaignItems;
		}

		/// <summary> Sets the collection parameters for the collection for 'CampaignItems'. These settings will be taken into account
		/// when the property CampaignItems is requested or GetMultiCampaignItems is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCampaignItems(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_campaignItems.SortClauses=sortClauses;
			_campaignItems.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ChannelItemEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ChannelItemEntity'</returns>
		public Mecca.CMT.DAL.CollectionClasses.ChannelItemCollection GetMultiChannelItems(bool forceFetch)
		{
			return GetMultiChannelItems(forceFetch, _channelItems.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ChannelItemEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ChannelItemEntity'</returns>
		public Mecca.CMT.DAL.CollectionClasses.ChannelItemCollection GetMultiChannelItems(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiChannelItems(forceFetch, _channelItems.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ChannelItemEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Mecca.CMT.DAL.CollectionClasses.ChannelItemCollection GetMultiChannelItems(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiChannelItems(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ChannelItemEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Mecca.CMT.DAL.CollectionClasses.ChannelItemCollection GetMultiChannelItems(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
			if( ( (!_alreadyFetchedChannelItems && EntityBase.EnableLazyLoading) || forceFetch || _alwaysFetchChannelItems) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_channelItems);
				_channelItems.SuppressClearInGetMulti=!forceFetch;
				_channelItems.EntityFactoryToUse = entityFactoryToUse;
				_channelItems.GetMultiManyToOne(null, this, filter);
				_channelItems.SuppressClearInGetMulti=false;
				_alreadyFetchedChannelItems = true;
			}
			return _channelItems;
		}

		/// <summary> Sets the collection parameters for the collection for 'ChannelItems'. These settings will be taken into account
		/// when the property ChannelItems is requested or GetMultiChannelItems is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersChannelItems(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_channelItems.SortClauses=sortClauses;
			_channelItems.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("CampaignItems", _campaignItems);
			toReturn.Add("ChannelItems", _channelItems);
			return toReturn;
		}
	
		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validatorToUse">Validator to use.</param>
		private void InitClassEmpty(IValidator validatorToUse)
		{
			OnInitializing();
			this.Fields = CreateFields();
			this.Validator = validatorToUse;
			InitClassMembers();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="validator">The validator object for this ProductEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 productId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(productId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_campaignItems = new Mecca.CMT.DAL.CollectionClasses.CampaignItemCollection();
			_campaignItems.SetContainingEntityInfo(this, "Product");

			_channelItems = new Mecca.CMT.DAL.CollectionClasses.ChannelItemCollection();
			_channelItems.SetContainingEntityInfo(this, "Product");
			PerformDependencyInjection();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CategoryName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CompanySoh", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DepartmentName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Description", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ExpectedReceiptDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ItemCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ItemSid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LaunchDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Lifestage", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LimitedEdition", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("NoTester", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("NzUnitPrice", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("RangingCodeImo", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("RangingCodeKit", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("RangingCodeMaxima", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("RangingCodeMecca", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("StockOnOrder", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TerminationDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TransitionItemCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TravelSize", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UnitPrice", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VendorCode", fieldHashtable);
		}
		#endregion

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 productId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)ProductFieldIndex.ProductId].ForcedCurrentValueWrite(productId);
				CreateDAOInstance().FetchExisting(this, this.Transaction, prefetchPathToUse, contextToUse, excludedIncludedFields);
				return (this.Fields.State == EntityState.Fetched);
			}
			finally
			{
				OnFetchComplete();
			}
		}

		/// <summary> Creates the DAO instance for this type</summary>
		/// <returns></returns>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateProductDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ProductEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ProductRelations Relations
		{
			get	{ return new ProductRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CampaignItem' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCampaignItems
		{
			get { return new PrefetchPathElement(new Mecca.CMT.DAL.CollectionClasses.CampaignItemCollection(), (IEntityRelation)GetRelationsForField("CampaignItems")[0], (int)Mecca.CMT.DAL.EntityType.ProductEntity, (int)Mecca.CMT.DAL.EntityType.CampaignItemEntity, 0, null, null, null, "CampaignItems", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ChannelItem' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathChannelItems
		{
			get { return new PrefetchPathElement(new Mecca.CMT.DAL.CollectionClasses.ChannelItemCollection(), (IEntityRelation)GetRelationsForField("ChannelItems")[0], (int)Mecca.CMT.DAL.EntityType.ProductEntity, (int)Mecca.CMT.DAL.EntityType.ChannelItemEntity, 0, null, null, null, "ChannelItems", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return FieldsCustomProperties;}
		}

		/// <summary> The CategoryName property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "products"."category_name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CategoryName
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.CategoryName, true); }
			set	{ SetValue((int)ProductFieldIndex.CategoryName, value, true); }
		}

		/// <summary> The CompanySoh property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "products"."company_soh"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> CompanySoh
		{
			get { return (Nullable<System.Int32>)GetValue((int)ProductFieldIndex.CompanySoh, false); }
			set	{ SetValue((int)ProductFieldIndex.CompanySoh, value, true); }
		}

		/// <summary> The DepartmentName property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "products"."department_name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String DepartmentName
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.DepartmentName, true); }
			set	{ SetValue((int)ProductFieldIndex.DepartmentName, value, true); }
		}

		/// <summary> The Description property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "products"."description"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 30<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Description
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.Description, true); }
			set	{ SetValue((int)ProductFieldIndex.Description, value, true); }
		}

		/// <summary> The ExpectedReceiptDate property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "products"."expected_receipt_date"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> ExpectedReceiptDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)ProductFieldIndex.ExpectedReceiptDate, false); }
			set	{ SetValue((int)ProductFieldIndex.ExpectedReceiptDate, value, true); }
		}

		/// <summary> The ItemCode property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "products"."item_code"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ItemCode
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.ItemCode, true); }
			set	{ SetValue((int)ProductFieldIndex.ItemCode, value, true); }
		}

		/// <summary> The ItemSid property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "products"."item_sid"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> ItemSid
		{
			get { return (Nullable<System.Decimal>)GetValue((int)ProductFieldIndex.ItemSid, false); }
			set	{ SetValue((int)ProductFieldIndex.ItemSid, value, true); }
		}

		/// <summary> The LaunchDate property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "products"."launch_date"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> LaunchDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)ProductFieldIndex.LaunchDate, false); }
			set	{ SetValue((int)ProductFieldIndex.LaunchDate, value, true); }
		}

		/// <summary> The Lifestage property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "products"."lifestage"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 5<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Lifestage
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.Lifestage, true); }
			set	{ SetValue((int)ProductFieldIndex.Lifestage, value, true); }
		}

		/// <summary> The LimitedEdition property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "products"."limited_edition"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String LimitedEdition
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.LimitedEdition, true); }
			set	{ SetValue((int)ProductFieldIndex.LimitedEdition, value, true); }
		}

		/// <summary> The NoTester property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "products"."no_tester"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String NoTester
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.NoTester, true); }
			set	{ SetValue((int)ProductFieldIndex.NoTester, value, true); }
		}

		/// <summary> The NzUnitPrice property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "products"."nz_unit_price"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 12, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> NzUnitPrice
		{
			get { return (Nullable<System.Decimal>)GetValue((int)ProductFieldIndex.NzUnitPrice, false); }
			set	{ SetValue((int)ProductFieldIndex.NzUnitPrice, value, true); }
		}

		/// <summary> The ProductId property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "products"."product_id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ProductId
		{
			get { return (System.Int32)GetValue((int)ProductFieldIndex.ProductId, true); }
			set	{ SetValue((int)ProductFieldIndex.ProductId, value, true); }
		}

		/// <summary> The RangingCodeImo property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "products"."ranging_code_imo"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 342<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String RangingCodeImo
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.RangingCodeImo, true); }
			set	{ SetValue((int)ProductFieldIndex.RangingCodeImo, value, true); }
		}

		/// <summary> The RangingCodeKit property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "products"."ranging_code_kit"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 342<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String RangingCodeKit
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.RangingCodeKit, true); }
			set	{ SetValue((int)ProductFieldIndex.RangingCodeKit, value, true); }
		}

		/// <summary> The RangingCodeMaxima property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "products"."ranging_code_maxima"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 342<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String RangingCodeMaxima
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.RangingCodeMaxima, true); }
			set	{ SetValue((int)ProductFieldIndex.RangingCodeMaxima, value, true); }
		}

		/// <summary> The RangingCodeMecca property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "products"."ranging_code_mecca"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 342<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String RangingCodeMecca
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.RangingCodeMecca, true); }
			set	{ SetValue((int)ProductFieldIndex.RangingCodeMecca, value, true); }
		}

		/// <summary> The StockOnOrder property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "products"."stock_on_order"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> StockOnOrder
		{
			get { return (Nullable<System.Int32>)GetValue((int)ProductFieldIndex.StockOnOrder, false); }
			set	{ SetValue((int)ProductFieldIndex.StockOnOrder, value, true); }
		}

		/// <summary> The TerminationDate property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "products"."termination_date"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String TerminationDate
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.TerminationDate, true); }
			set	{ SetValue((int)ProductFieldIndex.TerminationDate, value, true); }
		}

		/// <summary> The TransitionItemCode property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "products"."transition_item_code"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String TransitionItemCode
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.TransitionItemCode, true); }
			set	{ SetValue((int)ProductFieldIndex.TransitionItemCode, value, true); }
		}

		/// <summary> The TravelSize property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "products"."travel_size"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 5<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String TravelSize
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.TravelSize, true); }
			set	{ SetValue((int)ProductFieldIndex.TravelSize, value, true); }
		}

		/// <summary> The UnitPrice property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "products"."unit_price"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 12, 3, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> UnitPrice
		{
			get { return (Nullable<System.Decimal>)GetValue((int)ProductFieldIndex.UnitPrice, false); }
			set	{ SetValue((int)ProductFieldIndex.UnitPrice, value, true); }
		}

		/// <summary> The VendorCode property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "products"."vendor_code"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String VendorCode
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.VendorCode, true); }
			set	{ SetValue((int)ProductFieldIndex.VendorCode, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'CampaignItemEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCampaignItems()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Mecca.CMT.DAL.CollectionClasses.CampaignItemCollection CampaignItems
		{
			get	{ return GetMultiCampaignItems(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CampaignItems. When set to true, CampaignItems is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CampaignItems is accessed. You can always execute/ a forced fetch by calling GetMultiCampaignItems(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCampaignItems
		{
			get	{ return _alwaysFetchCampaignItems; }
			set	{ _alwaysFetchCampaignItems = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property CampaignItems already has been fetched. Setting this property to false when CampaignItems has been fetched
		/// will clear the CampaignItems collection well. Setting this property to true while CampaignItems hasn't been fetched disables lazy loading for CampaignItems</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCampaignItems
		{
			get { return _alreadyFetchedCampaignItems;}
			set 
			{
				if(_alreadyFetchedCampaignItems && !value && (_campaignItems != null))
				{
					_campaignItems.Clear();
				}
				_alreadyFetchedCampaignItems = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ChannelItemEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiChannelItems()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Mecca.CMT.DAL.CollectionClasses.ChannelItemCollection ChannelItems
		{
			get	{ return GetMultiChannelItems(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ChannelItems. When set to true, ChannelItems is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ChannelItems is accessed. You can always execute/ a forced fetch by calling GetMultiChannelItems(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchChannelItems
		{
			get	{ return _alwaysFetchChannelItems; }
			set	{ _alwaysFetchChannelItems = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ChannelItems already has been fetched. Setting this property to false when ChannelItems has been fetched
		/// will clear the ChannelItems collection well. Setting this property to true while ChannelItems hasn't been fetched disables lazy loading for ChannelItems</summary>
		[Browsable(false)]
		public bool AlreadyFetchedChannelItems
		{
			get { return _alreadyFetchedChannelItems;}
			set 
			{
				if(_alreadyFetchedChannelItems && !value && (_channelItems != null))
				{
					_channelItems.Clear();
				}
				_alreadyFetchedChannelItems = value;
			}
		}


		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}

		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		[System.ComponentModel.Browsable(false), XmlIgnore]
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary>Returns the Mecca.CMT.DAL.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)Mecca.CMT.DAL.EntityType.ProductEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
