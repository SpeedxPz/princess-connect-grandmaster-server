using System;
using MessagePack;
using Priari.ServerShared.Primitives;

namespace Priari.ServerShared.MessagePackObjects
{
	[MessagePackObject]
	public class BattleBoardIntoGimmickFieldCellEventResponce : BattleBoardEventResponse
	{
		[Key(2)]
		public int UniqueKey { get; set; }

		[Key(3)]
		public FieldCellDataMpo FieldCellDataMpo { get; set; }

		public BattleBoardIntoGimmickFieldCellEventResponce() { }
		public BattleBoardIntoGimmickFieldCellEventResponce(int matchId, float raisedAt, int uniqueKey, FieldCellDataMpo fieldCellDataMpo)
		{
		}
	}
}
