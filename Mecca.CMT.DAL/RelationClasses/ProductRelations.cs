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
using System.Collections;
using System.Collections.Generic;
using Mecca.CMT.DAL;
using Mecca.CMT.DAL.FactoryClasses;
using Mecca.CMT.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Mecca.CMT.DAL.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Product. </summary>
	public partial class ProductRelations
	{
		/// <summary>CTor</summary>
		public ProductRelations()
		{
		}

		/// <summary>Gets all relations of the ProductEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.CampaignItemEntityUsingProductId);
			toReturn.Add(this.ChannelItemEntityUsingProductId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and CampaignItemEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.ProductId - CampaignItem.ProductId
		/// </summary>
		public virtual IEntityRelation CampaignItemEntityUsingProductId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CampaignItems" , true);
				relation.AddEntityFieldPair(ProductFields.ProductId, CampaignItemFields.ProductId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CampaignItemEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and ChannelItemEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.ProductId - ChannelItem.ProductId
		/// </summary>
		public virtual IEntityRelation ChannelItemEntityUsingProductId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ChannelItems" , true);
				relation.AddEntityFieldPair(ProductFields.ProductId, ChannelItemFields.ProductId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChannelItemEntity", false);
				return relation;
			}
		}


		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}
		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticProductRelations
	{
		internal static readonly IEntityRelation CampaignItemEntityUsingProductIdStatic = new ProductRelations().CampaignItemEntityUsingProductId;
		internal static readonly IEntityRelation ChannelItemEntityUsingProductIdStatic = new ProductRelations().ChannelItemEntityUsingProductId;

		/// <summary>CTor</summary>
		static StaticProductRelations()
		{
		}
	}
}
