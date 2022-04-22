using MessagePack;
using Priari.ServerShared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public struct UserReconnectResponse
    {
        [Key(0)]
        public BattlePhase Phase { get; set; }

        [Key(1)]
        public BattlePlayerDataMpo[] Players { get; set; }

        [Key(2)]
        public NpcRoundStartResponse[] NpcRoundStartResponse { get; set; }

        [Key(3)]
        public int Round { get; set; }

        [Key(4)]
        public TimeSpan? RemainTime { get; set; }

        [Key(5)]
        public BattleResultInfoMpo[] BattleResults { get; set; }

        [Key(6)]
        public BattleTeamDataMpo[] Teams { get; set; }


    }
}
