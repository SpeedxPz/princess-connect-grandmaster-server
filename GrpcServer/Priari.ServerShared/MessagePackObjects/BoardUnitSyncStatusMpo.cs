using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class BoardUnitSyncStatusMpo
    {
        [Key(0)]
        public int Attack { get; set; }

        [Key(1)]
        public int MagicAttack { get; set; }

        [Key(1)]
        public int Defense { get; set; }

        [Key(2)]
        public int MagicDefense { get; set; }

        [Key(3)]
        public float AttackRecastTime { get; set; }

        [Key(4)]
        public float MoveRecastTime { get; set; }

        [Key(5)]
        public float AttackRecastTimeTickRate { get; set; }

        [Key(6)]
        public float MoveRecastTimeTickRate { get; set; }

        [Key(7)]
        public int MaxTechnicalPoint { get; set; }
    }
}
