using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    [Union(0, typeof(NullPickupItemDataMpo))]
    [Union(1, typeof(UnitPickupItemDataMpo))]
    [Union(2, typeof(EquipmentPickupItemDataMpo))]
    [Union(3, typeof(RankupTokenPickupItemMpo))]
    public abstract class PickupItemDataMpoBase
    {
    }
}
