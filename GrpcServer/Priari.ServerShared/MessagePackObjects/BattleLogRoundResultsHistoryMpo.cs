using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class BattleLogRoundResultsHistoryMpo
    {
        [Key(0)]
        public Dictionary<int, BattleLogRoundResultsHistoryElementMpo> History { get; set; }



    }
}
