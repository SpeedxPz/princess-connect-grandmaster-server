using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public struct BattleTeamDataMpo
    {
        [Key(0)]
        public int TeamId { get; set; }

        [Key(1)]
        public int Life { get; set; }

        [Key(2)]
        public DateTimeOffset DefeatAt { get; set; }


    }
}
