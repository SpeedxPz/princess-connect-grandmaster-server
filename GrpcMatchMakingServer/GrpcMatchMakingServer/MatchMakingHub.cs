using MagicOnion.Server.Hubs;
using Priari.ServerShared.Hub;
using Priari.ServerShared.MessagePackObjects;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Threading;
using Grpc.Net.Client;

namespace Priari.MatchMakingServer
{
    public class MatchMakingHub : StreamingHubBase<IMatchMakingHub, IMatchMakingHubReceiver>, IMatchMakingHub
    {
        public static MatchMakingHub instance;
        List<GameRoom> gameRooms = new List<GameRoom>();
        public static IGroup group;
        public async Task CancelAsync(MatchMakingCancelRequest request)
        {

            GameRoom room = gameRooms.Find(room => room.players.Exists( p => p.EntryId == request.EntryId));
            Player player = room.players.Find(p => p.EntryId == request.EntryId);

            room.players.Remove(player);

            MatchMakingCancelResponse cancelResp = new MatchMakingCancelResponse();
            var users = new List<MatchMakingUserDataMpo>();
            cancelResp.GroupUsers = users.ToArray();
            cancelResp.CanceledEntryId = request.EntryId;
            Broadcast(room.group).OnCancel(cancelResp);

            await room.group.RemoveAsync(Context);

            if (room.players.Count <= 0)
            {
                gameRooms.Remove(room);
            }
        }

        public async Task EntryAsync(MatchMakingEntryRequest request)
        {

            foreach (var data in Context.CallContext.RequestHeaders)
            {
                Console.WriteLine(data);
            }

            GameRoom room = gameRooms.Find(room => room.players.Count < 8);
            if (room == null)
            {
                room = new GameRoom();
                room.players = new List<Player>();
                room.GroupId = Ulid.NewUlid().ToString();
                gameRooms.Add(room);
            }

            room.group = await Group.AddAsync(room.GroupId);

            var headers = Context.CallContext.RequestHeaders.Get("authorization");
            var jwt = headers.Value.Replace("Bearer ", "");
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(jwt);
            
            var entryId = Ulid.NewUlid();

            Player player = new Player();
            player.EntryId = entryId;
            player.Name = jwtSecurityToken.Payload["DisplayName"].ToString();
            player.ViewerId = int.Parse(jwtSecurityToken.Payload["ViewerId"].ToString());
            player.AvartarId = 1105901;
            player.Grade = 1;

            room.players.Add(player);
            

            MatchMakingJoinResponse resp = new MatchMakingJoinResponse();
            var users = new List<MatchMakingUserDataMpo>();
            foreach (var p in room.players)
            {
                users.Add(new MatchMakingUserDataMpo(p.Name, p.AvartarId, p.Grade, p.ViewerId));
                users.Add(new MatchMakingUserDataMpo(p.Name, p.AvartarId, p.Grade, 5));
                users.Add(new MatchMakingUserDataMpo(p.Name, p.AvartarId, p.Grade, 6));
                users.Add(new MatchMakingUserDataMpo(p.Name, p.AvartarId, p.Grade, 7));
                users.Add(new MatchMakingUserDataMpo(p.Name, p.AvartarId, p.Grade, 8));
                users.Add(new MatchMakingUserDataMpo(p.Name, p.AvartarId, p.Grade, 9));
                users.Add(new MatchMakingUserDataMpo(p.Name, p.AvartarId, p.Grade, 10));
                users.Add(new MatchMakingUserDataMpo(p.Name, p.AvartarId, p.Grade, 11));
            }
            resp.GroupUsers = users.ToArray();

            MatchMakingEntryResponse entryResp = new MatchMakingEntryResponse();
            entryResp.DummyKindId = 0;
            entryResp.EntryId = entryId;


            BroadcastToSelf(room.group).OnEntry(entryResp);
            Broadcast(room.group).OnJoin(resp);

            Console.WriteLine(room.players.Count);
            if(room.players.Count == 1)
            {
                Thread.Sleep(2000);
                Console.WriteLine("Call Start");
                MatchMakingCompleteResponse respCompleted = new MatchMakingCompleteResponse();
                respCompleted.BattleId = Ulid.NewUlid();
                respCompleted.RouteToken = ""; // Route JWT
                Broadcast(room.group).OnComplete(respCompleted);
            }


            return;
        }

    }
}
