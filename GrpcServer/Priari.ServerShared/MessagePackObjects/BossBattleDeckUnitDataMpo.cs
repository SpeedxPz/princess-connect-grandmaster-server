using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class BossBattleDeckUnitDataMpo
    {
        [Key(0)]
        public int Seq;

        [Key(1)]
        public int UniqueKey;

        [Key(2)]
        public int UnitId;

        [Key(3)]
        public int Rank;

        [Key(4)]
        public int PositionX;

        [Key(5)]
        public int PositionY;

        [Key(6)]
        public int[] EquipmentIds;

        [Key(7)]
        public int FieldDeployOrder;

        [Key(8)]
        public int? MirroredUnitKey;

    }
}
