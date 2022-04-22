using System;
using MessagePack;
using Priari.ServerShared.Enums;
using Priari.ServerShared.Primitives;

namespace Priari.ServerShared.MessagePackObjects
{
	[MessagePackObject]
	public class BattleBoardCompleteEventResponse : BattleBoardEventResponse
	{
		[Key(2)]
		public bool LastMatchInRound { get; set; }

		[Key(3)]
		public BattleResultType PrimaryResult { get; set; }

		[Key(4)]
		public int PrimaryDamage { get; set; }

		[Key(5)]
		public int PrimaryLife { get; set; }

		[Key(6)]
		public BattleResultType SecondaryResult { get; set; }

		[Key(7)]
		public int SecondaryDamage { get; set; }

		[Key(8)]
		public int SecondaryLife { get; set; }

		[Key(9)]
		public bool TimedOut { get; set; }

		public BattleBoardCompleteEventResponse() { }
		public BattleBoardCompleteEventResponse(int matchId, float raisedAt, bool lastMatchInRound, int primaryResult, int primaryDamage, int primaryLife, BattleResultType secondaryResult, int secondaryDamage, int secondaryLife, bool timedOut)
		{
		}
	}
}
