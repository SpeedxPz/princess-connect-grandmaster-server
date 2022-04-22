using System;
using MessagePack;
using Priari.ServerShared.Primitives;

namespace Priari.ServerShared.MessagePackObjects
{

	[MessagePackObject]
	public class BattleBoardTPHealEventResponse : BattleBoardEventResponse
	{
		[Key(2)]
		public int OperatorUniqueKey { get; set; }

		[Key(3)]
		public int TargetUniqueKey { get; set; }

		[Key(4)]
		public int Heal { get; set; }

		[Key(5)]
		public int TechnicalPoint { get; set; }

		[Key(6)]
		public int PreviousTp { get; set; }

		public BattleBoardTPHealEventResponse() { }

		public BattleBoardTPHealEventResponse(int matchId, float raisedAt, int operatorUniqueKey, int targetUniqueKey, int heal, int technicalPoint, int previousTp)
		{
		}
	}
}
