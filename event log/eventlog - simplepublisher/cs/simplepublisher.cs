//---------------------------------------------------------------------
//  This file is part of the Microsoft .NET Framework SDK Code Samples.
// 
//  Copyright (C) Microsoft Corporation.  All rights reserved.
// 
//This source code is intended only as a supplement to Microsoft
//Development Tools and/or on-line documentation.  See these other
//materials for detailed information regarding Microsoft code samples.
// 
//THIS CODE AND INFORMATION ARE PROVIDED AS IS WITHOUT WARRANTY OF ANY
//KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
//IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//PARTICULAR PURPOSE.
//---------------------------------------------------------------------

using System;
using System.Collections;
using System.Threading;
using System.Diagnostics.Events;


namespace Microsoft.Sample.SimplePublisher
{
	public class SimplePublisher
	{
		static public void Main(string[] args)
		{
			using(EventLog globalApp = new EventLog("Global/Application", ".", "SimplePublisher"))
			{
				globalApp.WriteEvent(
					1,
					"<ComputerAddedToDomain>" +
					"<Computer>MyComputer</Computer>" +
					"<Domain>MyDomain</Domain>" +
					"</ComputerAddedToDomain>");
			}
			Console.WriteLine("Success!");
		}
		
	}
}
