using System;
using MessagePack;
using Priari.ServerShared.Primitives;

namespace Priari.ServerShared.MessagePackObjects
{
	[MessagePackObject]
	public class BattleBoardTargetDeadEventResponse : BattleBoardEventResponse
	{
		[Key(2)]
		public int UniqueKey { get; set; }

		public BattleBoardTargetDeadEventResponse() { }
		public BattleBoardTargetDeadEventResponse(int matchId, float raisedAt, int uniqueKey)
		{
		}
	}
}
