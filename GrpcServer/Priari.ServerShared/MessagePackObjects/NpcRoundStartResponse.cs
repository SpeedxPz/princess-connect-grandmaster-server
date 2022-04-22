using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class NpcRoundStartResponse
    {
        [Key(0)]
        public BattlePlayerDataMpo Player { get; set; }

        [Key(1)]
        public BattleUnitDataMpo[] NpcUnits { get; set; }

        [Key(2)]
        public BattleUnitCalculatedStatusSetMpo CalculatedStatus { get; set; }


    }
}
