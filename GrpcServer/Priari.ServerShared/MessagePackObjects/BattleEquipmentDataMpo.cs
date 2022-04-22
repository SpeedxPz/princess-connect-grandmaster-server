using MessagePack;
using Priari.ServerShared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class BattleEquipmentDataMpo
    {
        [Key(0)]
        public int UniqueKey { get; set; }

        [Key(1)]
        public int Id { get; set; }

        [Key(2)]
        public string Name { get; set; }

        [Key(3)]
        public EquipmentType Type { get; set; }

        [Key(4)]
        public int Life { get; set; }

        [Key(5)]
        public int Atk { get; set; }

        [Key(6)]
        public int MagicAtk { get; set; }

        [Key(7)]
        public int Defence { get; set; }

        [Key(8)]
        public int MagicDefence { get; set; }

        [Key(9)]
        public float TechnicalPointRate { get; set; }

        [Key(10)]
        public int AttackRecastTimeTickRate { get; set; }

        [Key(11)]
        public int MoveRecastTimeTickRate { get; set; }

        [Key(12)]
        public float AttackRange { get; set; }

        [Key(13)]
        public AttackType AttackType { get; set; }

        [Key(14)]
        public IReadOnlyList<int> AfterSynthesisIds { get; set; }

        [Key(15)]
        public int Rank { get; set; }

        [Key(16)]
        public UnitData.ROLE_TYPE RoleType { get; set; }

        [Key(17)]
        public UnitData.TEAM_TYPE TeamType { get; set; }

        [Key(18)]
        public IReadOnlyList<int> SelectableEquipmentIds { get; set; }

        [Key(19)]
        public string Description { get; set; }

        [Key(20)]
        public int SkillDamageScale { get; set; }



    }
}
