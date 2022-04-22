using MessagePack;
using Priari.ServerShared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class BattleRoundResultMpo
    {
        [Key(0)]
        public int MatchId { get; set; }

        [Key(1)]
        public ValueTuple<BattleResultType, int> PrimaryResult { get; set; }

        [Key(2)]
        public ValueTuple<BattleResultType, int> SecondaryResult { get; set; }

        [Key(3)]
        public IReadOnlyDictionary<int, int> KillCounts { get; set; }


    }
}
