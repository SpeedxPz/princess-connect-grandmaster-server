using System;
using MessagePack;
using Priari.ServerShared.Primitives;

namespace Priari.ServerShared.MessagePackObjects
{
	[MessagePackObject]
	public class BattleBoardSkillTPDamageEventResponse : BattleBoardTPDamageEventResponse
	{
        
        [Key(6)]
		public int SkillActionId { get; set; }

		public BattleBoardSkillTPDamageEventResponse() { }
		public BattleBoardSkillTPDamageEventResponse(int matchId, float raisedAt, int operatorUnitqueKey, int targetUniqueKey, int damage, int technicalPoint) : base(matchId, raisedAt, operatorUnitqueKey, targetUniqueKey, damage, technicalPoint)
		{
		}

	}
}
