using System;
using Lawson.OperationResult.Interfaces;

namespace Lawson.OperationResult.OperationResults
{
	public abstract class OperationResultBase : IOperationResultBase
	{
		public bool Success { get;  }

		public Exception ThrownException { get; set; }
		public bool HasException => ThrownException != null;


		protected OperationResultBase()
		{
			Success = true;
		}

		protected OperationResultBase(int affectedRows)
		{
			Success = affectedRows > 0;
		}

		protected OperationResultBase(bool success)
		{
			Success = success;
		}

		protected OperationResultBase(Exception ex)
		{
			Success = false;
			ThrownException = ex;
		}

	}
}
