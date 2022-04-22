using MessagePack;
using Priari.ServerShared.MessagePack.Formatters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class MatchMakingCompleteResponse
    {
        [MessagePackFormatter(typeof(UlidMessagePackFormatter))]
        [Key(0)]
        public Ulid BattleId { get; set; }

        [Key(1)]
        public string RouteToken { get; set; }

    }
}
