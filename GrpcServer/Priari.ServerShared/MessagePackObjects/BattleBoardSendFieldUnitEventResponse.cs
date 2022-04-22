using System;
using MessagePack;
using Priari.ServerShared.Primitives;

namespace Priari.ServerShared.MessagePackObjects
{
	[MessagePackObject]
	public class BattleBoardSendFieldUnitEventResponse : BattleBoardEventResponse
	{
		[Key(2)]
		public int? SendPlayerId { get; set; }

		[Key(3)]
		public int[] SendUnitUniqueKeys { get; set; }

		public BattleBoardSendFieldUnitEventResponse() { }
		public BattleBoardSendFieldUnitEventResponse(int matchId, float raisedAt, int? sendId, int[] sendUnitUniqueKeys)
		{
		}

	}
}
