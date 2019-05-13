//####################################################################################################################################################
// Copyright © 2016, 2017, 2018 by David Henry Lawson - Proprietary and confidential. All Rights Reserved
//
// DO NOT DISTRIBUTE, REDISTRIBUTE OR COMMUNICATE WITHOUT EXPLICIT PERMISSION
//
// NOTICE REGARDING: C:\Projects\QuantumSafe\Shared\Common\Persistance\DbSingleResult.cs  
// All information and code contained herein is an original invention of, and the exclusive property of, David Henry Lawson. 
// The intellectual and technical concepts contained herein are proprietary to David Henry Lawson and are protected by trade secret and copyright law.
// Unauthorized dissemination of this information or reproduction of this material via any medium is strictly prohibited
//####################################################################################################################################################

using System;
using LawsonOperationResult.Interfaces;

namespace LawsonOperationResult.Persistence
{
	public class PersistenceSingleResult<T> : PersistenceResult, IPersistenceResult<T>, IPersistenceSingleResult<T>
	{
		public T QueryResult { get; set; }

		public PersistenceSingleResult(T result)
			: base(result != null)
		{
			QueryResult = result;
		}

		public PersistenceSingleResult(Exception ex)
			: base(ex)
		{
		}
		public PersistenceSingleResult(IPersistenceResult oldResult, T newResult)
		{
			Exception = oldResult.Exception;
			Success = oldResult.Success;
			Message = oldResult.Message;
			QueryResult = newResult;
		}
	}
}
