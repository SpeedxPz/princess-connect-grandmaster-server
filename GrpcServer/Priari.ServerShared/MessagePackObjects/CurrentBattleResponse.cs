using MessagePack;
using Priari.ServerShared.Enums;
using Priari.ServerShared.MessagePack.Formatters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects.User
{
    [MessagePackObject]
    public class CurrentBattleResponse
    {
        [MessagePackFormatter(typeof(UlidMessagePackFormatter))]
        [Key(0)]
        public Ulid BattleId { get; set; }

        [Key(1)]
        public string RouteToken { get; set; } //BattleEngineRouteToken

        [Key(2)] // bin8
        public BattleRule Rule { get; set; }
    }
}
