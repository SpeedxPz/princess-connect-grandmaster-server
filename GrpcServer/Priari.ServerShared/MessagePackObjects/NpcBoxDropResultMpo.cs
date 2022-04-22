using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public struct NpcBoxDropResultMpo
    {
        [Key(0)]
        public int? Gold { get; set; }

        [Key(1)]
        public BattleUnitDataMpo[] Units { get; set; }

        [Key(2)]
        public BattleEquipmentDataMpo[] Equipments { get; set; }

        [Key(3)]
        public int? RankUpToken { get; set; }

        [Key(4)]
        public int BoxGrade { get; set; }


    }
}
