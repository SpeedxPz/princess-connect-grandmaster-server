using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class UnitPickupItemDataMpo
    {
        [Key(0)]
        public int UniqueKey { get; set; }

        [Key(1)]
        public int UnitId { get; set; }


    }
}
