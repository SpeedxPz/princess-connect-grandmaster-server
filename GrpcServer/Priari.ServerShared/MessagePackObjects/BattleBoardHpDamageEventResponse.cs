using System;
using MessagePack;
using Priari.ServerShared.Enums;
using Priari.ServerShared.Primitives;

namespace Priari.ServerShared.MessagePackObjects
{
	[MessagePackObject]
	public class BattleBoardHpDamageEventResponse : BattleBoardEventResponse
	{
		[Key(2)]
		public int OperatorUniqueKey { get; set; }

		[Key(3)]
		public int TargetUniqueKey { get; set; }

		[Key(4)]
		public int Life { get; set; }

		[Key(5)]
		public int Damage { get; set; }

		[Key(6)]
		public bool IsDead { get; set; }

		[Key(7)]
		public AttackType AttackType { get; set; }

		[Key(8)]
		public int PreviousLife { get; set; }
		
		public BattleBoardHpDamageEventResponse() { }
		public BattleBoardHpDamageEventResponse(int matchId, float raisedAt, int operatorUniqueKey, int targetUniqueKey, int life, int damage, bool isDead, AttackType type, int previousLife)
		{
		}

	
	}
}
