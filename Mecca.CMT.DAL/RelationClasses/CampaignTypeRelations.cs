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
	/// <summary>Implements the relations factory for the entity: CampaignType. </summary>
	public partial class CampaignTypeRelations
	{
		/// <summary>CTor</summary>
		public CampaignTypeRelations()
		{
		}

		/// <summary>Gets all relations of the CampaignTypeEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.CampaignEntityUsingCampaignTypeId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between CampaignTypeEntity and CampaignEntity over the 1:n relation they have, using the relation between the fields:
		/// CampaignType.CampaignTypeId - Campaign.CampaignTypeId
		/// </summary>
		public virtual IEntityRelation CampaignEntityUsingCampaignTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Campaigns" , true);
				relation.AddEntityFieldPair(CampaignTypeFields.CampaignTypeId, CampaignFields.CampaignTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CampaignTypeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CampaignEntity", false);
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
	internal static class StaticCampaignTypeRelations
	{
		internal static readonly IEntityRelation CampaignEntityUsingCampaignTypeIdStatic = new CampaignTypeRelations().CampaignEntityUsingCampaignTypeId;

		/// <summary>CTor</summary>
		static StaticCampaignTypeRelations()
		{
		}
	}
}
