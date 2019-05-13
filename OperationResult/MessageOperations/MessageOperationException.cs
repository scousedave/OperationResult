//####################################################################################################################################################
// Copyright © 2016, 2017, 2018 by David Henry Lawson - Proprietary and confidential. All Rights Reserved
//
// DO NOT DISTRIBUTE, REDISTRIBUTE OR COMMUNICATE WITHOUT EXPLICIT PERMISSION
//
// NOTICE REGARDING: C:\Projects\QuantumSafe\Shared\Common\MessageOperations\MessageOperationException.cs  
// All information and code contained herein is an original invention of, and the exclusive property of, David Henry Lawson. 
// The intellectual and technical concepts contained herein are proprietary to David Henry Lawson and are protected by trade secret and copyright law.
// Unauthorized dissemination of this information or reproduction of this material via any medium is strictly prohibited
//####################################################################################################################################################

using System;
using LawsonOperationResult.Interfaces;

namespace LawsonOperationResult.MessageOperations
{
	public class MessageOperationException : IMessageOperationException
	{
		public string ExceptionType { get; }
		public string ExceptionMessage { get; }
		public IMessageOperationException InnerException { get; }

		public MessageOperationException(Exception exception)
		{
			ExceptionType = exception.GetType().AssemblyQualifiedName;
			ExceptionMessage = exception.Message;
			if(exception.InnerException != null) InnerException = new MessageOperationException(exception.InnerException);
		}


		public override string ToString()
		{
			var message = $"{ExceptionType} : {ExceptionMessage}";
			if(InnerException != null) message = $"{message}{System.Environment.NewLine} INNER EXCEPTION: {InnerException}{System.Environment.NewLine}";
			return message;
		}
	}
}
