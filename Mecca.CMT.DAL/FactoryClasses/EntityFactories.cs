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
using System.Collections.Generic;
using Mecca.CMT.DAL.HelperClasses;
using Mecca.CMT.DAL.RelationClasses;
using Mecca.CMT.DAL.DaoClasses;

using Mecca.CMT.DAL.EntityClasses;
using Mecca.CMT.DAL.CollectionClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Mecca.CMT.DAL.FactoryClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>general base class for the generated factories</summary>
	[Serializable]
	public partial class EntityFactoryBase : EntityFactoryCore
	{
		private readonly Mecca.CMT.DAL.EntityType _typeOfEntity;
		
		/// <summary>CTor</summary>
		/// <param name="entityName">Name of the entity.</param>
		/// <param name="typeOfEntity">The type of entity.</param>
		public EntityFactoryBase(string entityName, Mecca.CMT.DAL.EntityType typeOfEntity) : base(entityName)
		{
			_typeOfEntity = typeOfEntity;
		}

		/// <summary>Creates a new entity instance using the GeneralEntityFactory in the generated code, using the passed in entitytype value</summary>
		/// <param name="entityTypeValue">The entity type value of the entity to create an instance for.</param>
		/// <returns>new IEntity instance</returns>
		public override IEntity CreateEntityFromEntityTypeValue(int entityTypeValue)
		{
			return GeneralEntityFactory.Create((Mecca.CMT.DAL.EntityType)entityTypeValue);
		}
		
		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public override IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(_typeOfEntity);
		}

		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <param name="objectAlias">The object alias to use for the elements in the relations.</param>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public override IRelationCollection CreateHierarchyRelations(string objectAlias) 
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetHierarchyRelations(ForEntityName, objectAlias);
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public override IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return (IEntityFactory)InheritanceInfoProviderSingleton.GetInstance().GetEntityFactory(ForEntityName, fieldValues, entityFieldStartIndexesPerEntity) ?? this;
		}
						
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public override IEntityCollection CreateEntityCollection()
		{
			return GeneralEntityCollectionFactory.Create(_typeOfEntity);
		}
	}
	
	/// <summary>Factory to create new, empty CampaignEntity objects.</summary>
	[Serializable]
	public partial class CampaignEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public CampaignEntityFactory() : base("CampaignEntity", Mecca.CMT.DAL.EntityType.CampaignEntity) { }

		/// <summary>Creates a new, empty CampaignEntity object.</summary>
		/// <returns>A new, empty CampaignEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new CampaignEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCampaign
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty CampaignItemEntity objects.</summary>
	[Serializable]
	public partial class CampaignItemEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public CampaignItemEntityFactory() : base("CampaignItemEntity", Mecca.CMT.DAL.EntityType.CampaignItemEntity) { }

		/// <summary>Creates a new, empty CampaignItemEntity object.</summary>
		/// <returns>A new, empty CampaignItemEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new CampaignItemEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCampaignItem
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty CampaignOwnerEntity objects.</summary>
	[Serializable]
	public partial class CampaignOwnerEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public CampaignOwnerEntityFactory() : base("CampaignOwnerEntity", Mecca.CMT.DAL.EntityType.CampaignOwnerEntity) { }

		/// <summary>Creates a new, empty CampaignOwnerEntity object.</summary>
		/// <returns>A new, empty CampaignOwnerEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new CampaignOwnerEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCampaignOwner
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty CampaignStoreEntity objects.</summary>
	[Serializable]
	public partial class CampaignStoreEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public CampaignStoreEntityFactory() : base("CampaignStoreEntity", Mecca.CMT.DAL.EntityType.CampaignStoreEntity) { }

		/// <summary>Creates a new, empty CampaignStoreEntity object.</summary>
		/// <returns>A new, empty CampaignStoreEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new CampaignStoreEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCampaignStore
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty CampaignTypeEntity objects.</summary>
	[Serializable]
	public partial class CampaignTypeEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public CampaignTypeEntityFactory() : base("CampaignTypeEntity", Mecca.CMT.DAL.EntityType.CampaignTypeEntity) { }

		/// <summary>Creates a new, empty CampaignTypeEntity object.</summary>
		/// <returns>A new, empty CampaignTypeEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new CampaignTypeEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCampaignType
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ChannelEntity objects.</summary>
	[Serializable]
	public partial class ChannelEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ChannelEntityFactory() : base("ChannelEntity", Mecca.CMT.DAL.EntityType.ChannelEntity) { }

		/// <summary>Creates a new, empty ChannelEntity object.</summary>
		/// <returns>A new, empty ChannelEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ChannelEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewChannel
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ChannelCustomerEntity objects.</summary>
	[Serializable]
	public partial class ChannelCustomerEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ChannelCustomerEntityFactory() : base("ChannelCustomerEntity", Mecca.CMT.DAL.EntityType.ChannelCustomerEntity) { }

		/// <summary>Creates a new, empty ChannelCustomerEntity object.</summary>
		/// <returns>A new, empty ChannelCustomerEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ChannelCustomerEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewChannelCustomer
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ChannelItemEntity objects.</summary>
	[Serializable]
	public partial class ChannelItemEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ChannelItemEntityFactory() : base("ChannelItemEntity", Mecca.CMT.DAL.EntityType.ChannelItemEntity) { }

		/// <summary>Creates a new, empty ChannelItemEntity object.</summary>
		/// <returns>A new, empty ChannelItemEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ChannelItemEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewChannelItem
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ChannelOwnerEntity objects.</summary>
	[Serializable]
	public partial class ChannelOwnerEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ChannelOwnerEntityFactory() : base("ChannelOwnerEntity", Mecca.CMT.DAL.EntityType.ChannelOwnerEntity) { }

		/// <summary>Creates a new, empty ChannelOwnerEntity object.</summary>
		/// <returns>A new, empty ChannelOwnerEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ChannelOwnerEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewChannelOwner
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ChannelStoreEntity objects.</summary>
	[Serializable]
	public partial class ChannelStoreEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ChannelStoreEntityFactory() : base("ChannelStoreEntity", Mecca.CMT.DAL.EntityType.ChannelStoreEntity) { }

		/// <summary>Creates a new, empty ChannelStoreEntity object.</summary>
		/// <returns>A new, empty ChannelStoreEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ChannelStoreEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewChannelStore
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ChannelTypeEntity objects.</summary>
	[Serializable]
	public partial class ChannelTypeEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ChannelTypeEntityFactory() : base("ChannelTypeEntity", Mecca.CMT.DAL.EntityType.ChannelTypeEntity) { }

		/// <summary>Creates a new, empty ChannelTypeEntity object.</summary>
		/// <returns>A new, empty ChannelTypeEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ChannelTypeEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewChannelType
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ProductEntity objects.</summary>
	[Serializable]
	public partial class ProductEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ProductEntityFactory() : base("ProductEntity", Mecca.CMT.DAL.EntityType.ProductEntity) { }

		/// <summary>Creates a new, empty ProductEntity object.</summary>
		/// <returns>A new, empty ProductEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ProductEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProduct
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty RedemptionCodeEntity objects.</summary>
	[Serializable]
	public partial class RedemptionCodeEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public RedemptionCodeEntityFactory() : base("RedemptionCodeEntity", Mecca.CMT.DAL.EntityType.RedemptionCodeEntity) { }

		/// <summary>Creates a new, empty RedemptionCodeEntity object.</summary>
		/// <returns>A new, empty RedemptionCodeEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new RedemptionCodeEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRedemptionCode
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty StoreEntity objects.</summary>
	[Serializable]
	public partial class StoreEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public StoreEntityFactory() : base("StoreEntity", Mecca.CMT.DAL.EntityType.StoreEntity) { }

		/// <summary>Creates a new, empty StoreEntity object.</summary>
		/// <returns>A new, empty StoreEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new StoreEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewStore
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty StoreOptionEntity objects.</summary>
	[Serializable]
	public partial class StoreOptionEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public StoreOptionEntityFactory() : base("StoreOptionEntity", Mecca.CMT.DAL.EntityType.StoreOptionEntity) { }

		/// <summary>Creates a new, empty StoreOptionEntity object.</summary>
		/// <returns>A new, empty StoreOptionEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new StoreOptionEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewStoreOption
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new entity collection objects</summary>
	[Serializable]
	public partial class GeneralEntityCollectionFactory
	{
		/// <summary>Creates a new entity collection</summary>
		/// <param name="typeToUse">The entity type to create the collection for.</param>
		/// <returns>A new entity collection object.</returns>
		public static IEntityCollection Create(Mecca.CMT.DAL.EntityType typeToUse)
		{
			switch(typeToUse)
			{
				case Mecca.CMT.DAL.EntityType.CampaignEntity:
					return new CampaignCollection();
				case Mecca.CMT.DAL.EntityType.CampaignItemEntity:
					return new CampaignItemCollection();
				case Mecca.CMT.DAL.EntityType.CampaignOwnerEntity:
					return new CampaignOwnerCollection();
				case Mecca.CMT.DAL.EntityType.CampaignStoreEntity:
					return new CampaignStoreCollection();
				case Mecca.CMT.DAL.EntityType.CampaignTypeEntity:
					return new CampaignTypeCollection();
				case Mecca.CMT.DAL.EntityType.ChannelEntity:
					return new ChannelCollection();
				case Mecca.CMT.DAL.EntityType.ChannelCustomerEntity:
					return new ChannelCustomerCollection();
				case Mecca.CMT.DAL.EntityType.ChannelItemEntity:
					return new ChannelItemCollection();
				case Mecca.CMT.DAL.EntityType.ChannelOwnerEntity:
					return new ChannelOwnerCollection();
				case Mecca.CMT.DAL.EntityType.ChannelStoreEntity:
					return new ChannelStoreCollection();
				case Mecca.CMT.DAL.EntityType.ChannelTypeEntity:
					return new ChannelTypeCollection();
				case Mecca.CMT.DAL.EntityType.ProductEntity:
					return new ProductCollection();
				case Mecca.CMT.DAL.EntityType.RedemptionCodeEntity:
					return new RedemptionCodeCollection();
				case Mecca.CMT.DAL.EntityType.StoreEntity:
					return new StoreCollection();
				case Mecca.CMT.DAL.EntityType.StoreOptionEntity:
					return new StoreOptionCollection();
				default:
					return null;
			}
		}		
	}
	
	/// <summary>Factory to create new, empty Entity objects based on the entity type specified. Uses entity specific factory objects</summary>
	[Serializable]
	public partial class GeneralEntityFactory
	{
		/// <summary>Creates a new, empty Entity object of the type specified</summary>
		/// <param name="entityTypeToCreate">The entity type to create.</param>
		/// <returns>A new, empty Entity object.</returns>
		public static IEntity Create(Mecca.CMT.DAL.EntityType entityTypeToCreate)
		{
			IEntityFactory factoryToUse = null;
			switch(entityTypeToCreate)
			{
				case Mecca.CMT.DAL.EntityType.CampaignEntity:
					factoryToUse = new CampaignEntityFactory();
					break;
				case Mecca.CMT.DAL.EntityType.CampaignItemEntity:
					factoryToUse = new CampaignItemEntityFactory();
					break;
				case Mecca.CMT.DAL.EntityType.CampaignOwnerEntity:
					factoryToUse = new CampaignOwnerEntityFactory();
					break;
				case Mecca.CMT.DAL.EntityType.CampaignStoreEntity:
					factoryToUse = new CampaignStoreEntityFactory();
					break;
				case Mecca.CMT.DAL.EntityType.CampaignTypeEntity:
					factoryToUse = new CampaignTypeEntityFactory();
					break;
				case Mecca.CMT.DAL.EntityType.ChannelEntity:
					factoryToUse = new ChannelEntityFactory();
					break;
				case Mecca.CMT.DAL.EntityType.ChannelCustomerEntity:
					factoryToUse = new ChannelCustomerEntityFactory();
					break;
				case Mecca.CMT.DAL.EntityType.ChannelItemEntity:
					factoryToUse = new ChannelItemEntityFactory();
					break;
				case Mecca.CMT.DAL.EntityType.ChannelOwnerEntity:
					factoryToUse = new ChannelOwnerEntityFactory();
					break;
				case Mecca.CMT.DAL.EntityType.ChannelStoreEntity:
					factoryToUse = new ChannelStoreEntityFactory();
					break;
				case Mecca.CMT.DAL.EntityType.ChannelTypeEntity:
					factoryToUse = new ChannelTypeEntityFactory();
					break;
				case Mecca.CMT.DAL.EntityType.ProductEntity:
					factoryToUse = new ProductEntityFactory();
					break;
				case Mecca.CMT.DAL.EntityType.RedemptionCodeEntity:
					factoryToUse = new RedemptionCodeEntityFactory();
					break;
				case Mecca.CMT.DAL.EntityType.StoreEntity:
					factoryToUse = new StoreEntityFactory();
					break;
				case Mecca.CMT.DAL.EntityType.StoreOptionEntity:
					factoryToUse = new StoreOptionEntityFactory();
					break;
			}
			IEntity toReturn = null;
			if(factoryToUse != null)
			{
				toReturn = factoryToUse.Create();
			}
			return toReturn;
		}		
	}
	
	/// <summary>Class which is used to obtain the entity factory based on the .NET type of the entity. </summary>
	[Serializable]
	public static class EntityFactoryFactory
	{
		private static readonly Dictionary<Type, IEntityFactory> _factoryPerType = new Dictionary<Type, IEntityFactory>();

		/// <summary>Initializes the <see cref="EntityFactoryFactory"/> class.</summary>
		static EntityFactoryFactory()
		{
			Array entityTypeValues = Enum.GetValues(typeof(Mecca.CMT.DAL.EntityType));
			foreach(int entityTypeValue in entityTypeValues)
			{
				IEntity dummy = GeneralEntityFactory.Create((Mecca.CMT.DAL.EntityType)entityTypeValue);
				_factoryPerType.Add(dummy.GetType(), dummy.GetEntityFactory());
			}
		}

		/// <summary>Gets the factory of the entity with the .NET type specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory GetFactory(Type typeOfEntity)
		{
			IEntityFactory toReturn = null;
			_factoryPerType.TryGetValue(typeOfEntity, out toReturn);
			return toReturn;
		}

		/// <summary>Gets the factory of the entity with the Mecca.CMT.DAL.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory GetFactory(Mecca.CMT.DAL.EntityType typeOfEntity)
		{
			return GetFactory(GeneralEntityFactory.Create(typeOfEntity).GetType());
		}
	}
	
	/// <summary>Element creator for creating project elements from somewhere else, like inside Linq providers.</summary>
	public class ElementCreator : ElementCreatorBase, IElementCreator
	{
		/// <summary>Gets the factory of the Entity type with the Mecca.CMT.DAL.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory GetFactory(int entityTypeValue)
		{
			return (IEntityFactory)this.GetFactoryImpl(entityTypeValue);
		}

		/// <summary>Gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory GetFactory(Type typeOfEntity)
		{
			return (IEntityFactory)this.GetFactoryImpl(typeOfEntity);
		}

		/// <summary>Creates a new resultset fields object with the number of field slots reserved as specified</summary>
		/// <param name="numberOfFields">The number of fields.</param>
		/// <returns>ready to use resultsetfields object</returns>
		public IEntityFields CreateResultsetFields(int numberOfFields)
		{
			return new ResultsetFields(numberOfFields);
		}
		
		/// <summary>Gets an instance of the TypedListDAO class to execute dynamic lists and projections.</summary>
		/// <returns>ready to use typedlistDAO</returns>
		public IDao GetTypedListDao()
		{
			return new TypedListDAO();
		}
		
		/// <summary>Obtains the inheritance info provider instance from the singleton </summary>
		/// <returns>The singleton instance of the inheritance info provider</returns>
		public override IInheritanceInfoProvider ObtainInheritanceInfoProviderInstance()
		{
			return InheritanceInfoProviderSingleton.GetInstance();
		}

		/// <summary>Gets the typed view fields of the typedview with the typedviewenum type value specified.</summary>
		/// <param name="typedViewTypeEnumValue">The typed view type enum value.</param>
		/// <returns></returns>
		public override IEntityFieldsCore GetTypedViewFields(int typedViewTypeEnumValue)
		{
			return EntityFieldsFactory.CreateTypedViewEntityFieldsObject((TypedViewType)typedViewTypeEnumValue);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand)
		{
			return new DynamicRelation(leftOperand);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperand">The right operand.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, DerivedTableDefinition rightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, rightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperand">The right operand.</param>
		/// <param name="aliasLeftOperand">The alias of the left operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(IEntityFieldCore leftOperand, JoinHint joinType, DerivedTableDefinition rightOperand, string aliasLeftOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, rightOperand, aliasLeftOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, string rightOperandEntityName, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, (Mecca.CMT.DAL.EntityType)Enum.Parse(typeof(Mecca.CMT.DAL.EntityType), rightOperandEntityName, false), aliasRightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperandEntityName">Name of the entity which is used as the left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasLeftOperand">The alias of the left operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(string leftOperandEntityName, JoinHint joinType, string rightOperandEntityName, string aliasLeftOperand, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation((Mecca.CMT.DAL.EntityType)Enum.Parse(typeof(Mecca.CMT.DAL.EntityType), leftOperandEntityName, false), joinType, (Mecca.CMT.DAL.EntityType)Enum.Parse(typeof(Mecca.CMT.DAL.EntityType), rightOperandEntityName, false), aliasLeftOperand, aliasRightOperand, onClause);
		}
		
		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasLeftOperand">The alias of the left operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(IEntityFieldCore leftOperand, JoinHint joinType, string rightOperandEntityName, string aliasLeftOperand, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, (Mecca.CMT.DAL.EntityType)Enum.Parse(typeof(Mecca.CMT.DAL.EntityType), rightOperandEntityName, false), aliasLeftOperand, aliasRightOperand, onClause);
		}
		
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the Mecca.CMT.DAL.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(int entityTypeValue)
		{
			return EntityFactoryFactory.GetFactory((Mecca.CMT.DAL.EntityType)entityTypeValue);
		}
	
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(Type typeOfEntity)
		{
			return EntityFactoryFactory.GetFactory(typeOfEntity);
		}

	}
}
