using System;
using Lawson.OperationResult.Interfaces;

namespace Lawson.OperationResult.OperationMetaResult
{
	public class BoolOperationMetaResult<TMeta> :  OperationMetaResultBase<TMeta>, IBoolOperationMetaResult<TMeta>
	{
		public bool OperationResult => Success;

		public BoolOperationMetaResult(bool success, TMeta meta) : base(success, meta)
		{
		}

		public BoolOperationMetaResult(Exception ex, TMeta meta) : base(ex, meta)
		{
		}
	}
}
