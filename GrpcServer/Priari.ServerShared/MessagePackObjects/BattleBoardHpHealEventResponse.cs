using System;
using MessagePack;
using Priari.ServerShared.Primitives;

namespace Priari.ServerShared.MessagePackObjects
{
	[MessagePackObject]
	public class BattleBoardHpHealEventResponse : BattleBoardEventResponse
	{
		[Key(2)]
		public int UniqueKey { get; set; }

		[Key(3)]
		public int TargetUniqueKey { get; set; }

		[Key(4)]
		public int Life { get; set; }

		[Key(5)]
		public int Heal { get; set; }

		[Key(6)]
		public int PreviousLife { get; set; }

		[Key(7)]
		public bool ForceHeal { get; set; }

		[Key(8)]
		public bool EmitOnDead { get; set; }
		public BattleBoardHpHealEventResponse () { }
		public BattleBoardHpHealEventResponse(int matchId, float raisedAt, int uniqueKey, int targetUniqueKey, int life, int heal, int previousLife, bool forceHeal, bool emitOnDead)
		{
		}

	}
}
