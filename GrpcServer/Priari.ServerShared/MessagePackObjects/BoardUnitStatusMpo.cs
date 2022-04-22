using MessagePack;
using Priari.ServerShared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class BoardUnitStatusMpo
    {
        [Key(0)]
        public int Attack { get; set; }

        [Key(1)]
        public int MagicAttack { get; set; }

        [Key(2)]
        public int Life { get; set; }

        [Key(3)]
        public int Defense { get; set; }

        [Key(4)]
        public int MagicDefense { get; set; }

        [Key(5)]
        public float AttackRecastTime { get; set; }

        [Key(6)]
        public float MoveRecastTime { get; set; }

        [Key(7)]
        public float RemainAttackRecastTime { get; set; }

        [Key(8)]
        public float RemainMoveRecastTime { get; set; }

        [Key(9)]
        public float AttackRecastTimeTickRate { get; set; }

        [Key(10)]
        public float MoveRecastTimeTickRate { get; set; }

        [Key(11)]
        public int TechnicalPoint { get; set; }

        [Key(12)]
        public int MaxTechnicalPoint { get; set; }

        [Key(13)]
        public float TechnicalPointRate { get; set; }

        [Key(14)]
        public float AttackRange { get; set; }

        [Key(15)]
        public BoardUnitStatusSpecialState SpecialState { get; set; }

        [Key(16)]
        public HashSet<int> HateUniqueKeys { get; set; }
    }
}
