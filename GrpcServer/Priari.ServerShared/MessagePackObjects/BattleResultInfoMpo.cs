using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class BattleResultInfoMpo
    {
        [Key(0)]
        public int Ranking { get; set; }

        [Key(1)]
        public int ViewerId { get; set; }

        [Key(2)]
        public string PlayerName { get; set; }

        [Key(3)]
        public int TeamId { get; set; }

        [Key(4)]
        public int WinCount { get; set; }

        [Key(5)]
        public int LoseCount { get; set; }

        [Key(6)]
        public int LivedRoundCount { get; set; }

        [Key(7)]
        public int KillCount { get; set; }

        [Key(8)]
        public TimeSpan TimeOfSurvival { get; set; }

        [Key(9)]
        public int TakenDamageCount { get; set; }

        [Key(10)]
        public int Gold { get; set; }

        [Key(11)]
        public int Rank { get; set; }

        [Key(12)]
        public List<BattleUnitDataMpo> FieldUnitList { get; set; }

        [Key(13)]
        public bool IsWin { get; set; }

        [Key(14)]
        public int TeamRanking { get; set; }

        [Key(15)]
        public int TotalGold { get; set; }

        [Key(16)]
        public BattleSynergyMpo[] Synergies { get; set; }

        [Key(17)]
        public bool IsAbandoned { get; set; }


    }
}
