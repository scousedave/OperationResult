using System;
using Lawson.OperationResult.Interfaces;
using Lawson.OperationResult.OperationResults;

namespace Lawson.OperationResult.OperationMetaResult
{
	public abstract class OperationMetaResultBase<TMeta> : OperationResultBase, IOperationMetaResultBase<TMeta>
	{
		public TMeta Meta { get; set; }

		protected OperationMetaResultBase(TMeta meta)
		{
			Meta = meta;
		}

		protected OperationMetaResultBase(int affectedRows, TMeta meta)
			: base(affectedRows)
		{
			Meta = meta;
		}

		protected OperationMetaResultBase(bool success, TMeta meta)
			: base (success)
		{
			Meta = meta;
		}

		protected OperationMetaResultBase(Exception ex, TMeta meta)
			: base(ex)
		{
			Meta = meta;
		}

	}
}
