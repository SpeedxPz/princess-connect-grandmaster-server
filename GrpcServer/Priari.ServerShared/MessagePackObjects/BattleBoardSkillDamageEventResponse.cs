using System;
using MessagePack;
using Priari.ServerShared.Enums;
using Priari.ServerShared.Primitives;

namespace Priari.ServerShared.MessagePackObjects
{
	[MessagePackObject]
	public class BattleBoardSkillDamageEventResponse : BattleBoardEventResponse
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
		public int SkillId { get; set; }

		[Key(7)]
		public bool IsDead { get; set; }

		[Key(8)]
		public bool SwitchMainEffect { get; set; }

		[Key(9)]
		public DamageType DamageType { get; set; }

		[Key(10)]
		public int PreviousLife { get; set; }

		[Key(11)]
		public bool IsCounterDamage { get; set; }


		public BattleBoardSkillDamageEventResponse() { }
		public BattleBoardSkillDamageEventResponse(int matchId, float raisedAt, int operatorUniqueKey, int targetUniqueKey, int life, int damage, int skillId, bool isDead, bool switchMainEffect, DamageType damageType, int previousLife, bool isCounterDamage)
		{
		}

	}
}
