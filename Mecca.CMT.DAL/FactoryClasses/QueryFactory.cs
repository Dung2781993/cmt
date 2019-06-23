///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
////////////////////////////////////////////////////////////// 
using System;
using System.Linq;
using Mecca.CMT.DAL.EntityClasses;
using Mecca.CMT.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec;

namespace Mecca.CMT.DAL.FactoryClasses
{
	/// <summary>Factory class to produce DynamicQuery instances and EntityQuery instances</summary>
	public partial class QueryFactory
	{
		private int _aliasCounter = 0;

		/// <summary>Creates a new DynamicQuery instance with no alias set.</summary>
		/// <returns>Ready to use DynamicQuery instance</returns>
		public DynamicQuery Create()
		{
			return Create(string.Empty);
		}

		/// <summary>Creates a new DynamicQuery instance with the alias specified as the alias set.</summary>
		/// <param name="alias">The alias.</param>
		/// <returns>Ready to use DynamicQuery instance</returns>
		public DynamicQuery Create(string alias)
		{
			return new DynamicQuery(new ElementCreator(), alias, this.GetNextAliasCounterValue());
		}

		/// <summary>Creates a new DynamicQuery which wraps the specified TableValuedFunction call</summary>
		/// <param name="toWrap">The table valued function call to wrap.</param>
		/// <returns>toWrap wrapped in a DynamicQuery.</returns>
		public DynamicQuery Create(TableValuedFunctionCall toWrap)
		{
			return this.Create().From(new TvfCallWrapper(toWrap)).Select(toWrap.GetFieldsAsArray().Select(f => this.Field(toWrap.Alias, f.Alias)).ToArray());
		}

		/// <summary>Creates a new EntityQuery for the entity of the type specified with no alias set.</summary>
		/// <typeparam name="TEntity">The type of the entity to produce the query for.</typeparam>
		/// <returns>ready to use EntityQuery instance</returns>
		public EntityQuery<TEntity> Create<TEntity>()
			where TEntity : IEntityCore
		{
			return Create<TEntity>(string.Empty);
		}

		/// <summary>Creates a new EntityQuery for the entity of the type specified with the alias specified as the alias set.</summary>
		/// <typeparam name="TEntity">The type of the entity to produce the query for.</typeparam>
		/// <param name="alias">The alias.</param>
		/// <returns>ready to use EntityQuery instance</returns>
		public EntityQuery<TEntity> Create<TEntity>(string alias)
			where TEntity : IEntityCore
		{
			return new EntityQuery<TEntity>(new ElementCreator(), alias, this.GetNextAliasCounterValue());
		}
				
		/// <summary>Creates a new field object with the name specified and of resulttype 'object'. Used for referring to aliased fields in another projection.</summary>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField Field(string fieldName)
		{
			return Field<object>(string.Empty, fieldName);
		}

		/// <summary>Creates a new field object with the name specified and of resulttype 'object'. Used for referring to aliased fields in another projection.</summary>
		/// <param name="targetAlias">The alias of the table/query to target.</param>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField Field(string targetAlias, string fieldName)
		{
			return Field<object>(targetAlias, fieldName);
		}

		/// <summary>Creates a new field object with the name specified and of resulttype 'TValue'. Used for referring to aliased fields in another projection.</summary>
		/// <typeparam name="TValue">The type of the value represented by the field.</typeparam>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField Field<TValue>(string fieldName)
		{
			return Field<TValue>(string.Empty, fieldName);
		}

		/// <summary>Creates a new field object with the name specified and of resulttype 'TValue'. Used for referring to aliased fields in another projection.</summary>
		/// <typeparam name="TValue">The type of the value.</typeparam>
		/// <param name="targetAlias">The alias of the table/query to target.</param>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField Field<TValue>(string targetAlias, string fieldName)
		{
			return new EntityField(fieldName, targetAlias, typeof(TValue));
		}
						
		/// <summary>Gets the next alias counter value to produce artifical aliases with</summary>
		private int GetNextAliasCounterValue()
		{
			_aliasCounter++;
			return _aliasCounter;
		}
		

		/// <summary>Creates and returns a new EntityQuery for the Campaign entity</summary>
		public EntityQuery<CampaignEntity> Campaign
		{
			get { return Create<CampaignEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the CampaignItem entity</summary>
		public EntityQuery<CampaignItemEntity> CampaignItem
		{
			get { return Create<CampaignItemEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the CampaignOwner entity</summary>
		public EntityQuery<CampaignOwnerEntity> CampaignOwner
		{
			get { return Create<CampaignOwnerEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the CampaignStore entity</summary>
		public EntityQuery<CampaignStoreEntity> CampaignStore
		{
			get { return Create<CampaignStoreEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the CampaignType entity</summary>
		public EntityQuery<CampaignTypeEntity> CampaignType
		{
			get { return Create<CampaignTypeEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Channel entity</summary>
		public EntityQuery<ChannelEntity> Channel
		{
			get { return Create<ChannelEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ChannelCustomer entity</summary>
		public EntityQuery<ChannelCustomerEntity> ChannelCustomer
		{
			get { return Create<ChannelCustomerEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ChannelItem entity</summary>
		public EntityQuery<ChannelItemEntity> ChannelItem
		{
			get { return Create<ChannelItemEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ChannelOwner entity</summary>
		public EntityQuery<ChannelOwnerEntity> ChannelOwner
		{
			get { return Create<ChannelOwnerEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ChannelStore entity</summary>
		public EntityQuery<ChannelStoreEntity> ChannelStore
		{
			get { return Create<ChannelStoreEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ChannelType entity</summary>
		public EntityQuery<ChannelTypeEntity> ChannelType
		{
			get { return Create<ChannelTypeEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Product entity</summary>
		public EntityQuery<ProductEntity> Product
		{
			get { return Create<ProductEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the RedemptionCode entity</summary>
		public EntityQuery<RedemptionCodeEntity> RedemptionCode
		{
			get { return Create<RedemptionCodeEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Store entity</summary>
		public EntityQuery<StoreEntity> Store
		{
			get { return Create<StoreEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the StoreOption entity</summary>
		public EntityQuery<StoreOptionEntity> StoreOption
		{
			get { return Create<StoreOptionEntity>(); }
		}


 
	}
}