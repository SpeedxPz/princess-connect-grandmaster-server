using MagicOnion;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Priari.ServerShared.Hub
{
    public interface IRoomHub : IStreamingHub<IRoomHub, IRoomHubReceiver>, IStreamingHubMarker, IServiceMarker
    {
       /* Task<RoomDataMpo[]> WatchStartAsync();
        Task WatchFinishAsync();
        Task<RoomId> CreateAsync(RoomCreateRequest request);
        Task DeleteAsync(RoomId roomId);
        Task JoinAsync(RoomJoinRequest request);
        Task LeaveAsync();

        Task PingHeartbeatAsync();
        Task CreateDummyAndJoinAsync(RoomJoinRequest request, DummyKindId dummyKind);*/
    }
}
