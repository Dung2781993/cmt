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
	/// <summary>Implements the relations factory for the entity: ChannelItem. </summary>
	public partial class ChannelItemRelations
	{
		/// <summary>CTor</summary>
		public ChannelItemRelations()
		{
		}

		/// <summary>Gets all relations of the ChannelItemEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ChannelEntityUsingChannelId);
			toReturn.Add(this.ProductEntityUsingProductId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between ChannelItemEntity and ChannelEntity over the m:1 relation they have, using the relation between the fields:
		/// ChannelItem.ChannelId - Channel.ChannelId
		/// </summary>
		public virtual IEntityRelation ChannelEntityUsingChannelId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Channel", false);
				relation.AddEntityFieldPair(ChannelFields.ChannelId, ChannelItemFields.ChannelId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChannelEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChannelItemEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ChannelItemEntity and ProductEntity over the m:1 relation they have, using the relation between the fields:
		/// ChannelItem.ProductId - Product.ProductId
		/// </summary>
		public virtual IEntityRelation ProductEntityUsingProductId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Product", false);
				relation.AddEntityFieldPair(ProductFields.ProductId, ChannelItemFields.ProductId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChannelItemEntity", true);
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
	internal static class StaticChannelItemRelations
	{
		internal static readonly IEntityRelation ChannelEntityUsingChannelIdStatic = new ChannelItemRelations().ChannelEntityUsingChannelId;
		internal static readonly IEntityRelation ProductEntityUsingProductIdStatic = new ChannelItemRelations().ProductEntityUsingProductId;

		/// <summary>CTor</summary>
		static StaticChannelItemRelations()
		{
		}
	}
}
