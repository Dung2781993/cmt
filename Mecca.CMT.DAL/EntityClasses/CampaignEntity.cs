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

	/// <summary>Entity class which represents the entity 'Campaign'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class CampaignEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private Mecca.CMT.DAL.CollectionClasses.CampaignItemCollection	_campaignItems;
		private bool	_alwaysFetchCampaignItems, _alreadyFetchedCampaignItems;
		private Mecca.CMT.DAL.CollectionClasses.CampaignOwnerCollection	_campaignOwners;
		private bool	_alwaysFetchCampaignOwners, _alreadyFetchedCampaignOwners;
		private Mecca.CMT.DAL.CollectionClasses.ChannelCollection	_channels;
		private bool	_alwaysFetchChannels, _alreadyFetchedChannels;
		private Mecca.CMT.DAL.CollectionClasses.ChannelOwnerCollection	_channelOwners;
		private bool	_alwaysFetchChannelOwners, _alreadyFetchedChannelOwners;
		private CampaignTypeEntity _campaignType;
		private bool	_alwaysFetchCampaignType, _alreadyFetchedCampaignType, _campaignTypeReturnsNewIfNotFound;
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
			/// <summary>Member name CampaignType</summary>
			public static readonly string CampaignType = "CampaignType";
			/// <summary>Member name RedemptionCode</summary>
			public static readonly string RedemptionCode = "RedemptionCode";
			/// <summary>Member name CampaignItems</summary>
			public static readonly string CampaignItems = "CampaignItems";
			/// <summary>Member name CampaignOwners</summary>
			public static readonly string CampaignOwners = "CampaignOwners";
			/// <summary>Member name Channels</summary>
			public static readonly string Channels = "Channels";
			/// <summary>Member name ChannelOwners</summary>
			public static readonly string ChannelOwners = "ChannelOwners";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CampaignEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public CampaignEntity() :base("CampaignEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="campaignId">PK value for Campaign which data should be fetched into this Campaign object</param>
		public CampaignEntity(System.Int32 campaignId):base("CampaignEntity")
		{
			InitClassFetch(campaignId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="campaignId">PK value for Campaign which data should be fetched into this Campaign object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public CampaignEntity(System.Int32 campaignId, IPrefetchPath prefetchPathToUse):base("CampaignEntity")
		{
			InitClassFetch(campaignId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="campaignId">PK value for Campaign which data should be fetched into this Campaign object</param>
		/// <param name="validator">The custom validator object for this CampaignEntity</param>
		public CampaignEntity(System.Int32 campaignId, IValidator validator):base("CampaignEntity")
		{
			InitClassFetch(campaignId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CampaignEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_campaignItems = (Mecca.CMT.DAL.CollectionClasses.CampaignItemCollection)info.GetValue("_campaignItems", typeof(Mecca.CMT.DAL.CollectionClasses.CampaignItemCollection));
			_alwaysFetchCampaignItems = info.GetBoolean("_alwaysFetchCampaignItems");
			_alreadyFetchedCampaignItems = info.GetBoolean("_alreadyFetchedCampaignItems");

			_campaignOwners = (Mecca.CMT.DAL.CollectionClasses.CampaignOwnerCollection)info.GetValue("_campaignOwners", typeof(Mecca.CMT.DAL.CollectionClasses.CampaignOwnerCollection));
			_alwaysFetchCampaignOwners = info.GetBoolean("_alwaysFetchCampaignOwners");
			_alreadyFetchedCampaignOwners = info.GetBoolean("_alreadyFetchedCampaignOwners");

			_channels = (Mecca.CMT.DAL.CollectionClasses.ChannelCollection)info.GetValue("_channels", typeof(Mecca.CMT.DAL.CollectionClasses.ChannelCollection));
			_alwaysFetchChannels = info.GetBoolean("_alwaysFetchChannels");
			_alreadyFetchedChannels = info.GetBoolean("_alreadyFetchedChannels");

			_channelOwners = (Mecca.CMT.DAL.CollectionClasses.ChannelOwnerCollection)info.GetValue("_channelOwners", typeof(Mecca.CMT.DAL.CollectionClasses.ChannelOwnerCollection));
			_alwaysFetchChannelOwners = info.GetBoolean("_alwaysFetchChannelOwners");
			_alreadyFetchedChannelOwners = info.GetBoolean("_alreadyFetchedChannelOwners");
			_campaignType = (CampaignTypeEntity)info.GetValue("_campaignType", typeof(CampaignTypeEntity));
			if(_campaignType!=null)
			{
				_campaignType.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_campaignTypeReturnsNewIfNotFound = info.GetBoolean("_campaignTypeReturnsNewIfNotFound");
			_alwaysFetchCampaignType = info.GetBoolean("_alwaysFetchCampaignType");
			_alreadyFetchedCampaignType = info.GetBoolean("_alreadyFetchedCampaignType");

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
			switch((CampaignFieldIndex)fieldIndex)
			{
				case CampaignFieldIndex.CampaignTypeId:
					DesetupSyncCampaignType(true, false);
					_alreadyFetchedCampaignType = false;
					break;
				case CampaignFieldIndex.RedemptionCodeId:
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
			_alreadyFetchedCampaignItems = (_campaignItems.Count > 0);
			_alreadyFetchedCampaignOwners = (_campaignOwners.Count > 0);
			_alreadyFetchedChannels = (_channels.Count > 0);
			_alreadyFetchedChannelOwners = (_channelOwners.Count > 0);
			_alreadyFetchedCampaignType = (_campaignType != null);
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
				case "CampaignType":
					toReturn.Add(Relations.CampaignTypeEntityUsingCampaignTypeId);
					break;
				case "RedemptionCode":
					toReturn.Add(Relations.RedemptionCodeEntityUsingRedemptionCodeId);
					break;
				case "CampaignItems":
					toReturn.Add(Relations.CampaignItemEntityUsingCampaignId);
					break;
				case "CampaignOwners":
					toReturn.Add(Relations.CampaignOwnerEntityUsingCampaignId);
					break;
				case "Channels":
					toReturn.Add(Relations.ChannelEntityUsingCampaignId);
					break;
				case "ChannelOwners":
					toReturn.Add(Relations.ChannelOwnerEntityUsingCampaignId);
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
			info.AddValue("_campaignOwners", (!this.MarkedForDeletion?_campaignOwners:null));
			info.AddValue("_alwaysFetchCampaignOwners", _alwaysFetchCampaignOwners);
			info.AddValue("_alreadyFetchedCampaignOwners", _alreadyFetchedCampaignOwners);
			info.AddValue("_channels", (!this.MarkedForDeletion?_channels:null));
			info.AddValue("_alwaysFetchChannels", _alwaysFetchChannels);
			info.AddValue("_alreadyFetchedChannels", _alreadyFetchedChannels);
			info.AddValue("_channelOwners", (!this.MarkedForDeletion?_channelOwners:null));
			info.AddValue("_alwaysFetchChannelOwners", _alwaysFetchChannelOwners);
			info.AddValue("_alreadyFetchedChannelOwners", _alreadyFetchedChannelOwners);
			info.AddValue("_campaignType", (!this.MarkedForDeletion?_campaignType:null));
			info.AddValue("_campaignTypeReturnsNewIfNotFound", _campaignTypeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCampaignType", _alwaysFetchCampaignType);
			info.AddValue("_alreadyFetchedCampaignType", _alreadyFetchedCampaignType);
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
				case "CampaignType":
					_alreadyFetchedCampaignType = true;
					this.CampaignType = (CampaignTypeEntity)entity;
					break;
				case "RedemptionCode":
					_alreadyFetchedRedemptionCode = true;
					this.RedemptionCode = (RedemptionCodeEntity)entity;
					break;
				case "CampaignItems":
					_alreadyFetchedCampaignItems = true;
					if(entity!=null)
					{
						this.CampaignItems.Add((CampaignItemEntity)entity);
					}
					break;
				case "CampaignOwners":
					_alreadyFetchedCampaignOwners = true;
					if(entity!=null)
					{
						this.CampaignOwners.Add((CampaignOwnerEntity)entity);
					}
					break;
				case "Channels":
					_alreadyFetchedChannels = true;
					if(entity!=null)
					{
						this.Channels.Add((ChannelEntity)entity);
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
				case "CampaignType":
					SetupSyncCampaignType(relatedEntity);
					break;
				case "RedemptionCode":
					SetupSyncRedemptionCode(relatedEntity);
					break;
				case "CampaignItems":
					_campaignItems.Add((CampaignItemEntity)relatedEntity);
					break;
				case "CampaignOwners":
					_campaignOwners.Add((CampaignOwnerEntity)relatedEntity);
					break;
				case "Channels":
					_channels.Add((ChannelEntity)relatedEntity);
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
				case "CampaignType":
					DesetupSyncCampaignType(false, true);
					break;
				case "RedemptionCode":
					DesetupSyncRedemptionCode(false, true);
					break;
				case "CampaignItems":
					this.PerformRelatedEntityRemoval(_campaignItems, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "CampaignOwners":
					this.PerformRelatedEntityRemoval(_campaignOwners, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Channels":
					this.PerformRelatedEntityRemoval(_channels, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_campaignType!=null)
			{
				toReturn.Add(_campaignType);
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
			toReturn.Add(_campaignItems);
			toReturn.Add(_campaignOwners);
			toReturn.Add(_channels);
			toReturn.Add(_channelOwners);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="campaignId">PK value for Campaign which data should be fetched into this Campaign object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 campaignId)
		{
			return FetchUsingPK(campaignId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="campaignId">PK value for Campaign which data should be fetched into this Campaign object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 campaignId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(campaignId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="campaignId">PK value for Campaign which data should be fetched into this Campaign object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 campaignId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(campaignId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="campaignId">PK value for Campaign which data should be fetched into this Campaign object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 campaignId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(campaignId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.CampaignId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new CampaignRelations().GetAllRelations();
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
				_campaignItems.GetMultiManyToOne(this, null, filter);
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

		/// <summary> Retrieves all related entities of type 'CampaignOwnerEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CampaignOwnerEntity'</returns>
		public Mecca.CMT.DAL.CollectionClasses.CampaignOwnerCollection GetMultiCampaignOwners(bool forceFetch)
		{
			return GetMultiCampaignOwners(forceFetch, _campaignOwners.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CampaignOwnerEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'CampaignOwnerEntity'</returns>
		public Mecca.CMT.DAL.CollectionClasses.CampaignOwnerCollection GetMultiCampaignOwners(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiCampaignOwners(forceFetch, _campaignOwners.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'CampaignOwnerEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Mecca.CMT.DAL.CollectionClasses.CampaignOwnerCollection GetMultiCampaignOwners(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiCampaignOwners(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'CampaignOwnerEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Mecca.CMT.DAL.CollectionClasses.CampaignOwnerCollection GetMultiCampaignOwners(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
			if( ( (!_alreadyFetchedCampaignOwners && EntityBase.EnableLazyLoading) || forceFetch || _alwaysFetchCampaignOwners) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_campaignOwners);
				_campaignOwners.SuppressClearInGetMulti=!forceFetch;
				_campaignOwners.EntityFactoryToUse = entityFactoryToUse;
				_campaignOwners.GetMultiManyToOne(this, filter);
				_campaignOwners.SuppressClearInGetMulti=false;
				_alreadyFetchedCampaignOwners = true;
			}
			return _campaignOwners;
		}

		/// <summary> Sets the collection parameters for the collection for 'CampaignOwners'. These settings will be taken into account
		/// when the property CampaignOwners is requested or GetMultiCampaignOwners is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCampaignOwners(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_campaignOwners.SortClauses=sortClauses;
			_campaignOwners.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ChannelEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ChannelEntity'</returns>
		public Mecca.CMT.DAL.CollectionClasses.ChannelCollection GetMultiChannels(bool forceFetch)
		{
			return GetMultiChannels(forceFetch, _channels.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ChannelEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ChannelEntity'</returns>
		public Mecca.CMT.DAL.CollectionClasses.ChannelCollection GetMultiChannels(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiChannels(forceFetch, _channels.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ChannelEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Mecca.CMT.DAL.CollectionClasses.ChannelCollection GetMultiChannels(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiChannels(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ChannelEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Mecca.CMT.DAL.CollectionClasses.ChannelCollection GetMultiChannels(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
			if( ( (!_alreadyFetchedChannels && EntityBase.EnableLazyLoading) || forceFetch || _alwaysFetchChannels) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_channels);
				_channels.SuppressClearInGetMulti=!forceFetch;
				_channels.EntityFactoryToUse = entityFactoryToUse;
				_channels.GetMultiManyToOne(this, null, null, filter);
				_channels.SuppressClearInGetMulti=false;
				_alreadyFetchedChannels = true;
			}
			return _channels;
		}

		/// <summary> Sets the collection parameters for the collection for 'Channels'. These settings will be taken into account
		/// when the property Channels is requested or GetMultiChannels is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersChannels(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_channels.SortClauses=sortClauses;
			_channels.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_channelOwners.GetMultiManyToOne(this, null, filter);
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

		/// <summary> Retrieves the related entity of type 'CampaignTypeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'CampaignTypeEntity' which is related to this entity.</returns>
		public CampaignTypeEntity GetSingleCampaignType()
		{
			return GetSingleCampaignType(false);
		}

		/// <summary> Retrieves the related entity of type 'CampaignTypeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'CampaignTypeEntity' which is related to this entity.</returns>
		public virtual CampaignTypeEntity GetSingleCampaignType(bool forceFetch)
		{
			if((!_alreadyFetchedCampaignType || forceFetch || _alwaysFetchCampaignType) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.CampaignTypeEntityUsingCampaignTypeId) && (EntityBase.EnableLazyLoading || forceFetch);
				CampaignTypeEntity newEntity = new CampaignTypeEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.CampaignTypeId);
				}
				if(fetchResult)
				{
					newEntity = (CampaignTypeEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_campaignTypeReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.CampaignType = newEntity;
				_alreadyFetchedCampaignType = fetchResult;
			}
			return _campaignType;
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
			toReturn.Add("CampaignType", _campaignType);
			toReturn.Add("RedemptionCode", _redemptionCode);
			toReturn.Add("CampaignItems", _campaignItems);
			toReturn.Add("CampaignOwners", _campaignOwners);
			toReturn.Add("Channels", _channels);
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
		/// <param name="campaignId">PK value for Campaign which data should be fetched into this Campaign object</param>
		/// <param name="validator">The validator object for this CampaignEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 campaignId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(campaignId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_campaignItems = new Mecca.CMT.DAL.CollectionClasses.CampaignItemCollection();
			_campaignItems.SetContainingEntityInfo(this, "Campaign");

			_campaignOwners = new Mecca.CMT.DAL.CollectionClasses.CampaignOwnerCollection();
			_campaignOwners.SetContainingEntityInfo(this, "Campaign");

			_channels = new Mecca.CMT.DAL.CollectionClasses.ChannelCollection();
			_channels.SetContainingEntityInfo(this, "Campaign");

			_channelOwners = new Mecca.CMT.DAL.CollectionClasses.ChannelOwnerCollection();
			_channelOwners.SetContainingEntityInfo(this, "Campaign");
			_campaignTypeReturnsNewIfNotFound = false;
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
			_fieldsCustomProperties.Add("BusinessFormat", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CampaignCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CampaignId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CampaignName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CampaignTypeId", fieldHashtable);
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

		/// <summary> Removes the sync logic for member _campaignType</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCampaignType(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _campaignType, new PropertyChangedEventHandler( OnCampaignTypePropertyChanged ), "CampaignType", Mecca.CMT.DAL.RelationClasses.StaticCampaignRelations.CampaignTypeEntityUsingCampaignTypeIdStatic, true, signalRelatedEntity, "Campaigns", resetFKFields, new int[] { (int)CampaignFieldIndex.CampaignTypeId } );		
			_campaignType = null;
		}
		
		/// <summary> setups the sync logic for member _campaignType</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCampaignType(IEntityCore relatedEntity)
		{
			if(_campaignType!=relatedEntity)
			{		
				DesetupSyncCampaignType(true, true);
				_campaignType = (CampaignTypeEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _campaignType, new PropertyChangedEventHandler( OnCampaignTypePropertyChanged ), "CampaignType", Mecca.CMT.DAL.RelationClasses.StaticCampaignRelations.CampaignTypeEntityUsingCampaignTypeIdStatic, true, ref _alreadyFetchedCampaignType, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCampaignTypePropertyChanged( object sender, PropertyChangedEventArgs e )
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
			this.PerformDesetupSyncRelatedEntity( _redemptionCode, new PropertyChangedEventHandler( OnRedemptionCodePropertyChanged ), "RedemptionCode", Mecca.CMT.DAL.RelationClasses.StaticCampaignRelations.RedemptionCodeEntityUsingRedemptionCodeIdStatic, true, signalRelatedEntity, "Campaigns", resetFKFields, new int[] { (int)CampaignFieldIndex.RedemptionCodeId } );		
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
				this.PerformSetupSyncRelatedEntity( _redemptionCode, new PropertyChangedEventHandler( OnRedemptionCodePropertyChanged ), "RedemptionCode", Mecca.CMT.DAL.RelationClasses.StaticCampaignRelations.RedemptionCodeEntityUsingRedemptionCodeIdStatic, true, ref _alreadyFetchedRedemptionCode, new string[] {  } );
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
		/// <param name="campaignId">PK value for Campaign which data should be fetched into this Campaign object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 campaignId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)CampaignFieldIndex.CampaignId].ForcedCurrentValueWrite(campaignId);
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
			return DAOFactory.CreateCampaignDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new CampaignEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static CampaignRelations Relations
		{
			get	{ return new CampaignRelations(); }
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
			get { return new PrefetchPathElement(new Mecca.CMT.DAL.CollectionClasses.CampaignItemCollection(), (IEntityRelation)GetRelationsForField("CampaignItems")[0], (int)Mecca.CMT.DAL.EntityType.CampaignEntity, (int)Mecca.CMT.DAL.EntityType.CampaignItemEntity, 0, null, null, null, "CampaignItems", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CampaignOwner' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCampaignOwners
		{
			get { return new PrefetchPathElement(new Mecca.CMT.DAL.CollectionClasses.CampaignOwnerCollection(), (IEntityRelation)GetRelationsForField("CampaignOwners")[0], (int)Mecca.CMT.DAL.EntityType.CampaignEntity, (int)Mecca.CMT.DAL.EntityType.CampaignOwnerEntity, 0, null, null, null, "CampaignOwners", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Channel' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathChannels
		{
			get { return new PrefetchPathElement(new Mecca.CMT.DAL.CollectionClasses.ChannelCollection(), (IEntityRelation)GetRelationsForField("Channels")[0], (int)Mecca.CMT.DAL.EntityType.CampaignEntity, (int)Mecca.CMT.DAL.EntityType.ChannelEntity, 0, null, null, null, "Channels", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ChannelOwner' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathChannelOwners
		{
			get { return new PrefetchPathElement(new Mecca.CMT.DAL.CollectionClasses.ChannelOwnerCollection(), (IEntityRelation)GetRelationsForField("ChannelOwners")[0], (int)Mecca.CMT.DAL.EntityType.CampaignEntity, (int)Mecca.CMT.DAL.EntityType.ChannelOwnerEntity, 0, null, null, null, "ChannelOwners", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CampaignType'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCampaignType
		{
			get	{ return new PrefetchPathElement(new Mecca.CMT.DAL.CollectionClasses.CampaignTypeCollection(), (IEntityRelation)GetRelationsForField("CampaignType")[0], (int)Mecca.CMT.DAL.EntityType.CampaignEntity, (int)Mecca.CMT.DAL.EntityType.CampaignTypeEntity, 0, null, null, null, "CampaignType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RedemptionCode'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRedemptionCode
		{
			get	{ return new PrefetchPathElement(new Mecca.CMT.DAL.CollectionClasses.RedemptionCodeCollection(), (IEntityRelation)GetRelationsForField("RedemptionCode")[0], (int)Mecca.CMT.DAL.EntityType.CampaignEntity, (int)Mecca.CMT.DAL.EntityType.RedemptionCodeEntity, 0, null, null, null, "RedemptionCode", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The BusinessFormat property of the Entity Campaign<br/><br/></summary>
		/// <remarks>Mapped on  table field: "campaigns"."business_format"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String BusinessFormat
		{
			get { return (System.String)GetValue((int)CampaignFieldIndex.BusinessFormat, true); }
			set	{ SetValue((int)CampaignFieldIndex.BusinessFormat, value, true); }
		}

		/// <summary> The CampaignCode property of the Entity Campaign<br/><br/></summary>
		/// <remarks>Mapped on  table field: "campaigns"."campaign_code"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CampaignCode
		{
			get { return (System.String)GetValue((int)CampaignFieldIndex.CampaignCode, true); }
			set	{ SetValue((int)CampaignFieldIndex.CampaignCode, value, true); }
		}

		/// <summary> The CampaignId property of the Entity Campaign<br/><br/></summary>
		/// <remarks>Mapped on  table field: "campaigns"."campaign_id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 CampaignId
		{
			get { return (System.Int32)GetValue((int)CampaignFieldIndex.CampaignId, true); }
			set	{ SetValue((int)CampaignFieldIndex.CampaignId, value, true); }
		}

		/// <summary> The CampaignName property of the Entity Campaign<br/><br/></summary>
		/// <remarks>Mapped on  table field: "campaigns"."campaign_name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String CampaignName
		{
			get { return (System.String)GetValue((int)CampaignFieldIndex.CampaignName, true); }
			set	{ SetValue((int)CampaignFieldIndex.CampaignName, value, true); }
		}

		/// <summary> The CampaignTypeId property of the Entity Campaign<br/><br/></summary>
		/// <remarks>Mapped on  table field: "campaigns"."campaign_type_id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 CampaignTypeId
		{
			get { return (System.Int32)GetValue((int)CampaignFieldIndex.CampaignTypeId, true); }
			set	{ SetValue((int)CampaignFieldIndex.CampaignTypeId, value, true); }
		}

		/// <summary> The CreatedBy property of the Entity Campaign<br/><br/></summary>
		/// <remarks>Mapped on  table field: "campaigns"."created_by"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 200<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String CreatedBy
		{
			get { return (System.String)GetValue((int)CampaignFieldIndex.CreatedBy, true); }
			set	{ SetValue((int)CampaignFieldIndex.CreatedBy, value, true); }
		}

		/// <summary> The Description property of the Entity Campaign<br/><br/></summary>
		/// <remarks>Mapped on  table field: "campaigns"."description"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Description
		{
			get { return (System.String)GetValue((int)CampaignFieldIndex.Description, true); }
			set	{ SetValue((int)CampaignFieldIndex.Description, value, true); }
		}

		/// <summary> The EndDate property of the Entity Campaign<br/><br/></summary>
		/// <remarks>Mapped on  table field: "campaigns"."end_date"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime EndDate
		{
			get { return (System.DateTime)GetValue((int)CampaignFieldIndex.EndDate, true); }
			set	{ SetValue((int)CampaignFieldIndex.EndDate, value, true); }
		}

		/// <summary> The IsLocked property of the Entity Campaign<br/><br/></summary>
		/// <remarks>Mapped on  table field: "campaigns"."is_locked"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 IsLocked
		{
			get { return (System.Int32)GetValue((int)CampaignFieldIndex.IsLocked, true); }
			set	{ SetValue((int)CampaignFieldIndex.IsLocked, value, true); }
		}

		/// <summary> The RedemptionCodeId property of the Entity Campaign<br/><br/></summary>
		/// <remarks>Mapped on  table field: "campaigns"."redemption_code_id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 RedemptionCodeId
		{
			get { return (System.Int32)GetValue((int)CampaignFieldIndex.RedemptionCodeId, true); }
			set	{ SetValue((int)CampaignFieldIndex.RedemptionCodeId, value, true); }
		}

		/// <summary> The StartDate property of the Entity Campaign<br/><br/></summary>
		/// <remarks>Mapped on  table field: "campaigns"."start_date"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime StartDate
		{
			get { return (System.DateTime)GetValue((int)CampaignFieldIndex.StartDate, true); }
			set	{ SetValue((int)CampaignFieldIndex.StartDate, value, true); }
		}

		/// <summary> The StoreOptionId property of the Entity Campaign<br/><br/></summary>
		/// <remarks>Mapped on  table field: "campaigns"."store_option_id"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 StoreOptionId
		{
			get { return (System.Int32)GetValue((int)CampaignFieldIndex.StoreOptionId, true); }
			set	{ SetValue((int)CampaignFieldIndex.StoreOptionId, value, true); }
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
		/// <summary> Retrieves all related entities of type 'CampaignOwnerEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCampaignOwners()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Mecca.CMT.DAL.CollectionClasses.CampaignOwnerCollection CampaignOwners
		{
			get	{ return GetMultiCampaignOwners(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for CampaignOwners. When set to true, CampaignOwners is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CampaignOwners is accessed. You can always execute/ a forced fetch by calling GetMultiCampaignOwners(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCampaignOwners
		{
			get	{ return _alwaysFetchCampaignOwners; }
			set	{ _alwaysFetchCampaignOwners = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property CampaignOwners already has been fetched. Setting this property to false when CampaignOwners has been fetched
		/// will clear the CampaignOwners collection well. Setting this property to true while CampaignOwners hasn't been fetched disables lazy loading for CampaignOwners</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCampaignOwners
		{
			get { return _alreadyFetchedCampaignOwners;}
			set 
			{
				if(_alreadyFetchedCampaignOwners && !value && (_campaignOwners != null))
				{
					_campaignOwners.Clear();
				}
				_alreadyFetchedCampaignOwners = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ChannelEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiChannels()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Mecca.CMT.DAL.CollectionClasses.ChannelCollection Channels
		{
			get	{ return GetMultiChannels(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Channels. When set to true, Channels is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Channels is accessed. You can always execute/ a forced fetch by calling GetMultiChannels(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchChannels
		{
			get	{ return _alwaysFetchChannels; }
			set	{ _alwaysFetchChannels = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Channels already has been fetched. Setting this property to false when Channels has been fetched
		/// will clear the Channels collection well. Setting this property to true while Channels hasn't been fetched disables lazy loading for Channels</summary>
		[Browsable(false)]
		public bool AlreadyFetchedChannels
		{
			get { return _alreadyFetchedChannels;}
			set 
			{
				if(_alreadyFetchedChannels && !value && (_channels != null))
				{
					_channels.Clear();
				}
				_alreadyFetchedChannels = value;
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

		/// <summary> Gets / sets related entity of type 'CampaignTypeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCampaignType()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual CampaignTypeEntity CampaignType
		{
			get	{ return GetSingleCampaignType(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncCampaignType(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Campaigns", "CampaignType", _campaignType, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for CampaignType. When set to true, CampaignType is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CampaignType is accessed. You can always execute a forced fetch by calling GetSingleCampaignType(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCampaignType
		{
			get	{ return _alwaysFetchCampaignType; }
			set	{ _alwaysFetchCampaignType = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CampaignType already has been fetched. Setting this property to false when CampaignType has been fetched
		/// will set CampaignType to null as well. Setting this property to true while CampaignType hasn't been fetched disables lazy loading for CampaignType</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCampaignType
		{
			get { return _alreadyFetchedCampaignType;}
			set 
			{
				if(_alreadyFetchedCampaignType && !value)
				{
					this.CampaignType = null;
				}
				_alreadyFetchedCampaignType = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property CampaignType is not found
		/// in the database. When set to true, CampaignType will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool CampaignTypeReturnsNewIfNotFound
		{
			get	{ return _campaignTypeReturnsNewIfNotFound; }
			set { _campaignTypeReturnsNewIfNotFound = value; }	
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
					SetSingleRelatedEntityNavigator(value, "Campaigns", "RedemptionCode", _redemptionCode, true); 
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
			get { return (int)Mecca.CMT.DAL.EntityType.CampaignEntity; }
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
