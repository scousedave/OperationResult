//####################################################################################################################################################
// Copyright © 2016, 2017, 2018 by David Henry Lawson - Proprietary and confidential. All Rights Reserved
//
// DO NOT DISTRIBUTE, REDISTRIBUTE OR COMMUNICATE WITHOUT EXPLICIT PERMISSION
//
// NOTICE REGARDING: C:\Projects\QuantumSafe\Shared\Common\Persistance\DbOperationResult.cs  
// All information and code contained herein is an original invention of, and the exclusive property of, David Henry Lawson. 
// The intellectual and technical concepts contained herein are proprietary to David Henry Lawson and are protected by trade secret and copyright law.
// Unauthorized dissemination of this information or reproduction of this material via any medium is strictly prohibited
//####################################################################################################################################################

using System;
using System.Collections.Generic;
using LawsonOperationResult.Interfaces;

namespace LawsonOperationResult.Persistence
{
	public class PersistenceOperationResult<T> : PersistenceResult, IPersistenceOperationResult<T>
	{
		public List<T> OperationResult { get; set; }

		public PersistenceOperationResult(List<T> result)
			: base(result.Count)
		{
			OperationResult = result;
		}

		public PersistenceOperationResult(Exception ex)
			: base(ex)
		{
			OperationResult = new List<T>();
		}
	}
}
