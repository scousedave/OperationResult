using System;
using System.Collections.Generic;
using Lawson.OperationResult.Interfaces;

namespace Lawson.OperationResult.OperationMessageSupport
{
	public class MessageOperationResult : IMessageOperationResult
	{
		public bool Success { get; }
		public int SpecificErrorCode { get; }

		public string FriendlySuccessString { get; }

		public string FriendlyFailureString { get; }


		public List<MessageOperationException> Exceptions { get; }

		public bool FailureIsFinal { get; set; }

		public MessageOperationResult()
		{
			Success = true;
			FriendlySuccessString = "Success!";
		}
		public MessageOperationResult(bool success)
		{
			Exceptions = new List<MessageOperationException>();
			Success = success;
			if (success) FriendlySuccessString = "Success!";
			else FriendlyFailureString = "Failed!";
		}
		public MessageOperationResult(bool success, string message)
		{
			Exceptions = new List<MessageOperationException>();
			Success = success;
			if (success) FriendlySuccessString = message;
			else FriendlyFailureString = message;
		}

		public MessageOperationResult(string message, IEnumerable<Exception> exceptions, bool failureIsFinal = false, int specificErrorCode = 0)
			: this(false, message)
		{
			FailureIsFinal = failureIsFinal;
			SpecificErrorCode = specificErrorCode;
			foreach (Exception exception in exceptions)
			{
				Exceptions.Add(new MessageOperationException(exception));
			}
		}
		
		public MessageOperationResult(string message, Exception exception, bool failureIsFinal = false, int specificErrorCode = 0)
			: this(message, new []{ exception}, failureIsFinal, specificErrorCode)
		{ }

	}
}
