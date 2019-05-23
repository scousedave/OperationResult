using System;
using Lawson.OperationResult.Interfaces;

namespace Lawson.OperationResult.OperationMessageSupport
{
	public class MessageOperationException : Exception
	{
		public string ExceptionType { get; }
		public string ExceptionMessage { get; }

		public MessageOperationException(Exception exception)
			: base(exception.Message, exception)
		{
			ExceptionType = exception.GetType().AssemblyQualifiedName;
			ExceptionMessage = exception.Message;
		}


		public override string ToString()
		{
			var message = $"{ExceptionType} : {ExceptionMessage}";
			if(InnerException != null) message = $"{message}{System.Environment.NewLine} INNER EXCEPTION: {InnerException}{System.Environment.NewLine}";
			return message;
		}
	}
}
