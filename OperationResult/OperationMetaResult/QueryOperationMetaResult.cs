using System;
using System.Collections.Generic;
using System.Linq;
using Lawson.OperationResult.Interfaces;

namespace Lawson.OperationResult.OperationMetaResult
{
	public class QueryOperationMetaResult<TResult, TMeta> : OperationMetaResultBase<TMeta>, IQueryOperationMetaResult<TResult, TMeta>
	{
		public List<TResult> OperationResult { get; }

		public QueryOperationMetaResult(IEnumerable<TResult> result, TMeta meta)
			: base(result.Any(), meta)
		{
			OperationResult = result.ToList();
		}

		public QueryOperationMetaResult(Exception ex, TMeta meta)
			: base(ex, meta)
		{
			OperationResult = new List<TResult>(0);
		}
	}
}

