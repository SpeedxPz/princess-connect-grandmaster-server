using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.Enums
{
	public enum BattlePhase
	{
		Invalid,
		Initialized,
		SetupPlayerInfo,
		Preparing,
		Prepared,
		Running,
		Result,
		PreparePick,
		Pick,
		PrepareOverallBuffPick,
		OverallBuffPick,
		GuildBuffRoulette,
		Transitioning,
		Complete,
		Reconnect
	}
}
