using System.Collections.Generic;

namespace Lawson.OperationResult.Interfaces
{
	public interface IQueryOperationResult<T> : IOperationResultBase
	{
		List<T> OperationResult { get; }
	}
}