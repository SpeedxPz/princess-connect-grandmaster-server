using System;
using MessagePack;
using Priari.ServerShared.Primitives;

namespace Priari.ServerShared.MessagePackObjects
{
	[MessagePackObject]
	public class BattleBoardBoxDropEventResponse : BattleBoardEventResponse
	{
		[Key(2)]
		public int UniqueKey { get; set; }

		[Key(3)]
		public NpcBoxDropResultMpo[] Boxes { get; set; }

		public BattleBoardBoxDropEventResponse() { }

		public BattleBoardBoxDropEventResponse(int matchId, float raisedAt, int uniqueKey, NpcBoxDropResultMpo[] boxes)
		{
		}


	}
}
