using System;
using MessagePack;
using Priari.ServerShared.Primitives;

namespace Priari.ServerShared.MessagePackObjects
{
	[MessagePackObject]
	public class BattleBoardSkillTPHealEventResponse : BattleBoardTPHealEventResponse
	{

        [Key(7)]
		public int SkillActionId { get; set; }

		public BattleBoardSkillTPHealEventResponse()
        {

        }

		public BattleBoardSkillTPHealEventResponse(int matchId, float raisedAt, int operatorUniqueKey, int targetUniqueKey, int heal, int technicalPoint, int previousTp) : base(matchId, raisedAt, operatorUniqueKey, targetUniqueKey, heal, technicalPoint, previousTp)
		{
		}

	}
}
