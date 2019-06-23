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

	/// <summary>Entity class which represents the entity 'CampaignOwner'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class CampaignOwnerEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private CampaignEntity _campaign;
		private bool	_alwaysFetchCampaign, _alreadyFetchedCampaign, _campaignReturnsNewIfNotFound;

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
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CampaignOwnerEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public CampaignOwnerEntity() :base("CampaignOwnerEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="campaignOwnerId">PK value for CampaignOwner which data should be fetched into this CampaignOwner object</param>
		public CampaignOwnerEntity(System.Int32 campaignOwnerId):base("CampaignOwnerEntity")
		{
			InitClassFetch(campaignOwnerId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="campaignOwnerId">PK value for CampaignOwner which data should be fetched into this CampaignOwner object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public CampaignOwnerEntity(System.Int32 campaignOwnerId, IPrefetchPath prefetchPathToUse):base("CampaignOwnerEntity")
		{
			InitClassFetch(campaignOwnerId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="campaignOwnerId">PK value for CampaignOwner which data should be fetched into this CampaignOwner object</param>
		/// <param name="validator">The custom validator object for this CampaignOwnerEntity</param>
		public CampaignOwnerEntity(System.Int32 campaignOwnerId, IValidator validator):base("CampaignOwnerEntity")
		{
			InitClassFetch(campaignOwnerId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CampaignOwnerEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_campaign = (CampaignEntity)info.GetValue("_campaign", typeof(CampaignEntity));
			if(_campaign!=null)
			{
				_campaign.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_campaignReturnsNewIfNotFound = info.GetBoolean("_campaignReturnsNewIfNotFound");
			_alwaysFetchCampaign = info.GetBoolean("_alwaysFetchCampaign");
			_alreadyFetchedCampaign = info.GetBoolean("_alreadyFetchedCampaign");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((CampaignOwnerFieldIndex)fieldIndex)
			{
				case CampaignOwnerFieldIndex.CampaignId:
					DesetupSyncCampaign(true, false);
					_alreadyFetchedCampaign = false;
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
		/// <param name="owner">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public bool FetchUsingUCCampaignIdOwner(System.Int32 campaignId, System.String owner)
		{
			return FetchUsingUCCampaignIdOwner( campaignId,  owner, null, null, null);
		}

		/// <summary> Method which will try to fetch the contents for this entity using a unique constraint. </summary>
		/// <remarks>All contents of the entity is lost.</remarks>
		/// <param name="campaignId">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="owner">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public bool FetchUsingUCCampaignIdOwner(System.Int32 campaignId, System.String owner, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingUCCampaignIdOwner( campaignId,  owner, prefetchPathToUse, null, null);
		}
	
		/// <summary> Method which will try to fetch the contents for this entity using a unique constraint. </summary>
		/// <remarks>All contents of the entity is lost.</remarks>
		/// <param name="campaignId">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="owner">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public bool FetchUsingUCCampaignIdOwner(System.Int32 campaignId, System.String owner, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingUCCampaignIdOwner( campaignId,  owner, prefetchPathToUse, contextToUse, null);
		}
	
		/// <summary> Method which will try to fetch the contents for this entity using a unique constraint. </summary>
		/// <remarks>All contents of the entity is lost.</remarks>
		/// <param name="campaignId">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="owner">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public bool FetchUsingUCCampaignIdOwner(System.Int32 campaignId, System.String owner, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				((CampaignOwnerDAO)CreateDAOInstance()).FetchCampaignOwnerUsingUCCampaignIdOwner(this, this.Transaction, campaignId, owner, prefetchPathToUse, contextToUse, excludedIncludedFields);
				return (this.Fields.State == EntityState.Fetched);
			}
			finally
			{
				OnFetchComplete();
			}
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="campaignOwnerId">PK value for CampaignOwner which data should be fetched into this CampaignOwner object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 campaignOwnerId)
		{
			return FetchUsingPK(campaignOwnerId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="campaignOwnerId">PK value for CampaignOwner which data should be fetched into this CampaignOwner object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 campaignOwnerId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(campaignOwnerId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="campaignOwnerId">PK value for CampaignOwner which data should be fetched into this CampaignOwner object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 campaignOwnerId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(campaignOwnerId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="campaignOwnerId">PK value for CampaignOwner which data should be fetched into this CampaignOwner object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 campaignOwnerId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(campaignOwnerId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.CampaignOwnerId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new CampaignOwnerRelations().GetAllRelations();
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


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Campaign", _campaign);
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
		/// <param name="campaignOwnerId">PK value for CampaignOwner which data should be fetched into this CampaignOwner object</param>
		/// <param name="validator">The validator object for this CampaignOwnerEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 campaignOwnerId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(campaignOwnerId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_campaignReturnsNewIfNotFound = false;
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
			_fieldsCustomProperties.Add("CampaignOwnerId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Owner", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _campaign</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCampaign(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _campaign, new PropertyChangedEventHandler( OnCampaignPropertyChanged ), "Campaign", Mecca.CMT.DAL.RelationClasses.StaticCampaignOwnerRelations.CampaignEntityUsingCampaignIdStatic, true, signalRelatedEntity, "CampaignOwners", resetFKFields, new int[] { (int)CampaignOwnerFieldIndex.CampaignId } );		
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
				this.PerformSetupSyncRelatedEntity( _campaign, new PropertyChangedEventHandler( OnCampaignPropertyChanged ), "Campaign", Mecca.CMT.DAL.RelationClasses.StaticCampaignOwnerRelations.CampaignEntityUsingCampaignIdStatic, true, ref _alreadyFetchedCampaign, new string[] {  } );
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

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="campaignOwnerId">PK value for CampaignOwner which data should be fetched into this CampaignOwner object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 campaignOwnerId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)CampaignOwnerFieldIndex.CampaignOwnerId].ForcedCurrentValueWrite(campaignOwnerId);
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
			return DAOFactory.CreateCampaignOwnerDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new CampaignOwnerEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static CampaignOwnerRelations Relations
		{
			get	{ return new CampaignOwnerRelations(); }
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
			get	{ return new PrefetchPathElement(new Mecca.CMT.DAL.CollectionClasses.CampaignCollection(), (IEntityRelation)GetRelationsForField("Campaign")[0], (int)Mecca.CMT.DAL.EntityType.CampaignOwnerEntity, (int)Mecca.CMT.DAL.EntityType.CampaignEntity, 0, null, null, null, "Campaign", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The CampaignId property of the Entity CampaignOwner<br/><br/></summary>
		/// <remarks>Mapped on  table field: "campaign_owners"."campaign_id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 CampaignId
		{
			get { return (System.Int32)GetValue((int)CampaignOwnerFieldIndex.CampaignId, true); }
			set	{ SetValue((int)CampaignOwnerFieldIndex.CampaignId, value, true); }
		}

		/// <summary> The CampaignOwnerId property of the Entity CampaignOwner<br/><br/></summary>
		/// <remarks>Mapped on  table field: "campaign_owners"."campaign_owner_id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 CampaignOwnerId
		{
			get { return (System.Int32)GetValue((int)CampaignOwnerFieldIndex.CampaignOwnerId, true); }
			set	{ SetValue((int)CampaignOwnerFieldIndex.CampaignOwnerId, value, true); }
		}

		/// <summary> The Owner property of the Entity CampaignOwner<br/><br/></summary>
		/// <remarks>Mapped on  table field: "campaign_owners"."owner"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 200<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Owner
		{
			get { return (System.String)GetValue((int)CampaignOwnerFieldIndex.Owner, true); }
			set	{ SetValue((int)CampaignOwnerFieldIndex.Owner, value, true); }
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
					SetSingleRelatedEntityNavigator(value, "CampaignOwners", "Campaign", _campaign, true); 
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
			get { return (int)Mecca.CMT.DAL.EntityType.CampaignOwnerEntity; }
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
