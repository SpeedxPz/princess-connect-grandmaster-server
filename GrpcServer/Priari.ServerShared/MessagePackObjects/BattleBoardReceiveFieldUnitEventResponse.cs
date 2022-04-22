using System;
using MessagePack;
using Priari.ServerShared.Primitives;

namespace Priari.ServerShared.MessagePackObjects
{
	[MessagePackObject]
	public class BattleBoardReceiveFieldUnitEventResponse : BattleBoardEventResponse
	{
		[Key(2)]
		public int? SendPlayerId { get; set; }

		[Key(3)]
		public int? ReceivePlayerId { get; set; }

		[Key(4)]
		public int[] SendUnitUniqueKeys { get; set; }

		[Key(5)]
		public BattleUnitDataMpo[] ReceiveUnits { get; set; }

		[Key(6)]
		public BattleUnitCalculatedStatusSetMpo CalculatedStatus { get; set; }

		public BattleBoardReceiveFieldUnitEventResponse() { }
		public BattleBoardReceiveFieldUnitEventResponse(int matchId, float raisedAt, int? sendId, int? receiveId, int[] sendUnitUniqueKeys, BattleUnitDataMpo[] receiveUnits, BattleUnitCalculatedStatusSetMpo calculatedStatus)
		{
		}

	}
}
