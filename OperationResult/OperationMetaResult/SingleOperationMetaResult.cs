using System;
using Lawson.OperationResult.Interfaces;

namespace Lawson.OperationResult.OperationMetaResult
{
	public class SingleOperationMetaResult<TResult, TMeta> :  OperationMetaResultBase<TMeta>//, ISingleOperationMetaResult<TResult, TMeta>
	{
		public TResult OperationResult { get; }

		public SingleOperationMetaResult(TResult result, TMeta meta)
			: base(result != null, meta)
		{
			OperationResult = result;
		}

		public SingleOperationMetaResult(Exception ex, TMeta meta)
			: base(ex, meta)
		{
		}


	}
}
