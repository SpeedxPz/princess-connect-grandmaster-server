using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class BattleBoardAttachBarrierEventResponse : BattleBoardEventResponse
    {
        [Key(2)]
        public int UniqueKey { get; set; }

        [Key(3)]
        public int TargetUniqueKey { get; set; }

        [Key(4)]
        public int SkillActionId { get; set; }

        [Key(5)]
        public bool IsBarrierEnd { get; set; }


    }
}
