using System.Collections.Generic;
using Lawson.OperationResult.OperationMessageSupport;

namespace Lawson.OperationResult.Interfaces
{
	public interface IMessageOperationResult
	{
		bool Success { get; }
		int SpecificErrorCode { get; }
		string FriendlySuccessString { get; }
		string FriendlyFailureString { get; }
		List<MessageOperationException> Exceptions { get; }
		bool FailureIsFinal { get; set; }
	}
}