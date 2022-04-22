using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class BossRoundStartResponse
    {
        [Key(0)]
        public BattlePlayerDataMpo Player { get; set; }

        [Key(1)]
        public BattleUnitDataMpo[] NpcUnits { get; set; }

        [Key(2)]
        public BattleUnitCalculatedStatusSetMpo CalculatedStatus { get; set; }

        [Key(3)]
        public int BossUnitUniqueKey { get; set; }

        [Key(4)]
        public int[] ZakoUnitUniqueKeys { get; set; }


    }
}
