using MessagePack;
using Priari.ServerShared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class BattleBoardAttackOperateEventResponse : BattleBoardEventResponse
    {
        [Key(2)]
        public int UniqueKey { get; set; }

        [Key(3)]
        public int TargetUniqueKey { get; set; }

        [Key(4)]
        public int Damage { get; set; }

        [Key(5)]
        public int Life { get; set; }

        [Key(6)]
        public bool IsCritical { get; set; }

        [Key(7)]
        public bool HavePassiveSkillEffect { get; set; }

        [Key(8)]
        public bool IsDead { get; set; }

        [Key(9)]
        public DamageType DamageType { get; set; }

        [Key(10)]
        public int PreviousLife { get; set; }
    }
}
