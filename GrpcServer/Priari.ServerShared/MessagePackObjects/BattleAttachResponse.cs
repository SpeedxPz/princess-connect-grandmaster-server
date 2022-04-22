using MessagePack;
using Priari.ServerShared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class BattleAttachResponse
    {
        [Key(0)]
        public int AttachedViewerId { get; set; }

        [Key(1)]
        public BattlePlayerDataMpo[] Players { get; set; }

        [Key(2)]
        public BattleTeamDataMpo[] Teams { get; set; }

        [Key(3)]
        public BattleGuildBuffDataMpo? GuildBuffData { get; set; }

        [Key(4)]
        public BattlePhase? CurrentPhase { get; set; }


    }
}
