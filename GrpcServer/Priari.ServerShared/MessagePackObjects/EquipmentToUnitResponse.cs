using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class EquipmentToUnitResponse
    {
        [Key(0)]
        public int ViewerId { get; set; }

        [Key(1)]
        public BattlePlayerDataMpo PlayerData { get; set; }

        [Key(2)]
        public BattleUnitDataMpo UnitData { get; set; }
    }
}
