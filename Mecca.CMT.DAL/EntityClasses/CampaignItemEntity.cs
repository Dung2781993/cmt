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

	/// <summary>Entity class which represents the entity 'CampaignItem'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class CampaignItemEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private CampaignEntity _campaign;
		private bool	_alwaysFetchCampaign, _alreadyFetchedCampaign, _campaignReturnsNewIfNotFound;
		private ProductEntity _product;
		private bool	_alwaysFetchProduct, _alreadyFetchedProduct, _productReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Campaign</summary>
			public static readonly string Campaign = "Campaign";
			/// <summary>Member name Product</summary>
			public static readonly string Product = "Product";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CampaignItemEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public CampaignItemEntity() :base("CampaignItemEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="campaignItemId">PK value for CampaignItem which data should be fetched into this CampaignItem object</param>
		public CampaignItemEntity(System.Int32 campaignItemId):base("CampaignItemEntity")
		{
			InitClassFetch(campaignItemId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="campaignItemId">PK value for CampaignItem which data should be fetched into this CampaignItem object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public CampaignItemEntity(System.Int32 campaignItemId, IPrefetchPath prefetchPathToUse):base("CampaignItemEntity")
		{
			InitClassFetch(campaignItemId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="campaignItemId">PK value for CampaignItem which data should be fetched into this CampaignItem object</param>
		/// <param name="validator">The custom validator object for this CampaignItemEntity</param>
		public CampaignItemEntity(System.Int32 campaignItemId, IValidator validator):base("CampaignItemEntity")
		{
			InitClassFetch(campaignItemId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CampaignItemEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_campaign = (CampaignEntity)info.GetValue("_campaign", typeof(CampaignEntity));
			if(_campaign!=null)
			{
				_campaign.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_campaignReturnsNewIfNotFound = info.GetBoolean("_campaignReturnsNewIfNotFound");
			_alwaysFetchCampaign = info.GetBoolean("_alwaysFetchCampaign");
			_alreadyFetchedCampaign = info.GetBoolean("_alreadyFetchedCampaign");

			_product = (ProductEntity)info.GetValue("_product", typeof(ProductEntity));
			if(_product!=null)
			{
				_product.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_productReturnsNewIfNotFound = info.GetBoolean("_productReturnsNewIfNotFound");
			_alwaysFetchProduct = info.GetBoolean("_alwaysFetchProduct");
			_alreadyFetchedProduct = info.GetBoolean("_alreadyFetchedProduct");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((CampaignItemFieldIndex)fieldIndex)
			{
				case CampaignItemFieldIndex.CampaignId:
					DesetupSyncCampaign(true, false);
					_alreadyFetchedCampaign = false;
					break;
				case CampaignItemFieldIndex.ProductId:
					DesetupSyncProduct(true, false);
					_alreadyFetchedProduct = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedCampaign = (_campaign != null);
			_alreadyFetchedProduct = (_product != null);
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
				case "Campaign":
					toReturn.Add(Relations.CampaignEntityUsingCampaignId);
					break;
				case "Product":
					toReturn.Add(Relations.ProductEntityUsingProductId);
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
			info.AddValue("_campaign", (!this.MarkedForDeletion?_campaign:null));
			info.AddValue("_campaignReturnsNewIfNotFound", _campaignReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCampaign", _alwaysFetchCampaign);
			info.AddValue("_alreadyFetchedCampaign", _alreadyFetchedCampaign);
			info.AddValue("_product", (!this.MarkedForDeletion?_product:null));
			info.AddValue("_productReturnsNewIfNotFound", _productReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchProduct", _alwaysFetchProduct);
			info.AddValue("_alreadyFetchedProduct", _alreadyFetchedProduct);

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
				case "Campaign":
					_alreadyFetchedCampaign = true;
					this.Campaign = (CampaignEntity)entity;
					break;
				case "Product":
					_alreadyFetchedProduct = true;
					this.Product = (ProductEntity)entity;
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
				case "Campaign":
					SetupSyncCampaign(relatedEntity);
					break;
				case "Product":
					SetupSyncProduct(relatedEntity);
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
				case "Campaign":
					DesetupSyncCampaign(false, true);
					break;
				case "Product":
					DesetupSyncProduct(false, true);
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
			if(_campaign!=null)
			{
				toReturn.Add(_campaign);
			}
			if(_product!=null)
			{
				toReturn.Add(_product);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();


			return toReturn;
		}

		/// <summary> Method which will try to fetch the contents for this entity using a unique constraint. </summary>
		/// <remarks>All contents of the entity is lost.</remarks>
		/// <param name="campaignId">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="productId">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public bool FetchUsingUCCampaignIdProductId(System.Int32 campaignId, System.Int32 productId)
		{
			return FetchUsingUCCampaignIdProductId( campaignId,  productId, null, null, null);
		}

		/// <summary> Method which will try to fetch the contents for this entity using a unique constraint. </summary>
		/// <remarks>All contents of the entity is lost.</remarks>
		/// <param name="campaignId">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="productId">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public bool FetchUsingUCCampaignIdProductId(System.Int32 campaignId, System.Int32 productId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingUCCampaignIdProductId( campaignId,  productId, prefetchPathToUse, null, null);
		}
	
		/// <summary> Method which will try to fetch the contents for this entity using a unique constraint. </summary>
		/// <remarks>All contents of the entity is lost.</remarks>
		/// <param name="campaignId">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="productId">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public bool FetchUsingUCCampaignIdProductId(System.Int32 campaignId, System.Int32 productId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingUCCampaignIdProductId( campaignId,  productId, prefetchPathToUse, contextToUse, null);
		}
	
		/// <summary> Method which will try to fetch the contents for this entity using a unique constraint. </summary>
		/// <remarks>All contents of the entity is lost.</remarks>
		/// <param name="campaignId">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="productId">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public bool FetchUsingUCCampaignIdProductId(System.Int32 campaignId, System.Int32 productId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				((CampaignItemDAO)CreateDAOInstance()).FetchCampaignItemUsingUCCampaignIdProductId(this, this.Transaction, campaignId, productId, prefetchPathToUse, contextToUse, excludedIncludedFields);
				return (this.Fields.State == EntityState.Fetched);
			}
			finally
			{
				OnFetchComplete();
			}
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="campaignItemId">PK value for CampaignItem which data should be fetched into this CampaignItem object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 campaignItemId)
		{
			return FetchUsingPK(campaignItemId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="campaignItemId">PK value for CampaignItem which data should be fetched into this CampaignItem object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 campaignItemId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(campaignItemId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="campaignItemId">PK value for CampaignItem which data should be fetched into this CampaignItem object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 campaignItemId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(campaignItemId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="campaignItemId">PK value for CampaignItem which data should be fetched into this CampaignItem object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 campaignItemId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(campaignItemId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.CampaignItemId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new CampaignItemRelations().GetAllRelations();
		}

		/// <summary> Retrieves the related entity of type 'CampaignEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'CampaignEntity' which is related to this entity.</returns>
		public CampaignEntity GetSingleCampaign()
		{
			return GetSingleCampaign(false);
		}

		/// <summary> Retrieves the related entity of type 'CampaignEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'CampaignEntity' which is related to this entity.</returns>
		public virtual CampaignEntity GetSingleCampaign(bool forceFetch)
		{
			if((!_alreadyFetchedCampaign || forceFetch || _alwaysFetchCampaign) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.CampaignEntityUsingCampaignId) && (EntityBase.EnableLazyLoading || forceFetch);
				CampaignEntity newEntity = new CampaignEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.CampaignId);
				}
				if(fetchResult)
				{
					newEntity = (CampaignEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_campaignReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Campaign = newEntity;
				_alreadyFetchedCampaign = fetchResult;
			}
			return _campaign;
		}


		/// <summary> Retrieves the related entity of type 'ProductEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ProductEntity' which is related to this entity.</returns>
		public ProductEntity GetSingleProduct()
		{
			return GetSingleProduct(false);
		}

		/// <summary> Retrieves the related entity of type 'ProductEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ProductEntity' which is related to this entity.</returns>
		public virtual ProductEntity GetSingleProduct(bool forceFetch)
		{
			if((!_alreadyFetchedProduct || forceFetch || _alwaysFetchProduct) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.ProductEntityUsingProductId) && (EntityBase.EnableLazyLoading || forceFetch);
				ProductEntity newEntity = new ProductEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.ProductId);
				}
				if(fetchResult)
				{
					newEntity = (ProductEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_productReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Product = newEntity;
				_alreadyFetchedProduct = fetchResult;
			}
			return _product;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Campaign", _campaign);
			toReturn.Add("Product", _product);
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
		/// <param name="campaignItemId">PK value for CampaignItem which data should be fetched into this CampaignItem object</param>
		/// <param name="validator">The validator object for this CampaignItemEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 campaignItemId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(campaignItemId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_campaignReturnsNewIfNotFound = false;
			_productReturnsNewIfNotFound = false;
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
			_fieldsCustomProperties.Add("CampaignId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CampaignItemId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DateAdded", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("EndDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("StartDate", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _campaign</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCampaign(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _campaign, new PropertyChangedEventHandler( OnCampaignPropertyChanged ), "Campaign", Mecca.CMT.DAL.RelationClasses.StaticCampaignItemRelations.CampaignEntityUsingCampaignIdStatic, true, signalRelatedEntity, "CampaignItems", resetFKFields, new int[] { (int)CampaignItemFieldIndex.CampaignId } );		
			_campaign = null;
		}
		
		/// <summary> setups the sync logic for member _campaign</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCampaign(IEntityCore relatedEntity)
		{
			if(_campaign!=relatedEntity)
			{		
				DesetupSyncCampaign(true, true);
				_campaign = (CampaignEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _campaign, new PropertyChangedEventHandler( OnCampaignPropertyChanged ), "Campaign", Mecca.CMT.DAL.RelationClasses.StaticCampaignItemRelations.CampaignEntityUsingCampaignIdStatic, true, ref _alreadyFetchedCampaign, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCampaignPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _product</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncProduct(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _product, new PropertyChangedEventHandler( OnProductPropertyChanged ), "Product", Mecca.CMT.DAL.RelationClasses.StaticCampaignItemRelations.ProductEntityUsingProductIdStatic, true, signalRelatedEntity, "CampaignItems", resetFKFields, new int[] { (int)CampaignItemFieldIndex.ProductId } );		
			_product = null;
		}
		
		/// <summary> setups the sync logic for member _product</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncProduct(IEntityCore relatedEntity)
		{
			if(_product!=relatedEntity)
			{		
				DesetupSyncProduct(true, true);
				_product = (ProductEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _product, new PropertyChangedEventHandler( OnProductPropertyChanged ), "Product", Mecca.CMT.DAL.RelationClasses.StaticCampaignItemRelations.ProductEntityUsingProductIdStatic, true, ref _alreadyFetchedProduct, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnProductPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="campaignItemId">PK value for CampaignItem which data should be fetched into this CampaignItem object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 campaignItemId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)CampaignItemFieldIndex.CampaignItemId].ForcedCurrentValueWrite(campaignItemId);
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
			return DAOFactory.CreateCampaignItemDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new CampaignItemEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static CampaignItemRelations Relations
		{
			get	{ return new CampaignItemRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Campaign'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCampaign
		{
			get	{ return new PrefetchPathElement(new Mecca.CMT.DAL.CollectionClasses.CampaignCollection(), (IEntityRelation)GetRelationsForField("Campaign")[0], (int)Mecca.CMT.DAL.EntityType.CampaignItemEntity, (int)Mecca.CMT.DAL.EntityType.CampaignEntity, 0, null, null, null, "Campaign", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Product'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathProduct
		{
			get	{ return new PrefetchPathElement(new Mecca.CMT.DAL.CollectionClasses.ProductCollection(), (IEntityRelation)GetRelationsForField("Product")[0], (int)Mecca.CMT.DAL.EntityType.CampaignItemEntity, (int)Mecca.CMT.DAL.EntityType.ProductEntity, 0, null, null, null, "Product", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The CampaignId property of the Entity CampaignItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "campaign_items"."campaign_id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 CampaignId
		{
			get { return (System.Int32)GetValue((int)CampaignItemFieldIndex.CampaignId, true); }
			set	{ SetValue((int)CampaignItemFieldIndex.CampaignId, value, true); }
		}

		/// <summary> The CampaignItemId property of the Entity CampaignItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "campaign_items"."campaign_item_id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 CampaignItemId
		{
			get { return (System.Int32)GetValue((int)CampaignItemFieldIndex.CampaignItemId, true); }
			set	{ SetValue((int)CampaignItemFieldIndex.CampaignItemId, value, true); }
		}

		/// <summary> The DateAdded property of the Entity CampaignItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "campaign_items"."date_added"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DateAdded
		{
			get { return (Nullable<System.DateTime>)GetValue((int)CampaignItemFieldIndex.DateAdded, false); }
			set	{ SetValue((int)CampaignItemFieldIndex.DateAdded, value, true); }
		}

		/// <summary> The EndDate property of the Entity CampaignItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "campaign_items"."end_date"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> EndDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)CampaignItemFieldIndex.EndDate, false); }
			set	{ SetValue((int)CampaignItemFieldIndex.EndDate, value, true); }
		}

		/// <summary> The ProductId property of the Entity CampaignItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "campaign_items"."product_id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ProductId
		{
			get { return (System.Int32)GetValue((int)CampaignItemFieldIndex.ProductId, true); }
			set	{ SetValue((int)CampaignItemFieldIndex.ProductId, value, true); }
		}

		/// <summary> The StartDate property of the Entity CampaignItem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "campaign_items"."start_date"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> StartDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)CampaignItemFieldIndex.StartDate, false); }
			set	{ SetValue((int)CampaignItemFieldIndex.StartDate, value, true); }
		}


		/// <summary> Gets / sets related entity of type 'CampaignEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCampaign()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual CampaignEntity Campaign
		{
			get	{ return GetSingleCampaign(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncCampaign(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "CampaignItems", "Campaign", _campaign, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Campaign. When set to true, Campaign is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Campaign is accessed. You can always execute a forced fetch by calling GetSingleCampaign(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCampaign
		{
			get	{ return _alwaysFetchCampaign; }
			set	{ _alwaysFetchCampaign = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Campaign already has been fetched. Setting this property to false when Campaign has been fetched
		/// will set Campaign to null as well. Setting this property to true while Campaign hasn't been fetched disables lazy loading for Campaign</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCampaign
		{
			get { return _alreadyFetchedCampaign;}
			set 
			{
				if(_alreadyFetchedCampaign && !value)
				{
					this.Campaign = null;
				}
				_alreadyFetchedCampaign = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Campaign is not found
		/// in the database. When set to true, Campaign will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool CampaignReturnsNewIfNotFound
		{
			get	{ return _campaignReturnsNewIfNotFound; }
			set { _campaignReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'ProductEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProduct()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ProductEntity Product
		{
			get	{ return GetSingleProduct(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncProduct(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "CampaignItems", "Product", _product, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Product. When set to true, Product is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Product is accessed. You can always execute a forced fetch by calling GetSingleProduct(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchProduct
		{
			get	{ return _alwaysFetchProduct; }
			set	{ _alwaysFetchProduct = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Product already has been fetched. Setting this property to false when Product has been fetched
		/// will set Product to null as well. Setting this property to true while Product hasn't been fetched disables lazy loading for Product</summary>
		[Browsable(false)]
		public bool AlreadyFetchedProduct
		{
			get { return _alreadyFetchedProduct;}
			set 
			{
				if(_alreadyFetchedProduct && !value)
				{
					this.Product = null;
				}
				_alreadyFetchedProduct = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Product is not found
		/// in the database. When set to true, Product will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool ProductReturnsNewIfNotFound
		{
			get	{ return _productReturnsNewIfNotFound; }
			set { _productReturnsNewIfNotFound = value; }	
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
			get { return (int)Mecca.CMT.DAL.EntityType.CampaignItemEntity; }
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
