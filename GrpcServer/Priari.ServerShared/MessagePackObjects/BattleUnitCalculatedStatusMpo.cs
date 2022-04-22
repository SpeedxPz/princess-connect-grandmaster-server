using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class BattleUnitCalculatedStatusMpo
    {
        [Key(0)]
        public int UniqueKey { get; set; } //UnitUniqueKey

        [Key(1)]
        public BoardUnitStatusMpo Current { get; set; }

        [Key(2)]
        public BoardUnitStatusMpo Adjusted { get; set; }

        [Key(3)]
        public BoardUnitStatusMpo Base { get; set; }
    }
}
