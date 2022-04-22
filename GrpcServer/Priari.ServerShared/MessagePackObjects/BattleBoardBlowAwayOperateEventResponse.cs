using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class BattleBoardBlowAwayOperateEventResponse : BattleBoardEventResponse
    {
        [Key(2)]
        public int UniqueKey { get; set; }

        [Key(3)]
        public int TargetUniqueKey { get; set; }

        [Key(4)]
        public int X { get; set; }

        [Key(5)]
        public int Y { get; set; }

        [Key(6)]
        public int PreviousX { get; set; }

        [Key(7)]
        public int PreviousY { get; set; }


    }
}
