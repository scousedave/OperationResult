using System;

namespace Lawson.OperationResult.Interfaces
{
	public interface ISingleOperationMetaResult<TResult, TMeta> : IOperationMetaResultBase<TMeta>
	{
		TResult OperationResult { get; }
	}
}