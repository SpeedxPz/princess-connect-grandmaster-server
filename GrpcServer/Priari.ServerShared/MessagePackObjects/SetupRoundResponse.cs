using MessagePack;
using Priari.ServerShared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class SetupRoundResponse
    {
        [Key(0)]
        public int Round { get; set; }

        [Key(1)]
        public BattlePlayerDataMpo[] Players { get; set; }

        [Key(2)]
        public FreeShopRefreshResponse[] FreeShopRefreshInfo { get; set; }

        [Key(3)]
        public BattleOption BattleOption { get; set; }

        [Key(4)]
        public FieldCellDataMpo[] FieldCellDatas { get; set; }

        [Key(5)]
        public int[] RewardPlayerIds { get; set; }


    }
}
