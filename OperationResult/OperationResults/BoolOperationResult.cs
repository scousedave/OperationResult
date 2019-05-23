using System;
using Lawson.OperationResult.Interfaces;

namespace Lawson.OperationResult.OperationResults
{
	public class BoolOperationResult :  OperationResultBase, IBoolOperationResult
	{
		public bool OperationResult => Success;

		public BoolOperationResult(bool result)
			: base(result)
		{
		}

		public BoolOperationResult(Exception ex)
			: base(ex)
		{
		}


	}
}
