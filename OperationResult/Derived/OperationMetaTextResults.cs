using System;
using System.Collections.Generic;
using Lawson.OperationResult.Interfaces;
using Lawson.OperationResult.OperationMetaResult;

namespace Lawson.OperationResult.Derived
{
	public class OperationMetaTextResults<TResult> : QueryOperationMetaResult<TResult, string>, IOperationMetaTextResults<string>
	{
		public OperationMetaTextResults(IEnumerable<TResult> result, string meta) : base(result, meta)
		{
		}

		public OperationMetaTextResults(Exception ex, string meta) : base(ex, meta)
		{
		}
	}
}
