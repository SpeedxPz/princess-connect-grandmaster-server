using MessagePack;
using Priari.ServerShared.Enums;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class BattleUnitDataMpo
    {
        [Key(0)]
        public int UniqueKey { get; set; } //UnitUniqueKey

        [Key(1)]
        public int UnitId { get; set; }

        [Key(2)]
        public int Rank { get; set; }

        [Key(3)]
        public List<BattleEquipmentDataMpo> EquipmentList { get; set; }

        [Key(4)]
        public UnitState State { get; set; }

        [Key(5)]
        public int PositionX { get; set; }

        [Key(6)]
        public int PositionY { get; set; }

        [Key(7)]
        public int Index { get; set; }

        [Key(8)]
        public bool IsPurchased { get; set; }

        [Key(9)]
        public DateTimeOffset FieldDeployAt { get; set; }

        [Key(10)]
        public bool IsToken { get; set; }

        [Key(11)]
        public bool IsNpc { get; set; }

        [Key(12)]
        public bool IsHelp { get; set; }

        [Key(13)]
        public int? OriginPlayerId { get; set; }

        [Key(14)]
        public ImmutableHashSet<UnitData.ROLE_TYPE> MirroringRoleType { get; set; }

        [Key(15)]
        public ImmutableHashSet<UnitData.TEAM_TYPE> MirroringTeamType { get; set; }

    }
}
