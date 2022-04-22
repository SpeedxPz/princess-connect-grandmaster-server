using System;
using MessagePack;
using Priari.ServerShared.Primitives;

namespace Priari.ServerShared.MessagePackObjects
{
	[MessagePackObject]
	public class BattleBoardWeaponChangeEventResponse : BattleBoardEventResponse
	{

		[Key(2)]
		public int OperatorUniqueKey { get; set; }

		public BattleBoardWeaponChangeEventResponse() { }
		public BattleBoardWeaponChangeEventResponse(int matchId, float raisedAt, int operatorUniqueKey)
		{
		}

	}
}
