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
	/// <summary>Implements the relations factory for the entity: Channel. </summary>
	public partial class ChannelRelations
	{
		/// <summary>CTor</summary>
		public ChannelRelations()
		{
		}

		/// <summary>Gets all relations of the ChannelEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ChannelCustomerEntityUsingChannelId);
			toReturn.Add(this.ChannelItemEntityUsingChannelId);
			toReturn.Add(this.ChannelOwnerEntityUsingChannelId);
			toReturn.Add(this.CampaignEntityUsingCampaignId);
			toReturn.Add(this.ChannelTypeEntityUsingChannelTypeId);
			toReturn.Add(this.RedemptionCodeEntityUsingRedemptionCodeId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ChannelEntity and ChannelCustomerEntity over the 1:n relation they have, using the relation between the fields:
		/// Channel.ChannelId - ChannelCustomer.ChannelId
		/// </summary>
		public virtual IEntityRelation ChannelCustomerEntityUsingChannelId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ChannelCustomers" , true);
				relation.AddEntityFieldPair(ChannelFields.ChannelId, ChannelCustomerFields.ChannelId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChannelEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChannelCustomerEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ChannelEntity and ChannelItemEntity over the 1:n relation they have, using the relation between the fields:
		/// Channel.ChannelId - ChannelItem.ChannelId
		/// </summary>
		public virtual IEntityRelation ChannelItemEntityUsingChannelId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ChannelItems" , true);
				relation.AddEntityFieldPair(ChannelFields.ChannelId, ChannelItemFields.ChannelId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChannelEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChannelItemEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ChannelEntity and ChannelOwnerEntity over the 1:n relation they have, using the relation between the fields:
		/// Channel.ChannelId - ChannelOwner.ChannelId
		/// </summary>
		public virtual IEntityRelation ChannelOwnerEntityUsingChannelId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ChannelOwners" , true);
				relation.AddEntityFieldPair(ChannelFields.ChannelId, ChannelOwnerFields.ChannelId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChannelEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChannelOwnerEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between ChannelEntity and CampaignEntity over the m:1 relation they have, using the relation between the fields:
		/// Channel.CampaignId - Campaign.CampaignId
		/// </summary>
		public virtual IEntityRelation CampaignEntityUsingCampaignId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Campaign", false);
				relation.AddEntityFieldPair(CampaignFields.CampaignId, ChannelFields.CampaignId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CampaignEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChannelEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ChannelEntity and ChannelTypeEntity over the m:1 relation they have, using the relation between the fields:
		/// Channel.ChannelTypeId - ChannelType.ChannelTypeId
		/// </summary>
		public virtual IEntityRelation ChannelTypeEntityUsingChannelTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ChannelType", false);
				relation.AddEntityFieldPair(ChannelTypeFields.ChannelTypeId, ChannelFields.ChannelTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChannelTypeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChannelEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ChannelEntity and RedemptionCodeEntity over the m:1 relation they have, using the relation between the fields:
		/// Channel.RedemptionCodeId - RedemptionCode.RedemptionCodeId
		/// </summary>
		public virtual IEntityRelation RedemptionCodeEntityUsingRedemptionCodeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "RedemptionCode", false);
				relation.AddEntityFieldPair(RedemptionCodeFields.RedemptionCodeId, ChannelFields.RedemptionCodeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RedemptionCodeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChannelEntity", true);
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
	internal static class StaticChannelRelations
	{
		internal static readonly IEntityRelation ChannelCustomerEntityUsingChannelIdStatic = new ChannelRelations().ChannelCustomerEntityUsingChannelId;
		internal static readonly IEntityRelation ChannelItemEntityUsingChannelIdStatic = new ChannelRelations().ChannelItemEntityUsingChannelId;
		internal static readonly IEntityRelation ChannelOwnerEntityUsingChannelIdStatic = new ChannelRelations().ChannelOwnerEntityUsingChannelId;
		internal static readonly IEntityRelation CampaignEntityUsingCampaignIdStatic = new ChannelRelations().CampaignEntityUsingCampaignId;
		internal static readonly IEntityRelation ChannelTypeEntityUsingChannelTypeIdStatic = new ChannelRelations().ChannelTypeEntityUsingChannelTypeId;
		internal static readonly IEntityRelation RedemptionCodeEntityUsingRedemptionCodeIdStatic = new ChannelRelations().RedemptionCodeEntityUsingRedemptionCodeId;

		/// <summary>CTor</summary>
		static StaticChannelRelations()
		{
		}
	}
}
