using System;
using MessagePack;
using Priari.ServerShared.Primitives;

namespace Priari.ServerShared.MessagePackObjects
{
	[MessagePackObject]
	public class BattleBoardNopEventResponse : BattleBoardEventResponse
	{
		public BattleBoardNopEventResponse() { }
		public BattleBoardNopEventResponse(int matchId, float raisedAt)
		{
		}
	}
}
