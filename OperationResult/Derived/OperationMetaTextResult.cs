using System;
using Lawson.OperationResult.Interfaces;
using Lawson.OperationResult.OperationMetaResult;

namespace Lawson.OperationResult.Derived
{
	public class OperationMetaTextResult<TResult> : SingleOperationMetaResult<TResult, string>, IOperationMetaTextResult<string>
	{
		public OperationMetaTextResult(TResult result, string meta) : base(result, meta)
		{
		}

		public OperationMetaTextResult(Exception ex, string meta) : base(ex, meta)
		{
		}
	}
}
