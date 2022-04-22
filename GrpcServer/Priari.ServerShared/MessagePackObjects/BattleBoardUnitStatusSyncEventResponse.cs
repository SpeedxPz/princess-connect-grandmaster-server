using System;
using MessagePack;
using Priari.ServerShared.Primitives;

namespace Priari.ServerShared.MessagePackObjects
{
	[MessagePackObject]
	public class BattleBoardUnitStatusSyncEventResponse : BattleBoardEventResponse
	{
		[Key(2)]
		public int UniqueKey { get; set; }

		[Key(3)]
		public BoardUnitSyncStatusMpo UnitStatus { get; set; }

		[Key(4)]
		public BoardUnitSyncStatusMpo PreviousUnitStatus { get; set; }

		public BattleBoardUnitStatusSyncEventResponse() { }
		public BattleBoardUnitStatusSyncEventResponse(int matchId, float raisedAt, int uniqueKey, BoardUnitSyncStatusMpo unitStatus, BoardUnitSyncStatusMpo previousUnitStatus)
		{
		}

	}
}
