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

	/// <summary>Entity class which represents the entity 'Channel'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class ChannelEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private Mecca.CMT.DAL.CollectionClasses.ChannelCustomerCollection	_channelCustomers;
		private bool	_alwaysFetchChannelCustomers, _alreadyFetchedChannelCustomers;
		private Mecca.CMT.DAL.CollectionClasses.ChannelItemCollection	_channelItems;
		private bool	_alwaysFetchChannelItems, _alreadyFetchedChannelItems;
		private Mecca.CMT.DAL.CollectionClasses.ChannelOwnerCollection	_channelOwners;
		private bool	_alwaysFetchChannelOwners, _alreadyFetchedChannelOwners;
		private CampaignEntity _campaign;
		private bool	_alwaysFetchCampaign, _alreadyFetchedCampaign, _campaignReturnsNewIfNotFound;
		private ChannelTypeEntity _channelType;
		private bool	_alwaysFetchChannelType, _alreadyFetchedChannelType, _channelTypeReturnsNewIfNotFound;
		private RedemptionCodeEntity _redemptionCode;
		private bool	_alwaysFetchRedemptionCode, _alreadyFetchedRedemptionCode, _redemptionCodeReturnsNewIfNotFound;

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
			/// <summary>Member name ChannelType</summary>
			public static readonly string ChannelType = "ChannelType";
			/// <summary>Member name RedemptionCode</summary>
			public static readonly string RedemptionCode = "RedemptionCode";
			/// <summary>Member name ChannelCustomers</summary>
			public static readonly string ChannelCustomers = "ChannelCustomers";
			/// <summary>Member name ChannelItems</summary>
			public static readonly string ChannelItems = "ChannelItems";
			/// <summary>Member name ChannelOwners</summary>
			public static readonly string ChannelOwners = "ChannelOwners";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ChannelEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ChannelEntity() :base("ChannelEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="channelId">PK value for Channel which data should be fetched into this Channel object</param>
		public ChannelEntity(System.Int32 channelId):base("ChannelEntity")
		{
			InitClassFetch(channelId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="channelId">PK value for Channel which data should be fetched into this Channel object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ChannelEntity(System.Int32 channelId, IPrefetchPath prefetchPathToUse):base("ChannelEntity")
		{
			InitClassFetch(channelId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="channelId">PK value for Channel which data should be fetched into this Channel object</param>
		/// <param name="validator">The custom validator object for this ChannelEntity</param>
		public ChannelEntity(System.Int32 channelId, IValidator validator):base("ChannelEntity")
		{
			InitClassFetch(channelId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ChannelEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_channelCustomers = (Mecca.CMT.DAL.CollectionClasses.ChannelCustomerCollection)info.GetValue("_channelCustomers", typeof(Mecca.CMT.DAL.CollectionClasses.ChannelCustomerCollection));
			_alwaysFetchChannelCustomers = info.GetBoolean("_alwaysFetchChannelCustomers");
			_alreadyFetchedChannelCustomers = info.GetBoolean("_alreadyFetchedChannelCustomers");

			_channelItems = (Mecca.CMT.DAL.CollectionClasses.ChannelItemCollection)info.GetValue("_channelItems", typeof(Mecca.CMT.DAL.CollectionClasses.ChannelItemCollection));
			_alwaysFetchChannelItems = info.GetBoolean("_alwaysFetchChannelItems");
			_alreadyFetchedChannelItems = info.GetBoolean("_alreadyFetchedChannelItems");

			_channelOwners = (Mecca.CMT.DAL.CollectionClasses.ChannelOwnerCollection)info.GetValue("_channelOwners", typeof(Mecca.CMT.DAL.CollectionClasses.ChannelOwnerCollection));
			_alwaysFetchChannelOwners = info.GetBoolean("_alwaysFetchChannelOwners");
			_alreadyFetchedChannelOwners = info.GetBoolean("_alreadyFetchedChannelOwners");
			_campaign = (CampaignEntity)info.GetValue("_campaign", typeof(CampaignEntity));
			if(_campaign!=null)
			{
				_campaign.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_campaignReturnsNewIfNotFound = info.GetBoolean("_campaignReturnsNewIfNotFound");
			_alwaysFetchCampaign = info.GetBoolean("_alwaysFetchCampaign");
			_alreadyFetchedCampaign = info.GetBoolean("_alreadyFetchedCampaign");

			_channelType = (ChannelTypeEntity)info.GetValue("_channelType", typeof(ChannelTypeEntity));
			if(_channelType!=null)
			{
				_channelType.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_channelTypeReturnsNewIfNotFound = info.GetBoolean("_channelTypeReturnsNewIfNotFound");
			_alwaysFetchChannelType = info.GetBoolean("_alwaysFetchChannelType");
			_alreadyFetchedChannelType = info.GetBoolean("_alreadyFetchedChannelType");

			_redemptionCode = (RedemptionCodeEntity)info.GetValue("_redemptionCode", typeof(RedemptionCodeEntity));
			if(_redemptionCode!=null)
			{
				_redemptionCode.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_redemptionCodeReturnsNewIfNotFound = info.GetBoolean("_redemptionCodeReturnsNewIfNotFound");
			_alwaysFetchRedemptionCode = info.GetBoolean("_alwaysFetchRedemptionCode");
			_alreadyFetchedRedemptionCode = info.GetBoolean("_alreadyFetchedRedemptionCode");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((ChannelFieldIndex)fieldIndex)
			{
				case ChannelFieldIndex.CampaignId:
					DesetupSyncCampaign(true, false);
					_alreadyFetchedCampaign = false;
					break;
				case ChannelFieldIndex.ChannelTypeId:
					DesetupSyncChannelType(true, false);
					_alreadyFetchedChannelType = false;
					break;
				case ChannelFieldIndex.RedemptionCodeId:
					DesetupSyncRedemptionCode(true, false);
					_alreadyFetchedRedemptionCode = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedChannelCustomers = (_channelCustomers.Count > 0);
			_alreadyFetchedChannelItems = (_channelItems.Count > 0);
			_alreadyFetchedChannelOwners = (_channelOwners.Count > 0);
			_alreadyFetchedCampaign = (_campaign != null);
			_alreadyFetchedChannelType = (_channelType != null);
			_alreadyFetchedRedemptionCode = (_redemptionCode != null);
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
				case "ChannelType":
					toReturn.Add(Relations.ChannelTypeEntityUsingChannelTypeId);
					break;
				case "RedemptionCode":
					toReturn.Add(Relations.RedemptionCodeEntityUsingRedemptionCodeId);
					break;
				case "ChannelCustomers":
					toReturn.Add(Relations.ChannelCustomerEntityUsingChannelId);
					break;
				case "ChannelItems":
					toReturn.Add(Relations.ChannelItemEntityUsingChannelId);
					break;
				case "ChannelOwners":
					toReturn.Add(Relations.ChannelOwnerEntityUsingChannelId);
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
			info.AddValue("_channelCustomers", (!this.MarkedForDeletion?_channelCustomers:null));
			info.AddValue("_alwaysFetchChannelCustomers", _alwaysFetchChannelCustomers);
			info.AddValue("_alreadyFetchedChannelCustomers", _alreadyFetchedChannelCustomers);
			info.AddValue("_channelItems", (!this.MarkedForDeletion?_channelItems:null));
			info.AddValue("_alwaysFetchChannelItems", _alwaysFetchChannelItems);
			info.AddValue("_alreadyFetchedChannelItems", _alreadyFetchedChannelItems);
			info.AddValue("_channelOwners", (!this.MarkedForDeletion?_channelOwners:null));
			info.AddValue("_alwaysFetchChannelOwners", _alwaysFetchChannelOwners);
			info.AddValue("_alreadyFetchedChannelOwners", _alreadyFetchedChannelOwners);
			info.AddValue("_campaign", (!this.MarkedForDeletion?_campaign:null));
			info.AddValue("_campaignReturnsNewIfNotFound", _campaignReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCampaign", _alwaysFetchCampaign);
			info.AddValue("_alreadyFetchedCampaign", _alreadyFetchedCampaign);
			info.AddValue("_channelType", (!this.MarkedForDeletion?_channelType:null));
			info.AddValue("_channelTypeReturnsNewIfNotFound", _channelTypeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchChannelType", _alwaysFetchChannelType);
			info.AddValue("_alreadyFetchedChannelType", _alreadyFetchedChannelType);
			info.AddValue("_redemptionCode", (!this.MarkedForDeletion?_redemptionCode:null));
			info.AddValue("_redemptionCodeReturnsNewIfNotFound", _redemptionCodeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchRedemptionCode", _alwaysFetchRedemptionCode);
			info.AddValue("_alreadyFetchedRedemptionCode", _alreadyFetchedRedemptionCode);

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
				case "ChannelType":
					_alreadyFetchedChannelType = true;
					this.ChannelType = (ChannelTypeEntity)entity;
					break;
				case "RedemptionCode":
					_alreadyFetchedRedemptionCode = true;
					this.RedemptionCode = (RedemptionCodeEntity)entity;
					break;
				case "ChannelCustomers":
					_alreadyFetchedChannelCustomers = true;
					if(entity!=null)
					{
						this.ChannelCustomers.Add((ChannelCustomerEntity)entity);
					}
					break;
				case "ChannelItems":
					_alreadyFetchedChannelItems = true;
					if(entity!=null)
					{
						this.ChannelItems.Add((ChannelItemEntity)entity);
					}
					break;
				case "ChannelOwners":
					_alreadyFetchedChannelOwners = true;
					if(entity!=null)
					{
						this.ChannelOwners.Add((ChannelOwnerEntity)entity);
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
				case "Campaign":
					SetupSyncCampaign(relatedEntity);
					break;
				case "ChannelType":
					SetupSyncChannelType(relatedEntity);
					break;
				case "RedemptionCode":
					SetupSyncRedemptionCode(relatedEntity);
					break;
				case "ChannelCustomers":
					_channelCustomers.Add((ChannelCustomerEntity)relatedEntity);
					break;
				case "ChannelItems":
					_channelItems.Add((ChannelItemEntity)relatedEntity);
					break;
				case "ChannelOwners":
					_channelOwners.Add((ChannelOwnerEntity)relatedEntity);
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
				case "ChannelType":
					DesetupSyncChannelType(false, true);
					break;
				case "RedemptionCode":
					DesetupSyncRedemptionCode(false, true);
					break;
				case "ChannelCustomers":
					this.PerformRelatedEntityRemoval(_channelCustomers, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ChannelItems":
					this.PerformRelatedEntityRemoval(_channelItems, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ChannelOwners":
					this.PerformRelatedEntityRemoval(_channelOwners, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_channelType!=null)
			{
				toReturn.Add(_channelType);
			}
			if(_redemptionCode!=null)
			{
				toReturn.Add(_redemptionCode);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_channelCustomers);
			toReturn.Add(_channelItems);
			toReturn.Add(_channelOwners);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="channelId">PK value for Channel which data should be fetched into this Channel object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 channelId)
		{
			return FetchUsingPK(channelId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="channelId">PK value for Channel which data should be fetched into this Channel object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 channelId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(channelId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="channelId">PK value for Channel which data should be fetched into this Channel object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 channelId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(channelId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="channelId">PK value for Channel which data should be fetched into this Channel object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 channelId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(channelId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.ChannelId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new ChannelRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'ChannelCustomerEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ChannelCustomerEntity'</returns>
		public Mecca.CMT.DAL.CollectionClasses.ChannelCustomerCollection GetMultiChannelCustomers(bool forceFetch)
		{
			return GetMultiChannelCustomers(forceFetch, _channelCustomers.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ChannelCustomerEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ChannelCustomerEntity'</returns>
		public Mecca.CMT.DAL.CollectionClasses.ChannelCustomerCollection GetMultiChannelCustomers(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiChannelCustomers(forceFetch, _channelCustomers.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ChannelCustomerEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Mecca.CMT.DAL.CollectionClasses.ChannelCustomerCollection GetMultiChannelCustomers(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiChannelCustomers(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ChannelCustomerEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Mecca.CMT.DAL.CollectionClasses.ChannelCustomerCollection GetMultiChannelCustomers(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
			if( ( (!_alreadyFetchedChannelCustomers && EntityBase.EnableLazyLoading) || forceFetch || _alwaysFetchChannelCustomers) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_channelCustomers);
				_channelCustomers.SuppressClearInGetMulti=!forceFetch;
				_channelCustomers.EntityFactoryToUse = entityFactoryToUse;
				_channelCustomers.GetMultiManyToOne(this, filter);
				_channelCustomers.SuppressClearInGetMulti=false;
				_alreadyFetchedChannelCustomers = true;
			}
			return _channelCustomers;
		}

		/// <summary> Sets the collection parameters for the collection for 'ChannelCustomers'. These settings will be taken into account
		/// when the property ChannelCustomers is requested or GetMultiChannelCustomers is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersChannelCustomers(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_channelCustomers.SortClauses=sortClauses;
			_channelCustomers.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_channelItems.GetMultiManyToOne(this, null, filter);
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

		/// <summary> Retrieves all related entities of type 'ChannelOwnerEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ChannelOwnerEntity'</returns>
		public Mecca.CMT.DAL.CollectionClasses.ChannelOwnerCollection GetMultiChannelOwners(bool forceFetch)
		{
			return GetMultiChannelOwners(forceFetch, _channelOwners.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ChannelOwnerEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ChannelOwnerEntity'</returns>
		public Mecca.CMT.DAL.CollectionClasses.ChannelOwnerCollection GetMultiChannelOwners(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiChannelOwners(forceFetch, _channelOwners.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ChannelOwnerEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Mecca.CMT.DAL.CollectionClasses.ChannelOwnerCollection GetMultiChannelOwners(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiChannelOwners(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ChannelOwnerEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Mecca.CMT.DAL.CollectionClasses.ChannelOwnerCollection GetMultiChannelOwners(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
			if( ( (!_alreadyFetchedChannelOwners && EntityBase.EnableLazyLoading) || forceFetch || _alwaysFetchChannelOwners) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_channelOwners);
				_channelOwners.SuppressClearInGetMulti=!forceFetch;
				_channelOwners.EntityFactoryToUse = entityFactoryToUse;
				_channelOwners.GetMultiManyToOne(null, this, filter);
				_channelOwners.SuppressClearInGetMulti=false;
				_alreadyFetchedChannelOwners = true;
			}
			return _channelOwners;
		}

		/// <summary> Sets the collection parameters for the collection for 'ChannelOwners'. These settings will be taken into account
		/// when the property ChannelOwners is requested or GetMultiChannelOwners is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersChannelOwners(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_channelOwners.SortClauses=sortClauses;
			_channelOwners.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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


		/// <summary> Retrieves the related entity of type 'ChannelTypeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ChannelTypeEntity' which is related to this entity.</returns>
		public ChannelTypeEntity GetSingleChannelType()
		{
			return GetSingleChannelType(false);
		}

		/// <summary> Retrieves the related entity of type 'ChannelTypeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ChannelTypeEntity' which is related to this entity.</returns>
		public virtual ChannelTypeEntity GetSingleChannelType(bool forceFetch)
		{
			if((!_alreadyFetchedChannelType || forceFetch || _alwaysFetchChannelType) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.ChannelTypeEntityUsingChannelTypeId) && (EntityBase.EnableLazyLoading || forceFetch);
				ChannelTypeEntity newEntity = new ChannelTypeEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.ChannelTypeId);
				}
				if(fetchResult)
				{
					newEntity = (ChannelTypeEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_channelTypeReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.ChannelType = newEntity;
				_alreadyFetchedChannelType = fetchResult;
			}
			return _channelType;
		}


		/// <summary> Retrieves the related entity of type 'RedemptionCodeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'RedemptionCodeEntity' which is related to this entity.</returns>
		public RedemptionCodeEntity GetSingleRedemptionCode()
		{
			return GetSingleRedemptionCode(false);
		}

		/// <summary> Retrieves the related entity of type 'RedemptionCodeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'RedemptionCodeEntity' which is related to this entity.</returns>
		public virtual RedemptionCodeEntity GetSingleRedemptionCode(bool forceFetch)
		{
			if((!_alreadyFetchedRedemptionCode || forceFetch || _alwaysFetchRedemptionCode) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.RedemptionCodeEntityUsingRedemptionCodeId) && (EntityBase.EnableLazyLoading || forceFetch);
				RedemptionCodeEntity newEntity = new RedemptionCodeEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.RedemptionCodeId);
				}
				if(fetchResult)
				{
					newEntity = (RedemptionCodeEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_redemptionCodeReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.RedemptionCode = newEntity;
				_alreadyFetchedRedemptionCode = fetchResult;
			}
			return _redemptionCode;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Campaign", _campaign);
			toReturn.Add("ChannelType", _channelType);
			toReturn.Add("RedemptionCode", _redemptionCode);
			toReturn.Add("ChannelCustomers", _channelCustomers);
			toReturn.Add("ChannelItems", _channelItems);
			toReturn.Add("ChannelOwners", _channelOwners);
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
		/// <param name="channelId">PK value for Channel which data should be fetched into this Channel object</param>
		/// <param name="validator">The validator object for this ChannelEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 channelId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(channelId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_channelCustomers = new Mecca.CMT.DAL.CollectionClasses.ChannelCustomerCollection();
			_channelCustomers.SetContainingEntityInfo(this, "Channel");

			_channelItems = new Mecca.CMT.DAL.CollectionClasses.ChannelItemCollection();
			_channelItems.SetContainingEntityInfo(this, "Channel");

			_channelOwners = new Mecca.CMT.DAL.CollectionClasses.ChannelOwnerCollection();
			_channelOwners.SetContainingEntityInfo(this, "Channel");
			_campaignReturnsNewIfNotFound = false;
			_channelTypeReturnsNewIfNotFound = false;
			_redemptionCodeReturnsNewIfNotFound = false;
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
			_fieldsCustomProperties.Add("ChannelCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ChannelId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ChannelName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ChannelTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CreatedBy", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Description", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("EndDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsLocked", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("RedemptionCodeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("StartDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("StoreOptionId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _campaign</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCampaign(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _campaign, new PropertyChangedEventHandler( OnCampaignPropertyChanged ), "Campaign", Mecca.CMT.DAL.RelationClasses.StaticChannelRelations.CampaignEntityUsingCampaignIdStatic, true, signalRelatedEntity, "Channels", resetFKFields, new int[] { (int)ChannelFieldIndex.CampaignId } );		
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
				this.PerformSetupSyncRelatedEntity( _campaign, new PropertyChangedEventHandler( OnCampaignPropertyChanged ), "Campaign", Mecca.CMT.DAL.RelationClasses.StaticChannelRelations.CampaignEntityUsingCampaignIdStatic, true, ref _alreadyFetchedCampaign, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _channelType</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncChannelType(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _channelType, new PropertyChangedEventHandler( OnChannelTypePropertyChanged ), "ChannelType", Mecca.CMT.DAL.RelationClasses.StaticChannelRelations.ChannelTypeEntityUsingChannelTypeIdStatic, true, signalRelatedEntity, "Channels", resetFKFields, new int[] { (int)ChannelFieldIndex.ChannelTypeId } );		
			_channelType = null;
		}
		
		/// <summary> setups the sync logic for member _channelType</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncChannelType(IEntityCore relatedEntity)
		{
			if(_channelType!=relatedEntity)
			{		
				DesetupSyncChannelType(true, true);
				_channelType = (ChannelTypeEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _channelType, new PropertyChangedEventHandler( OnChannelTypePropertyChanged ), "ChannelType", Mecca.CMT.DAL.RelationClasses.StaticChannelRelations.ChannelTypeEntityUsingChannelTypeIdStatic, true, ref _alreadyFetchedChannelType, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnChannelTypePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _redemptionCode</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncRedemptionCode(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _redemptionCode, new PropertyChangedEventHandler( OnRedemptionCodePropertyChanged ), "RedemptionCode", Mecca.CMT.DAL.RelationClasses.StaticChannelRelations.RedemptionCodeEntityUsingRedemptionCodeIdStatic, true, signalRelatedEntity, "Channels", resetFKFields, new int[] { (int)ChannelFieldIndex.RedemptionCodeId } );		
			_redemptionCode = null;
		}
		
		/// <summary> setups the sync logic for member _redemptionCode</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncRedemptionCode(IEntityCore relatedEntity)
		{
			if(_redemptionCode!=relatedEntity)
			{		
				DesetupSyncRedemptionCode(true, true);
				_redemptionCode = (RedemptionCodeEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _redemptionCode, new PropertyChangedEventHandler( OnRedemptionCodePropertyChanged ), "RedemptionCode", Mecca.CMT.DAL.RelationClasses.StaticChannelRelations.RedemptionCodeEntityUsingRedemptionCodeIdStatic, true, ref _alreadyFetchedRedemptionCode, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnRedemptionCodePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="channelId">PK value for Channel which data should be fetched into this Channel object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 channelId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)ChannelFieldIndex.ChannelId].ForcedCurrentValueWrite(channelId);
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
			return DAOFactory.CreateChannelDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ChannelEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ChannelRelations Relations
		{
			get	{ return new ChannelRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ChannelCustomer' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathChannelCustomers
		{
			get { return new PrefetchPathElement(new Mecca.CMT.DAL.CollectionClasses.ChannelCustomerCollection(), (IEntityRelation)GetRelationsForField("ChannelCustomers")[0], (int)Mecca.CMT.DAL.EntityType.ChannelEntity, (int)Mecca.CMT.DAL.EntityType.ChannelCustomerEntity, 0, null, null, null, "ChannelCustomers", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ChannelItem' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathChannelItems
		{
			get { return new PrefetchPathElement(new Mecca.CMT.DAL.CollectionClasses.ChannelItemCollection(), (IEntityRelation)GetRelationsForField("ChannelItems")[0], (int)Mecca.CMT.DAL.EntityType.ChannelEntity, (int)Mecca.CMT.DAL.EntityType.ChannelItemEntity, 0, null, null, null, "ChannelItems", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ChannelOwner' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathChannelOwners
		{
			get { return new PrefetchPathElement(new Mecca.CMT.DAL.CollectionClasses.ChannelOwnerCollection(), (IEntityRelation)GetRelationsForField("ChannelOwners")[0], (int)Mecca.CMT.DAL.EntityType.ChannelEntity, (int)Mecca.CMT.DAL.EntityType.ChannelOwnerEntity, 0, null, null, null, "ChannelOwners", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Campaign'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCampaign
		{
			get	{ return new PrefetchPathElement(new Mecca.CMT.DAL.CollectionClasses.CampaignCollection(), (IEntityRelation)GetRelationsForField("Campaign")[0], (int)Mecca.CMT.DAL.EntityType.ChannelEntity, (int)Mecca.CMT.DAL.EntityType.CampaignEntity, 0, null, null, null, "Campaign", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ChannelType'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathChannelType
		{
			get	{ return new PrefetchPathElement(new Mecca.CMT.DAL.CollectionClasses.ChannelTypeCollection(), (IEntityRelation)GetRelationsForField("ChannelType")[0], (int)Mecca.CMT.DAL.EntityType.ChannelEntity, (int)Mecca.CMT.DAL.EntityType.ChannelTypeEntity, 0, null, null, null, "ChannelType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RedemptionCode'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRedemptionCode
		{
			get	{ return new PrefetchPathElement(new Mecca.CMT.DAL.CollectionClasses.RedemptionCodeCollection(), (IEntityRelation)GetRelationsForField("RedemptionCode")[0], (int)Mecca.CMT.DAL.EntityType.ChannelEntity, (int)Mecca.CMT.DAL.EntityType.RedemptionCodeEntity, 0, null, null, null, "RedemptionCode", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The CampaignId property of the Entity Channel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "channels"."campaign_id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 CampaignId
		{
			get { return (System.Int32)GetValue((int)ChannelFieldIndex.CampaignId, true); }
			set	{ SetValue((int)ChannelFieldIndex.CampaignId, value, true); }
		}

		/// <summary> The ChannelCode property of the Entity Channel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "channels"."channel_code"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ChannelCode
		{
			get { return (System.String)GetValue((int)ChannelFieldIndex.ChannelCode, true); }
			set	{ SetValue((int)ChannelFieldIndex.ChannelCode, value, true); }
		}

		/// <summary> The ChannelId property of the Entity Channel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "channels"."channel_id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ChannelId
		{
			get { return (System.Int32)GetValue((int)ChannelFieldIndex.ChannelId, true); }
			set	{ SetValue((int)ChannelFieldIndex.ChannelId, value, true); }
		}

		/// <summary> The ChannelName property of the Entity Channel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "channels"."channel_name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ChannelName
		{
			get { return (System.String)GetValue((int)ChannelFieldIndex.ChannelName, true); }
			set	{ SetValue((int)ChannelFieldIndex.ChannelName, value, true); }
		}

		/// <summary> The ChannelTypeId property of the Entity Channel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "channels"."channel_type_id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ChannelTypeId
		{
			get { return (System.Int32)GetValue((int)ChannelFieldIndex.ChannelTypeId, true); }
			set	{ SetValue((int)ChannelFieldIndex.ChannelTypeId, value, true); }
		}

		/// <summary> The CreatedBy property of the Entity Channel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "channels"."created_by"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 200<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String CreatedBy
		{
			get { return (System.String)GetValue((int)ChannelFieldIndex.CreatedBy, true); }
			set	{ SetValue((int)ChannelFieldIndex.CreatedBy, value, true); }
		}

		/// <summary> The Description property of the Entity Channel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "channels"."description"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Description
		{
			get { return (System.String)GetValue((int)ChannelFieldIndex.Description, true); }
			set	{ SetValue((int)ChannelFieldIndex.Description, value, true); }
		}

		/// <summary> The EndDate property of the Entity Channel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "channels"."end_date"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime EndDate
		{
			get { return (System.DateTime)GetValue((int)ChannelFieldIndex.EndDate, true); }
			set	{ SetValue((int)ChannelFieldIndex.EndDate, value, true); }
		}

		/// <summary> The IsLocked property of the Entity Channel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "channels"."is_locked"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 IsLocked
		{
			get { return (System.Int32)GetValue((int)ChannelFieldIndex.IsLocked, true); }
			set	{ SetValue((int)ChannelFieldIndex.IsLocked, value, true); }
		}

		/// <summary> The RedemptionCodeId property of the Entity Channel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "channels"."redemption_code_id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 RedemptionCodeId
		{
			get { return (System.Int32)GetValue((int)ChannelFieldIndex.RedemptionCodeId, true); }
			set	{ SetValue((int)ChannelFieldIndex.RedemptionCodeId, value, true); }
		}

		/// <summary> The StartDate property of the Entity Channel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "channels"."start_date"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime StartDate
		{
			get { return (System.DateTime)GetValue((int)ChannelFieldIndex.StartDate, true); }
			set	{ SetValue((int)ChannelFieldIndex.StartDate, value, true); }
		}

		/// <summary> The StoreOptionId property of the Entity Channel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "channels"."store_option_id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 StoreOptionId
		{
			get { return (System.Int32)GetValue((int)ChannelFieldIndex.StoreOptionId, true); }
			set	{ SetValue((int)ChannelFieldIndex.StoreOptionId, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'ChannelCustomerEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiChannelCustomers()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Mecca.CMT.DAL.CollectionClasses.ChannelCustomerCollection ChannelCustomers
		{
			get	{ return GetMultiChannelCustomers(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ChannelCustomers. When set to true, ChannelCustomers is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ChannelCustomers is accessed. You can always execute/ a forced fetch by calling GetMultiChannelCustomers(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchChannelCustomers
		{
			get	{ return _alwaysFetchChannelCustomers; }
			set	{ _alwaysFetchChannelCustomers = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ChannelCustomers already has been fetched. Setting this property to false when ChannelCustomers has been fetched
		/// will clear the ChannelCustomers collection well. Setting this property to true while ChannelCustomers hasn't been fetched disables lazy loading for ChannelCustomers</summary>
		[Browsable(false)]
		public bool AlreadyFetchedChannelCustomers
		{
			get { return _alreadyFetchedChannelCustomers;}
			set 
			{
				if(_alreadyFetchedChannelCustomers && !value && (_channelCustomers != null))
				{
					_channelCustomers.Clear();
				}
				_alreadyFetchedChannelCustomers = value;
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
		/// <summary> Retrieves all related entities of type 'ChannelOwnerEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiChannelOwners()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Mecca.CMT.DAL.CollectionClasses.ChannelOwnerCollection ChannelOwners
		{
			get	{ return GetMultiChannelOwners(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ChannelOwners. When set to true, ChannelOwners is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ChannelOwners is accessed. You can always execute/ a forced fetch by calling GetMultiChannelOwners(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchChannelOwners
		{
			get	{ return _alwaysFetchChannelOwners; }
			set	{ _alwaysFetchChannelOwners = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ChannelOwners already has been fetched. Setting this property to false when ChannelOwners has been fetched
		/// will clear the ChannelOwners collection well. Setting this property to true while ChannelOwners hasn't been fetched disables lazy loading for ChannelOwners</summary>
		[Browsable(false)]
		public bool AlreadyFetchedChannelOwners
		{
			get { return _alreadyFetchedChannelOwners;}
			set 
			{
				if(_alreadyFetchedChannelOwners && !value && (_channelOwners != null))
				{
					_channelOwners.Clear();
				}
				_alreadyFetchedChannelOwners = value;
			}
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
					SetSingleRelatedEntityNavigator(value, "Channels", "Campaign", _campaign, true); 
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

		/// <summary> Gets / sets related entity of type 'ChannelTypeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleChannelType()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ChannelTypeEntity ChannelType
		{
			get	{ return GetSingleChannelType(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncChannelType(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Channels", "ChannelType", _channelType, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ChannelType. When set to true, ChannelType is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ChannelType is accessed. You can always execute a forced fetch by calling GetSingleChannelType(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchChannelType
		{
			get	{ return _alwaysFetchChannelType; }
			set	{ _alwaysFetchChannelType = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ChannelType already has been fetched. Setting this property to false when ChannelType has been fetched
		/// will set ChannelType to null as well. Setting this property to true while ChannelType hasn't been fetched disables lazy loading for ChannelType</summary>
		[Browsable(false)]
		public bool AlreadyFetchedChannelType
		{
			get { return _alreadyFetchedChannelType;}
			set 
			{
				if(_alreadyFetchedChannelType && !value)
				{
					this.ChannelType = null;
				}
				_alreadyFetchedChannelType = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property ChannelType is not found
		/// in the database. When set to true, ChannelType will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool ChannelTypeReturnsNewIfNotFound
		{
			get	{ return _channelTypeReturnsNewIfNotFound; }
			set { _channelTypeReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'RedemptionCodeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleRedemptionCode()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual RedemptionCodeEntity RedemptionCode
		{
			get	{ return GetSingleRedemptionCode(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncRedemptionCode(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Channels", "RedemptionCode", _redemptionCode, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for RedemptionCode. When set to true, RedemptionCode is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time RedemptionCode is accessed. You can always execute a forced fetch by calling GetSingleRedemptionCode(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchRedemptionCode
		{
			get	{ return _alwaysFetchRedemptionCode; }
			set	{ _alwaysFetchRedemptionCode = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property RedemptionCode already has been fetched. Setting this property to false when RedemptionCode has been fetched
		/// will set RedemptionCode to null as well. Setting this property to true while RedemptionCode hasn't been fetched disables lazy loading for RedemptionCode</summary>
		[Browsable(false)]
		public bool AlreadyFetchedRedemptionCode
		{
			get { return _alreadyFetchedRedemptionCode;}
			set 
			{
				if(_alreadyFetchedRedemptionCode && !value)
				{
					this.RedemptionCode = null;
				}
				_alreadyFetchedRedemptionCode = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property RedemptionCode is not found
		/// in the database. When set to true, RedemptionCode will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool RedemptionCodeReturnsNewIfNotFound
		{
			get	{ return _redemptionCodeReturnsNewIfNotFound; }
			set { _redemptionCodeReturnsNewIfNotFound = value; }	
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
			get { return (int)Mecca.CMT.DAL.EntityType.ChannelEntity; }
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
