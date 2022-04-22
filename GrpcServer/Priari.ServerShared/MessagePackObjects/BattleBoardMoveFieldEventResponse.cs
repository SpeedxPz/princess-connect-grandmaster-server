using System;
using MessagePack;
using Priari.ServerShared.Primitives;

namespace Priari.ServerShared.MessagePackObjects
{
	[MessagePackObject]
	public class BattleBoardMoveFieldEventResponse : BattleBoardEventResponse
	{
		[Key(2)]
		public int UniqueKey { get; set; }

		[Key(3)]
		public int X { get; set; }

		[Key(4)]
		public int Y { get; set; }

		[Key(5)]
		public bool IsJump { get; set; }

		[Key(6)]
		public int PreviousX { get; set; }

		[Key(7)]
		public int PreviousY { get; set; }

		public BattleBoardMoveFieldEventResponse() { }
		public BattleBoardMoveFieldEventResponse(int matchId, float raisedAt, int uniqueKey, int x, int y, bool isJump, int prevX, int prevY)
		{
		}

	}
}
