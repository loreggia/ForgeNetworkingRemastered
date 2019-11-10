﻿using Forge.Serialization;

namespace Forge.Networking.Messaging
{
	public interface IMessage
	{
		IMessageReceipt Receipt { get; set; }
		IMessageInterpreter Interpreter { get; }
		void Interpret(INetworkContainer host);
		void Serialize(BMSByte buffer);
		void Deserialize(BMSByte buffer);
	}
}