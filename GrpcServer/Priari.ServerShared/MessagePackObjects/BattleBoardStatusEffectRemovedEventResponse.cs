using System;
using MessagePack;
using Priari.ServerShared.Enums;
using Priari.ServerShared.Primitives;

namespace Priari.ServerShared.MessagePackObjects
{
	[MessagePackObject]
	public class BattleBoardStatusEffectRemovedEventResponse : BattleBoardEventResponse
	{
		[Key(2)]
		public int UniqueKey { get; set; }

		[Key(3)]
		public int SkillActionId { get; set; }

		[Key(4)]
		public StatusEffectVfxType StatusEffectVfxType { get; set; }


		public BattleBoardStatusEffectRemovedEventResponse()
        {

        }

		public BattleBoardStatusEffectRemovedEventResponse(int matchId, float raisedAt, int uniqueKey, int skillActionId, StatusEffectVfxType statusEffectVfxType)
		{
		}
	}
}
