using MessagePack;
using Priari.ServerShared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public struct BattleGuildBuffDataMpo
    {
        [Key(0)]
        public GuildId GuildId { get; set; }

        [Key(1)]
        public IReadOnlyList<int> GuildBuffIds { get; set; }

        [Key(2)]
        public IReadOnlyList<int> DrawnGuildIds { get; set; }

        [Key(3)]
        public IReadOnlyList<int> TargetUnitIds { get; set; }


    }
}
