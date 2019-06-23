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
using System.Data;
using System.Data.Common;
using Mecca.CMT.DAL.DaoClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses.SelfServicingSpecific;

namespace Mecca.CMT.DAL.StoredProcedureCallerClasses
{
	/// <summary>Class which contains the static logic to execute action stored procedures in the database.</summary>
	public static partial class ActionProcedures
	{

		/// <summary>Delegate definition for stored procedure 'DeleteSegmentCustomers' to be used in combination of a UnitOfWork object.</summary>
		public delegate int DeleteSegmentCustomersCallBack(System.Int32 channelId,  ITransaction transactionToUse);
		/// <summary>Delegate definition for stored procedure 'GetSegmentCustomers' to be used in combination of a UnitOfWork object.</summary>
		public delegate int GetSegmentCustomersCallBack(System.Int32 channelId, ref System.Int32 totalCustomers,  ITransaction transactionToUse);


		/// <summary>Calls stored procedure 'DeleteSegmentCustomers'.<br/><br/></summary>
		/// <param name="channelId">Input parameter of stored procedure. </param>
		/// <returns>Number of rows affected, if the database / routine doesn't surpress rowcounting.</returns>
		public static int DeleteSegmentCustomers(System.Int32 channelId)
		{
			return DeleteSegmentCustomers(channelId, null);
		}

		/// <summary>Calls stored procedure 'DeleteSegmentCustomers'.<br/><br/></summary>
		/// <param name="channelId">Input parameter of stored procedure. </param>
		/// <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		/// <returns>Number of rows affected, if the database / routine doesn't surpress rowcounting.</returns>
		public static int DeleteSegmentCustomers(System.Int32 channelId,  ITransaction transactionToUse)
		{
			using(StoredProcedureCall call = CreateDeleteSegmentCustomersCall(new DataAccessCoreImpl(new CommonDaoBase(), transactionToUse), channelId))
			{
				int toReturn = call.Call();
				return toReturn;
			}
		}

		/// <summary>Calls stored procedure 'GetSegmentCustomers'.<br/><br/></summary>
		/// <param name="channelId">Input parameter of stored procedure. </param>
		/// <param name="totalCustomers">InputOutput parameter of stored procedure. </param>
		/// <returns>Number of rows affected, if the database / routine doesn't surpress rowcounting.</returns>
		public static int GetSegmentCustomers(System.Int32 channelId, ref System.Int32 totalCustomers)
		{
			return GetSegmentCustomers(channelId, ref totalCustomers, null);
		}

		/// <summary>Calls stored procedure 'GetSegmentCustomers'.<br/><br/></summary>
		/// <param name="channelId">Input parameter of stored procedure. </param>
		/// <param name="totalCustomers">InputOutput parameter of stored procedure. </param>
		/// <param name="transactionToUse">the transaction to use, or null if no transaction is available.</param>
		/// <returns>Number of rows affected, if the database / routine doesn't surpress rowcounting.</returns>
		public static int GetSegmentCustomers(System.Int32 channelId, ref System.Int32 totalCustomers,  ITransaction transactionToUse)
		{
			using(StoredProcedureCall call = CreateGetSegmentCustomersCall(new DataAccessCoreImpl(new CommonDaoBase(), transactionToUse), channelId, totalCustomers))
			{
				int toReturn = call.Call();
				totalCustomers = call.GetParameterValue<System.Int32>(1);
				return toReturn;
			}
		}

		/// <summary>Creates the call object for the call 'DeleteSegmentCustomers' to stored procedure 'DeleteSegmentCustomers'.</summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="channelId">Input parameter</param>
		/// <returns>Ready to use StoredProcedureCall object</returns>
		private static StoredProcedureCall CreateDeleteSegmentCustomersCall(IDataAccessCore dataAccessProvider, System.Int32 channelId)
		{
			return new StoredProcedureCall(dataAccessProvider, @"[mecca_cmt].[dbo].[DeleteSegmentCustomers]", "DeleteSegmentCustomers")
							.AddParameter("@channelId", "Int", 0, ParameterDirection.Input, true, 10, 0, channelId);
		}

		/// <summary>Creates the call object for the call 'GetSegmentCustomers' to stored procedure 'GetSegmentCustomers'.</summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="channelId">Input parameter</param>
		/// <param name="totalCustomers">InputOutput parameter</param>
		/// <returns>Ready to use StoredProcedureCall object</returns>
		private static StoredProcedureCall CreateGetSegmentCustomersCall(IDataAccessCore dataAccessProvider, System.Int32 channelId, System.Int32 totalCustomers)
		{
			return new StoredProcedureCall(dataAccessProvider, @"[mecca_cmt].[dbo].[GetSegmentCustomers]", "GetSegmentCustomers")
							.AddParameter("@channelId", "Int", 0, ParameterDirection.Input, true, 10, 0, channelId)
							.AddParameter("@totalCustomers", "Int", 0, ParameterDirection.InputOutput, true, 10, 0, totalCustomers);
		}



		#region Included Code

		#endregion
	}
}
