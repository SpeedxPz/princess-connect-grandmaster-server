using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class BattleRoundBeginDataMpo
    {
        [Key(0)]
        public BattlePlayerDataMpo[] Players { get; set; }

        [Key(1)]
        public BattleRoundMatchMpo[] Matches { get; set; }

        [Key(2)]
        public BattleTeamDataMpo[] Teams { get; set; }


    }
}
