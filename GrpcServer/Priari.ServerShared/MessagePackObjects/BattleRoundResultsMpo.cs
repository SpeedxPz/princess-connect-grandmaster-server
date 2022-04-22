using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class BattleRoundResultsMpo
    {
        [Key(0)]
        public int Round { get; set; }

        [Key(1)]
        public BattleRoundResultMpo[] Results { get; set; }

        [Key(2)]
        public BattlePlayerDataMpo[] Players { get; set; }

        [Key(3)]
        public BattleTeamDataMpo[] Teams { get; set; }

        [Key(4)]
        public BattleRoundLotteryResultMpo[] LotteryEquipments { get; set; }

        [Key(5)]
        public Dictionary<int, RewardDataMpo> Rewards { get; set; }

        [Key(6)]
        public bool IsFinished { get; set; }



    }
}
