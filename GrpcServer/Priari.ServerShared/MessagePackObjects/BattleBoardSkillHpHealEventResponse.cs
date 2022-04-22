using System;
using MessagePack;
using Priari.ServerShared.Primitives;

namespace Priari.ServerShared.MessagePackObjects
{
	[MessagePackObject]
	public class BattleBoardSkillHpHealEventResponse : BattleBoardEventResponse
	{
		[Key(2)]
		public int OperatorUniqueKey { get; set; }

		[Key(3)]
		public int TargetUniqueKey { get; set; }

		[Key(4)]
		public int Life { get; set; }

		[Key(5)]
		public int Heal { get; set; }

		[Key(6)]
		public int SkillActionId { get; set; }

		[Key(7)]
		public int PreviousLife { get; set; }

		public BattleBoardSkillHpHealEventResponse() { }
		public BattleBoardSkillHpHealEventResponse(int matchId, float raisedAt, int operatorUniqueKey, int targetUniqueKey, int life, int heal, int skillActionId, int previuousLife)
		{
		}
	}
}
