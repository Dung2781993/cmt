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
	/// <summary>Implements the relations factory for the entity: RedemptionCode. </summary>
	public partial class RedemptionCodeRelations
	{
		/// <summary>CTor</summary>
		public RedemptionCodeRelations()
		{
		}

		/// <summary>Gets all relations of the RedemptionCodeEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.CampaignEntityUsingRedemptionCodeId);
			toReturn.Add(this.ChannelEntityUsingRedemptionCodeId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between RedemptionCodeEntity and CampaignEntity over the 1:n relation they have, using the relation between the fields:
		/// RedemptionCode.RedemptionCodeId - Campaign.RedemptionCodeId
		/// </summary>
		public virtual IEntityRelation CampaignEntityUsingRedemptionCodeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Campaigns" , true);
				relation.AddEntityFieldPair(RedemptionCodeFields.RedemptionCodeId, CampaignFields.RedemptionCodeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RedemptionCodeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CampaignEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between RedemptionCodeEntity and ChannelEntity over the 1:n relation they have, using the relation between the fields:
		/// RedemptionCode.RedemptionCodeId - Channel.RedemptionCodeId
		/// </summary>
		public virtual IEntityRelation ChannelEntityUsingRedemptionCodeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Channels" , true);
				relation.AddEntityFieldPair(RedemptionCodeFields.RedemptionCodeId, ChannelFields.RedemptionCodeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RedemptionCodeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChannelEntity", false);
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
	internal static class StaticRedemptionCodeRelations
	{
		internal static readonly IEntityRelation CampaignEntityUsingRedemptionCodeIdStatic = new RedemptionCodeRelations().CampaignEntityUsingRedemptionCodeId;
		internal static readonly IEntityRelation ChannelEntityUsingRedemptionCodeIdStatic = new RedemptionCodeRelations().ChannelEntityUsingRedemptionCodeId;

		/// <summary>CTor</summary>
		static StaticRedemptionCodeRelations()
		{
		}
	}
}
