//####################################################################################################################################################
// Copyright © 2016, 2017, 2018 by David Henry Lawson - Proprietary and confidential. All Rights Reserved
//
// DO NOT DISTRIBUTE, REDISTRIBUTE OR COMMUNICATE WITHOUT EXPLICIT PERMISSION
//
// NOTICE REGARDING: C:\Projects\QuantumSafe\Shared\Common\Persistance\DbResult.cs  
// All information and code contained herein is an original invention of, and the exclusive property of, David Henry Lawson. 
// The intellectual and technical concepts contained herein are proprietary to David Henry Lawson and are protected by trade secret and copyright law.
// Unauthorized dissemination of this information or reproduction of this material via any medium is strictly prohibited
//####################################################################################################################################################

using System;
using LawsonOperationResult.Interfaces;

namespace LawsonOperationResult.Persistence
{
	public class PersistenceResult : IPersistenceResult
	{
		public bool Success { get; set; }
		public string Message { get; set; }
		public Exception Exception { get; set; }
		public bool HasException => Exception != null;


		public PersistenceResult()
		{
			Success = true;
			Message = "Succeeded";
		}
		public PersistenceResult(int affectedRows)
		{
			Success = affectedRows > 0;
			Message = Success ? "Succeeded" : "Failed";
		}

		public PersistenceResult(bool success)
		{
			Success = success;
			Message = Success ? "Succeeded" : "Failed";
		}


		public PersistenceResult(Exception ex)
		{
			Success = false;
			Message = ex.Message;
			Exception = ex;
		}
		public PersistenceResult(bool success, string message)
		{
			Success = success;
			Message = message;
		}
	}
}
