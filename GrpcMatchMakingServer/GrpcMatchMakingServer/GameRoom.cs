using MagicOnion.Server.Hubs;
using System;
using System.Collections.Generic;

namespace Priari.MatchMakingServer
{
    public class GameRoom
    {
        public IGroup group;
        public string GroupId;
        public List<Player> players;
    }

    public class Player
    {
        public Ulid EntryId { get; set; }
        public int ViewerId { get; set; }
        public int AvartarId { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
    }
}
