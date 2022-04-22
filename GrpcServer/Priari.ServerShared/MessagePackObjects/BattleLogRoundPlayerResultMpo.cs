using MessagePack;
using Priari.ServerShared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class BattleLogRoundPlayerResultMpo
    {
        [Key(0)]
        public int? ViewerId { get; set; }

        [Key(1)]
        public string Name { get; set; }

        [Key(2)]
        public List<BattleUnitDataMpo> Party { get; set; }

        [Key(3)]
        public List<BattleSynergyMpo> Synergies { get; set; }

        [Key(4)]
        public bool IsNpc { get; set; }

        [Key(5)]
        public int WinningStreakNum { get; set; }

        [Key(6)]
        public int PrevWinningStreakNum { get; set; }

        [Key(7)]
        public int LosingStreakNum { get; set; }

        [Key(8)]
        public int PrevLosingStreakNum { get; set; }

        [Key(9)]
        public BattleResultType JudgeResult { get; set; }


    }
}
