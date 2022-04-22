using System;
using MessagePack;
using Priari.ServerShared.Primitives;

namespace Priari.ServerShared.MessagePackObjects
{
	[MessagePackObject]
	public class BattleBoardEquipEquipmentHasPassiveSkillEventResponse : BattleBoardEventResponse
	{
		[Key(2)]
		public int OperatorUnitUniqueKey { get; set; }

		[Key(3)]
		public int EquipmentUniqueKey { get; set; }

		public BattleBoardEquipEquipmentHasPassiveSkillEventResponse() { }
		public BattleBoardEquipEquipmentHasPassiveSkillEventResponse(int matchId, float raisedAt, int operatorUnitUniqueKey, int equipmentUniqueKey)
		{
		}

	
	}
}
