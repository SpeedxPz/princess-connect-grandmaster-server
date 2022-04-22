using System;
using System.Collections.Generic;
using MessagePack;
using Priari.ServerShared.Primitives;

namespace Priari.ServerShared.MessagePackObjects
{
	[MessagePackObject]
	public class BattleBoardSkillOperateEventResponse : BattleBoardEventResponse
	{
		[Key(2)]
		public int UniqueKey { get; set; }

		[Key(3)]
		public BattleBoardSkillOperateEventResponse.SkillActionResultResponse[] SkillActionResults { get; set; }

		[Key(4)]
		public int SkillId { get; set; }

		[Key(5)]
		public Dictionary<int, BoardUnitStatusMpo> PreviousTargetStatus { get; set; }

		public BattleBoardSkillOperateEventResponse() { }
		public BattleBoardSkillOperateEventResponse(int matchId, float raisedAt, int uniqueKey, BattleBoardSkillOperateEventResponse.SkillActionResultResponse[] skillActionResults, int skillId, Dictionary<int, BoardUnitStatusMpo> previousTargetStatus)
		{
		}

		[MessagePackObject]
		public class SkillActionResultResponse
		{

			[Key(0)]
			public int SkillActionId { get; set; }

			[Key(1)]
			public Dictionary<int, int> Targets { get; set; }

			public SkillActionResultResponse()
			{
			}

		}
	}
}
