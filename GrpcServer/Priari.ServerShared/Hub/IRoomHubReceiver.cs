using MessagePack;
using Priari.ServerShared.Enums;
using Priari.ServerShared.MessagePack.Formatters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.Hub
{
    public interface IRoomHubReceiver
    {
       /* void OnCreate(RoomDataMpo newRoom);
        void OnDelete(RoomId deletedRoomId);
        void OnJoin(RoomDataMpo joinedRoom);
        void OnLeave(RoomDataMpo LeavedRoom);
        [MessagePackFormatter(typeof(YeetFormatter))]
        void OnBattleStart( Ulid battleId, string routeToken, string roomId, BattleRule rule);*/
    }
}
