using System.Collections.Generic;

namespace Lawson.OperationResult.Interfaces
{
	public interface IQueryOperationMetaResults<TResult, TMeta> : IOperationResultBase
	{
		List<TResult> OperationResult { get; }
		TMeta Meta { get; set; }
	}
}