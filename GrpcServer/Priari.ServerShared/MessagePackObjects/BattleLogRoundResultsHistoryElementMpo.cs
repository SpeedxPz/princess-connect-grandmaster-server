using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class BattleLogRoundResultsHistoryElementMpo
    {
        [Key(0)]
        public int Round { get; set; }

        [Key(1)]
        public bool IsNpcRound { get; set; }

        [Key(2)]
        public int RoundCycleCount { get; set; }

        [Key(3)]
        public int CycleRoundNumber { get; set; }

        [Key(4)]
        public int? WinnerViewerId { get; set; }

        [Key(5)]
        public BattleLogRoundPlayerResultMpo Primary { get; set; }

        [Key(6)]
        public BattleLogRoundPlayerResultMpo Secondary { get; set; }

        [Key(7)]
        public bool IsFinished { get; set; }


    }
}
