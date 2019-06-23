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
using System.Collections.Generic;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

using Mecca.CMT.DAL;
using Mecca.CMT.DAL.DaoClasses;
using Mecca.CMT.DAL.EntityClasses;
using Mecca.CMT.DAL.FactoryClasses;
using Mecca.CMT.DAL.HelperClasses;
using Mecca.CMT.DAL.RelationClasses;

namespace Mecca.CMT.DAL.Linq
{
	/// <summary>Meta-data class for the construction of Linq queries which are to be executed using LLBLGen Pro code.</summary>
	public partial class LinqMetaData : ILinqMetaData
	{
		#region Class Member Declarations
		private ITransaction _transactionToUse;
		private FunctionMappingStore _customFunctionMappings;
		private Context _contextToUse;
		#endregion
		
		/// <summary>CTor. Using this ctor will leave the transaction object to use empty. This is ok if you're not executing queries created with this
		/// meta data inside a transaction. If you're executing the queries created with this meta-data inside a transaction, either set the Transaction property
		/// on the IQueryable.Provider instance of the created LLBLGenProQuery object prior to execution or use the ctor which accepts a transaction object.</summary>
		public LinqMetaData() : this(null, null)
		{
		}
		
		/// <summary>CTor. If you're executing the queries created with this meta-data inside a transaction, pass a live ITransaction object to this ctor.</summary>
		/// <param name="transactionToUse">the transaction to use in queries created with this meta-data</param>
		/// <remarks> Be aware that the ITransaction object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(ITransaction transactionToUse) : this(transactionToUse, null)
		{
		}
		
		/// <summary>CTor. If you're executing the queries created with this meta-data inside a transaction, pass a live ITransaction object to this ctor.</summary>
		/// <param name="transactionToUse">the transaction to use in queries created with this meta-data</param>
		/// <param name="customFunctionMappings">The custom function mappings to use. These take higher precedence than the ones in the DQE to use.</param>
		/// <remarks> Be aware that the ITransaction object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(ITransaction transactionToUse, FunctionMappingStore customFunctionMappings)
		{
			_transactionToUse = transactionToUse;
			_customFunctionMappings = customFunctionMappings;
		}
		
		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <param name="typeOfEntity">the type of the entity to get the datasource for</param>
		/// <returns>the requested datasource</returns>
		public IDataSource GetQueryableForEntity(int typeOfEntity)
		{
			IDataSource toReturn = null;
			switch((Mecca.CMT.DAL.EntityType)typeOfEntity)
			{
				case Mecca.CMT.DAL.EntityType.CampaignEntity:
					toReturn = this.Campaign;
					break;
				case Mecca.CMT.DAL.EntityType.CampaignItemEntity:
					toReturn = this.CampaignItem;
					break;
				case Mecca.CMT.DAL.EntityType.CampaignOwnerEntity:
					toReturn = this.CampaignOwner;
					break;
				case Mecca.CMT.DAL.EntityType.CampaignStoreEntity:
					toReturn = this.CampaignStore;
					break;
				case Mecca.CMT.DAL.EntityType.CampaignTypeEntity:
					toReturn = this.CampaignType;
					break;
				case Mecca.CMT.DAL.EntityType.ChannelEntity:
					toReturn = this.Channel;
					break;
				case Mecca.CMT.DAL.EntityType.ChannelCustomerEntity:
					toReturn = this.ChannelCustomer;
					break;
				case Mecca.CMT.DAL.EntityType.ChannelItemEntity:
					toReturn = this.ChannelItem;
					break;
				case Mecca.CMT.DAL.EntityType.ChannelOwnerEntity:
					toReturn = this.ChannelOwner;
					break;
				case Mecca.CMT.DAL.EntityType.ChannelStoreEntity:
					toReturn = this.ChannelStore;
					break;
				case Mecca.CMT.DAL.EntityType.ChannelTypeEntity:
					toReturn = this.ChannelType;
					break;
				case Mecca.CMT.DAL.EntityType.ProductEntity:
					toReturn = this.Product;
					break;
				case Mecca.CMT.DAL.EntityType.RedemptionCodeEntity:
					toReturn = this.RedemptionCode;
					break;
				case Mecca.CMT.DAL.EntityType.StoreEntity:
					toReturn = this.Store;
					break;
				case Mecca.CMT.DAL.EntityType.StoreOptionEntity:
					toReturn = this.StoreOption;
					break;
				default:
					toReturn = null;
					break;
			}
			return toReturn;
		}

		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <typeparam name="TEntity">the type of the entity to get the datasource for</typeparam>
		/// <returns>the requested datasource</returns>
		public DataSource<TEntity> GetQueryableForEntity<TEntity>()
				where TEntity : class
		{
			return new DataSource<TEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse);
		}

		/// <summary>returns the datasource to use in a Linq query when targeting CampaignEntity instances in the database.</summary>
		public DataSource<CampaignEntity> Campaign
		{
			get { return new DataSource<CampaignEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting CampaignItemEntity instances in the database.</summary>
		public DataSource<CampaignItemEntity> CampaignItem
		{
			get { return new DataSource<CampaignItemEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting CampaignOwnerEntity instances in the database.</summary>
		public DataSource<CampaignOwnerEntity> CampaignOwner
		{
			get { return new DataSource<CampaignOwnerEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting CampaignStoreEntity instances in the database.</summary>
		public DataSource<CampaignStoreEntity> CampaignStore
		{
			get { return new DataSource<CampaignStoreEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting CampaignTypeEntity instances in the database.</summary>
		public DataSource<CampaignTypeEntity> CampaignType
		{
			get { return new DataSource<CampaignTypeEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ChannelEntity instances in the database.</summary>
		public DataSource<ChannelEntity> Channel
		{
			get { return new DataSource<ChannelEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ChannelCustomerEntity instances in the database.</summary>
		public DataSource<ChannelCustomerEntity> ChannelCustomer
		{
			get { return new DataSource<ChannelCustomerEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ChannelItemEntity instances in the database.</summary>
		public DataSource<ChannelItemEntity> ChannelItem
		{
			get { return new DataSource<ChannelItemEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ChannelOwnerEntity instances in the database.</summary>
		public DataSource<ChannelOwnerEntity> ChannelOwner
		{
			get { return new DataSource<ChannelOwnerEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ChannelStoreEntity instances in the database.</summary>
		public DataSource<ChannelStoreEntity> ChannelStore
		{
			get { return new DataSource<ChannelStoreEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ChannelTypeEntity instances in the database.</summary>
		public DataSource<ChannelTypeEntity> ChannelType
		{
			get { return new DataSource<ChannelTypeEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ProductEntity instances in the database.</summary>
		public DataSource<ProductEntity> Product
		{
			get { return new DataSource<ProductEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting RedemptionCodeEntity instances in the database.</summary>
		public DataSource<RedemptionCodeEntity> RedemptionCode
		{
			get { return new DataSource<RedemptionCodeEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting StoreEntity instances in the database.</summary>
		public DataSource<StoreEntity> Store
		{
			get { return new DataSource<StoreEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting StoreOptionEntity instances in the database.</summary>
		public DataSource<StoreOptionEntity> StoreOption
		{
			get { return new DataSource<StoreOptionEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}

		#region Class Property Declarations
		/// <summary> Gets / sets the ITransaction to use for the queries created with this meta data object.</summary>
		/// <remarks> Be aware that the ITransaction object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public ITransaction TransactionToUse
		{
			get { return _transactionToUse;}
			set { _transactionToUse = value;}
		}

		/// <summary>Gets or sets the custom function mappings to use. These take higher precedence than the ones in the DQE to use</summary>
		public FunctionMappingStore CustomFunctionMappings
		{
			get { return _customFunctionMappings; }
			set { _customFunctionMappings = value; }
		}
		
		/// <summary>Gets or sets the Context instance to use for entity fetches.</summary>
		public Context ContextToUse
		{
			get { return _contextToUse;}
			set { _contextToUse = value;}
		}
		#endregion
	}
}