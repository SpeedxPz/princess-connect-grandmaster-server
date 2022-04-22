using System;
using MessagePack;
using Priari.ServerShared.Primitives;

namespace Priari.ServerShared.MessagePackObjects
{
	[MessagePackObject]
	public class BattleBoardResetSkillRecastTimeEventResponse : BattleBoardEventResponse
	{
		[Key(2)]
		public int UniqueKey { get; set; }

		public BattleBoardResetSkillRecastTimeEventResponse() { }
		public BattleBoardResetSkillRecastTimeEventResponse(int matchId, float raisedAt, int uniqueKey)
		{
		}
	}
}
