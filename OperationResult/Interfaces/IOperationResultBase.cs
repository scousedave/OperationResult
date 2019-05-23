
using System;

namespace Lawson.OperationResult.Interfaces
{
	public interface IOperationResultBase
	{
		bool Success { get; }
		Exception ThrownException { get; set; }
		bool HasException { get; }
	}
}