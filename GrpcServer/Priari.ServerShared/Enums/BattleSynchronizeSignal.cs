using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.Enums
{
	public enum BattleSynchronizeSignal
	{
		Initialized,
		BeginRound,
		RoundResultReady,
		RoundResultCompleted,
		InitialDistributeUnits
	}
}
