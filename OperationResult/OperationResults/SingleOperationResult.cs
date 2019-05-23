using System;
using Lawson.OperationResult.Interfaces;

namespace Lawson.OperationResult.OperationResults
{
	public class SingleOperationResult<T> :  OperationResultBase, ISingleOperationResult<T>
	{
		public T OperationResult { get; set; }

		public SingleOperationResult(T result)
			: base(result != null)
		{
			OperationResult = result;
		}

		public SingleOperationResult(Exception ex)
			: base(ex)
		{
		}


	}
}
