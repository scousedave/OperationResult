using System.Collections.Generic;

namespace Lawson.OperationResult.Interfaces
{
	public interface IQueryOperationMetaResult<TResult, TMeta> : IOperationResultBase
	{
		List<TResult> OperationResult { get; }
		TMeta Meta { get; set; }
	}
}