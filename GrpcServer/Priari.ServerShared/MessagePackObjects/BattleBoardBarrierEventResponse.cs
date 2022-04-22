using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class BattleBoardBarrierEventResponse : BattleBoardEventResponse
    {
        [Key(2)]
        public int TargetUniqueKey { get; set; }

        [Key(3)]
        public int MaxBufferedDamage { get; set; }

        [Key(4)]
        public int BufferedDamage { get; set; }

    }
}
