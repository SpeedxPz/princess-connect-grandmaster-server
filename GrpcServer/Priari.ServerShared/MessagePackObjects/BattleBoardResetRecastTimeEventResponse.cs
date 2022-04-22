using System;
using MessagePack;
using Priari.ServerShared.Primitives;

namespace Priari.ServerShared.MessagePackObjects
{
	[MessagePackObject]
	public class BattleBoardResetRecastTimeEventResponse : BattleBoardEventResponse
	{
		[Key(2)]
		public int UniqueKey { get; set; }

		public BattleBoardResetRecastTimeEventResponse() { }
		public BattleBoardResetRecastTimeEventResponse(int matchId, float raisedAt, int uniqueKey)
		{
		}

	}
}
