using MagicOnion;
using Priari.ServerShared.MessagePackObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Priari.ServerShared.Hub
{
    public interface IMatchMakingHub : IStreamingHub<IMatchMakingHub, IMatchMakingHubReceiver>, IStreamingHubMarker, IServiceMarker
    {
        Task EntryAsync(MatchMakingEntryRequest request);

        Task CancelAsync(MatchMakingCancelRequest request);
    }
}
