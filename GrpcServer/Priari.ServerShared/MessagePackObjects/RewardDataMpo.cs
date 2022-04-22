using MessagePack;
using Priari.ServerShared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public struct RewardDataMpo
    {
        [Key(0)]
        public BattleResultType ResultType { get; set; }

        [Key(1)]
        public int BaseGold { get; set; }

        [Key(2)]
        public int DistributeGold { get; set; }

        [Key(3)]
        public int BonusGold { get; set; }

        [Key(4)]
        public int ResultRewardGold { get; set; }

        [Key(5)]
        public int InterestGold { get; set; }

        [Key(6)]
        public BattleUnitDataMpo[] Units { get; set; }

        [Key(7)]
        public BattleEquipmentDataMpo[] Equipments { get; set; }


    }
}
