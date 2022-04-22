using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class EquipmentPickupItemDataMpo : PickupItemDataMpoBase
    {
        [Key(0)]
        public int Id { get; set; }

        [Key(1)]
        public int[] UniqueKeys { get; set; }



    }
}
