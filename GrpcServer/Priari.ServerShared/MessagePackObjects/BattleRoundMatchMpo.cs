using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class BattleRoundMatchMpo
    {
        [Key(0)]
        public int Id { get; set; }

        [Key(1)]
        public int PrimaryViewerId { get; set; }

        [Key(2)]
        public BattleUnitDataMpo[] PrimaryUnits { get; set; }

        [Key(3)]
        public int? SecondaryViewerId { get; set; }

        [Key(4)]
        public BattleUnitDataMpo[] SecondaryUnits { get; set; }

        [Key(5)]
        public int? ShadowViewerId { get; set; }

        [Key(6)]
        public BattleUnitCalculatedStatusSetMpo PrimaryFieldUnitCalculatedStatus { get; set; }

        [Key(7)]
        public BattleUnitCalculatedStatusSetMpo SecondaryFieldUnitCalculatedStatus { get; set; }
    }
}
