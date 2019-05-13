//####################################################################################################################################################
// Copyright © 2016, 2017, 2018 by David Henry Lawson - Proprietary and confidential. All Rights Reserved
//
// DO NOT DISTRIBUTE, REDISTRIBUTE OR COMMUNICATE WITHOUT EXPLICIT PERMISSION
//
// NOTICE REGARDING: C:\Projects\QuantumSafe\Shared\Common\MessageOperations\MessageOperationResult.cs  
// All information and code contained herein is an original invention of, and the exclusive property of, David Henry Lawson. 
// The intellectual and technical concepts contained herein are proprietary to David Henry Lawson and are protected by trade secret and copyright law.
// Unauthorized dissemination of this information or reproduction of this material via any medium is strictly prohibited
//####################################################################################################################################################

using System;
using System.Collections.Generic;
using LawsonOperationResult.Interfaces;

namespace LawsonOperationResult.MessageOperations
{
	public class MessageOperationResult : IMessageOperationResult
	{
		public bool Success { get; }
		public int SpecificErrorCode { get; }

		public string FriendlySuccessString { get; }

		public string FriendlyFailureString { get; }


		public List<IMessageOperationException> Exceptions { get; }

		public bool FailureIsFinal { get; set; }

		public MessageOperationResult()
		{
			Success = true;
			FriendlySuccessString = "Success!";
		}
		public MessageOperationResult(bool success)
		{
			Exceptions = new List<IMessageOperationException>();
			Success = success;
			if (success) FriendlySuccessString = "Success!";
			else FriendlyFailureString = "Failed!";
		}
		public MessageOperationResult(bool success, string message)
		{
			Exceptions = new List<IMessageOperationException>();
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
