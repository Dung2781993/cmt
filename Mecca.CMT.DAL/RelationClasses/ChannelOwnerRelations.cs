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
	/// <summary>Implements the relations factory for the entity: ChannelOwner. </summary>
	public partial class ChannelOwnerRelations
	{
		/// <summary>CTor</summary>
		public ChannelOwnerRelations()
		{
		}

		/// <summary>Gets all relations of the ChannelOwnerEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.CampaignEntityUsingCampaignId);
			toReturn.Add(this.ChannelEntityUsingChannelId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between ChannelOwnerEntity and CampaignEntity over the m:1 relation they have, using the relation between the fields:
		/// ChannelOwner.CampaignId - Campaign.CampaignId
		/// </summary>
		public virtual IEntityRelation CampaignEntityUsingCampaignId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Campaign", false);
				relation.AddEntityFieldPair(CampaignFields.CampaignId, ChannelOwnerFields.CampaignId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CampaignEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChannelOwnerEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ChannelOwnerEntity and ChannelEntity over the m:1 relation they have, using the relation between the fields:
		/// ChannelOwner.ChannelId - Channel.ChannelId
		/// </summary>
		public virtual IEntityRelation ChannelEntityUsingChannelId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Channel", false);
				relation.AddEntityFieldPair(ChannelFields.ChannelId, ChannelOwnerFields.ChannelId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChannelEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ChannelOwnerEntity", true);
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
	internal static class StaticChannelOwnerRelations
	{
		internal static readonly IEntityRelation CampaignEntityUsingCampaignIdStatic = new ChannelOwnerRelations().CampaignEntityUsingCampaignId;
		internal static readonly IEntityRelation ChannelEntityUsingChannelIdStatic = new ChannelOwnerRelations().ChannelEntityUsingChannelId;

		/// <summary>CTor</summary>
		static StaticChannelOwnerRelations()
		{
		}
	}
}
