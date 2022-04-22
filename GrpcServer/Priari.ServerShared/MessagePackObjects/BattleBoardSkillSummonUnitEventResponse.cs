using System;
using MessagePack;
using Priari.ServerShared.Primitives;

namespace Priari.ServerShared.MessagePackObjects
{
	[MessagePackObject]
	public class BattleBoardSkillSummonUnitEventResponse : BattleBoardEventResponse
	{
		[Key(2)]
		public int UniqueKey { get; set; }

		[Key(3)]
		public BattleUnitDataMpo[] AddUnits { get; set; }

		[Key(4)]
		public BattleUnitCalculatedStatusSetMpo CalculatedStatus { get; set; }

		[Key(5)]
		public int SkillActionId { get; set; }

		public BattleBoardSkillSummonUnitEventResponse() { }
		public BattleBoardSkillSummonUnitEventResponse(int matchId, float raisedAt, int uniqueKey, BattleUnitDataMpo[] fieldUnits, BattleUnitCalculatedStatusSetMpo calculatedStatus, int skillActionId)
		{
		}

	}
}
