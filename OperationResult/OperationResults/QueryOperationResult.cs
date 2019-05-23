using System;
using System.Collections.Generic;
using System.Linq;
using Lawson.OperationResult.Interfaces;

namespace Lawson.OperationResult.OperationResults
{
	public class QueryOperationResult<T> : OperationResultBase, IQueryOperationResult<T>
	{
		public List<T> OperationResult { get; }

		public QueryOperationResult(IEnumerable<T> result)
			: base(result.Any())
		{
			OperationResult = result.ToList();
		}

		public QueryOperationResult(Exception ex)
			: base(ex)
		{
			OperationResult = new List<T>(0);
		}
	}
}

