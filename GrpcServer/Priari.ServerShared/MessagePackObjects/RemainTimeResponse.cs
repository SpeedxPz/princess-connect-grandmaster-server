using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class RemainTimeResponse
    {
        [Key(0)]
        public int? RemainTime { get; set; }

    }
}
