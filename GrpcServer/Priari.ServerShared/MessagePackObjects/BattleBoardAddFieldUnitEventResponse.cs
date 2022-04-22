using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class BattleBoardAddFieldUnitEventResponse : BattleBoardEventResponse
    {
        [Key(2)]
        public int UniqueKey { get; set; }

        [Key(3)]
        public BattleUnitDataMpo[] AddUnits { get; set; }

        [Key(4)]
        public BattleUnitCalculatedStatusSetMpo CalculatedStatus { get; set; }
    }
}
