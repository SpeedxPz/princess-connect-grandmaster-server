using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public struct BattleUnitMirroringPairDataMpo
    {
        [Key(0)]
        public int MainUniqueKey { get; set; }

        [Key(1)]
        public int TargetUniqueKey { get; set; }


    }
}
