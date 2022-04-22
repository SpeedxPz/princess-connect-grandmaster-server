using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class BattleUnitCalculatedStatusSetMpo
    {
        [Key(0)]
        public BattleSynergyMpo[] Synergies { get; set; }

        [Key(1)]
        public BattleUnitCalculatedStatusMpo[] UnitStatuses { get; set; }


    }
}
