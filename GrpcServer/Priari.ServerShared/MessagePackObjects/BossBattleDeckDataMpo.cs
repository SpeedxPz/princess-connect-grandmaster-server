using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class BossBattleDeckDataMpo
    {
        [Key(0)]
        public int DeckId { get; set; }

        [Key(1)]
        public int Ranking { get; set; }

        [Key(2)]
        public int PartyPower { get; set; }

        [Key(3)]
        public int TotalGiveDamage { get; set; }

        [Key(4)]
        public int PlayerLevel { get; set; }

        [Key(5)]
        public int AvatarId { get; set; }

        [Key(6)]
        public DateTimeOffset DisplayTime { get; set; }

        [Key(7)]
        public IReadOnlyList<ValueTuple<UnitData.ROLE_TYPE, int>> RoleSynergies { get; set; }

        [Key(8)]
        public IReadOnlyList<ValueTuple<UnitData.TEAM_TYPE, int>> TeamSynergies { get; set; }

        [Key(9)]
        public BossBattleDeckUnitDataMpo[] Units { get; set; }

        [Key(10)]
        public bool IsAvailable { get; set; }

        [Key(11)]
        public int DeckNumber { get; set; }

    }
}
