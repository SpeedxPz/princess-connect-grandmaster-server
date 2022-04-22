using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class PickupItemPackDataMpo
    {
        [Key(0)]
        public int Index { get; set; }

        [Key(1)]
        public PickupItemDataMpoBase[] ItemDatas { get; set; }
    }
}
