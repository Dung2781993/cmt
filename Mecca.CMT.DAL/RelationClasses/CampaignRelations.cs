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
	/// <summary>Implements the relations factory for the entity: Campaign. </summary>
	public partial class CampaignRelations
	{
		/// <summary>CTor</summary>
		public CampaignRelations()
		{
		}

		/// <summary>Gets all relations of the CampaignEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.CampaignItemEntityUsingCampaignId);
			toReturn.Add(this.CampaignOwnerEntityUsingCampaignId);
			toReturn.Add(this.ChannelEntityUsingCampaignId);
			toReturn.Add(this.ChannelOwnerEntityUsingCampaignId);
			toReturn.Add(this.CampaignTypeEntityUsingCampaignTypeId);
			toReturn.Add(this.RedemptionCodeEntityUsingRedemptionCodeId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between CampaignEntity and CampaignItemEntity over the 1:n relation they have, using the relation between the fields:
		/// Campaign.CampaignId - CampaignItem.CampaignId
		/// </summary>
		public virtual IEntityRelation CampaignItemEntityUsingCampaignId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CampaignItems" , true);
				relation.AddEntityFieldPair(CampaignFields.CampaignId, CampaignItemFields.CampaignId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CampaignEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CampaignItemEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between CampaignEntity and CampaignOwnerEntity over the 1:n relation they have, using the relation between the fields:
		/// Campaign.CampaignId - CampaignOwner.CampaignId
		/// </summary>
		public virtual IEntityRelation CampaignOwnerEntityUsingCampaignId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CampaignOwners" , true);
				relation.AddEntityFieldPair(CampaignFields.CampaignId, CampaignOwnerFields.CampaignId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CampaignEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CampaignOwnerEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between CampaignEntity and ChannelEntity over the 1:n relation they have, using the relation between the fields:
		/// Campaign.CampaignId - Channel.CampaignId
		/// </summary>
		public virtual IEntityRelation ChannelEntityUsingCampaignId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Channels" , true);
				relation.AddEntityFieldPair(CampaignFields.CampaignId, ChannelFields.CampaignId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CampaignEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChannelEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between CampaignEntity and ChannelOwnerEntity over the 1:n relation they have, using the relation between the fields:
		/// Campaign.CampaignId - ChannelOwner.CampaignId
		/// </summary>
		public virtual IEntityRelation ChannelOwnerEntityUsingCampaignId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ChannelOwners" , true);
				relation.AddEntityFieldPair(CampaignFields.CampaignId, ChannelOwnerFields.CampaignId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CampaignEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChannelOwnerEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between CampaignEntity and CampaignTypeEntity over the m:1 relation they have, using the relation between the fields:
		/// Campaign.CampaignTypeId - CampaignType.CampaignTypeId
		/// </summary>
		public virtual IEntityRelation CampaignTypeEntityUsingCampaignTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "CampaignType", false);
				relation.AddEntityFieldPair(CampaignTypeFields.CampaignTypeId, CampaignFields.CampaignTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CampaignTypeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CampaignEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between CampaignEntity and RedemptionCodeEntity over the m:1 relation they have, using the relation between the fields:
		/// Campaign.RedemptionCodeId - RedemptionCode.RedemptionCodeId
		/// </summary>
		public virtual IEntityRelation RedemptionCodeEntityUsingRedemptionCodeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "RedemptionCode", false);
				relation.AddEntityFieldPair(RedemptionCodeFields.RedemptionCodeId, CampaignFields.RedemptionCodeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RedemptionCodeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CampaignEntity", true);
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
	internal static class StaticCampaignRelations
	{
		internal static readonly IEntityRelation CampaignItemEntityUsingCampaignIdStatic = new CampaignRelations().CampaignItemEntityUsingCampaignId;
		internal static readonly IEntityRelation CampaignOwnerEntityUsingCampaignIdStatic = new CampaignRelations().CampaignOwnerEntityUsingCampaignId;
		internal static readonly IEntityRelation ChannelEntityUsingCampaignIdStatic = new CampaignRelations().ChannelEntityUsingCampaignId;
		internal static readonly IEntityRelation ChannelOwnerEntityUsingCampaignIdStatic = new CampaignRelations().ChannelOwnerEntityUsingCampaignId;
		internal static readonly IEntityRelation CampaignTypeEntityUsingCampaignTypeIdStatic = new CampaignRelations().CampaignTypeEntityUsingCampaignTypeId;
		internal static readonly IEntityRelation RedemptionCodeEntityUsingRedemptionCodeIdStatic = new CampaignRelations().RedemptionCodeEntityUsingRedemptionCodeId;

		/// <summary>CTor</summary>
		static StaticCampaignRelations()
		{
		}
	}
}
