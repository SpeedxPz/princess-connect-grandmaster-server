using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public struct BattlePlayerDataMpo
    {
        [Key(0)]
        public int ViewerId { get; set; }

        [Key(1)]
        public string Name { get; set; }

        [Key(2)]
        public int TeamId { get; set; }

        [Key(3)]
        public int AvatarId { get; set; }

        [Key(4)]
        public int Grade { get; set; }

        [Key(5)]
        public int BoardId { get; set; }

        [Key(6)]
        public int Index { get; set; }

        [Key(7)]
        public int Level { get; set; }

        [Key(8)]
        public int Exp { get; set; }

        [Key(9)]
        public int MaxLife { get; set; }

        [Key(10)]
        public int Life { get; set; }

        [Key(11)]
        public bool Alive { get; set; }

        [Key(12)]
        public int Gold { get; set; }

        [Key(13)]
        public int RankUpToken { get; set; }

        [Key(14)]
        public List<BattleEquipmentDataMpo> EquipmentList { get; set; }

        [Key(15)]
        public List<BattleUnitDataMpo> FieldUnitList { get; set; }

        [Key(16)]
        public List<BattleUnitDataMpo> DeckUnitList { get; set; }

        [Key(17)]
        public List<BattleUnitDataMpo> ShopUnitList { get; set; }

        [Key(18)]
        public List<BattleUnitDataMpo> InitialDistributeUnitList { get; set; }

        [Key(19)]
        public BattleUnitDataMpo TeamTransferUnit { get; set; }

        [Key(20)]
        public BattleUnitDataMpo TeamTakeOverUnit { get; set; }

        [Key(21)]
        public int WinsCount { get; set; }

        [Key(22)]
        public int LosesCount { get; set; }

        [Key(23)]
        public bool IsShopLock { get; set; }

        [Key(24)]
        public BattleUnitCalculatedStatusSetMpo CalculatedStatus { get; set; }

        [Key(25)]
        public int RecommendPartyDataId { get; set; }

        [Key(26)]
        public List<float> ShopUnitLotteryRates { get; set; }

        [Key(27)]
        public int TotalWinsCount { get; set; }

        [Key(28)]
        public int TotalLoseCount { get; set; }

        [Key(29)]
        public int TotalGold { get; set; }

        [Key(30)]
        public BattleUnitMirroringPairDataMpo[] UnitMirroringPairs { get; set; }

        [Key(31)]
        public List<int> OverallBuffList { get; set; }

        [Key(32)]
        public int PartyPower { get; set; }


    }
}
