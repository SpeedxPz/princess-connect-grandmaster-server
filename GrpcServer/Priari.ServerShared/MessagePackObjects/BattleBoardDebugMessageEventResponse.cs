using System;
using MessagePack;
using Priari.ServerShared.Primitives;

namespace Priari.ServerShared.MessagePackObjects
{
	[MessagePackObject]
	public class BattleBoardDebugMessageEventResponse : BattleBoardEventResponse
	{
		[Key(2)]
		public string Message { get; set; }

		public BattleBoardDebugMessageEventResponse() { }
		public BattleBoardDebugMessageEventResponse(int matchId, float raisedAt, string message)
		{
		}

	}
}
