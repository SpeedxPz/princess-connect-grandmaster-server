using Priari.ServerShared.MessagePackObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.Hub
{
    public interface IMatchMakingHubReceiver
    {
		void OnEntry(MatchMakingEntryResponse response);
		void OnCancel(MatchMakingCancelResponse response);
		void OnJoin(MatchMakingJoinResponse response);
		void OnComplete(MatchMakingCompleteResponse response);
	}
}
