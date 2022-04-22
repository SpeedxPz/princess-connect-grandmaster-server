using System;
using MessagePack;
using Priari.ServerShared.Primitives;

namespace Priari.ServerShared.MessagePackObjects
{

	[MessagePackObject]
	public class BattleBoardRushOperateEventResponse : BattleBoardEventResponse
	{
		[Key(2)]
		public int UniqueKey { get; set; }

		[Key(3)]
		public int X { get; set; }

		[Key(4)]
		public int Y { get; set; }

		[Key(5)]
		public bool BackToCurrentPosition { get; set; }

		[Key(6)]
		public int PreviousX { get; set; }

		[Key(7)]
		public int PreviousY { get; set; }

		public BattleBoardRushOperateEventResponse() { }
		public BattleBoardRushOperateEventResponse(int matchId, float raisedAt, int uniqueKey, int x, int y, bool backToCurrentPosition, int prevX, int prevY)
		{
		}

	}
}
