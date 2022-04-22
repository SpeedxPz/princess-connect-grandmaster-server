using System;
using MessagePack;
using Priari.ServerShared.Enums;
using Priari.ServerShared.Primitives;

namespace Priari.ServerShared.MessagePackObjects
{
	[MessagePackObject]
	public class BattleBoardEquipmentSkillDamageEventResponse : BattleBoardEventResponse
	{
		[Key(2)]
		public int OperatorUnitUniqueKey { get; set; }

		[Key(3)]
		public int EquipmentUniqueKey { get; set; }

		[Key(4)]
		public int TargetUniqueKey { get; set; }

		[Key(5)]
		public int Life { get; set; }

		[Key(6)]
		public int Damage { get; set; }

		[Key(7)]
		public DamageType DamageType { get; set; }

		[Key(8)]
		public int SkillId { get; set; }

		[Key(9)]
		public bool IsDead { get; set; }

		[Key(10)]
		public int PreviousLife { get; set; }


		public BattleBoardEquipmentSkillDamageEventResponse() { }
		public BattleBoardEquipmentSkillDamageEventResponse(int matchId, float raisedAt, int operatorUnitUniqueKey, int equipmentUniqueKey, int targetUniqueKey, int life, int damage, DamageType damageType, int skillId, bool isDead, int previousLife)
		{
		}

	}
}
