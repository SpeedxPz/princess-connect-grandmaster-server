using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class UnitData
    {
		/*public int Id;
        public string Name;
        public bool Playable;
        public int Life;
        public int Atk;
        public int MagicAtk;
        public int Defence;
        public int MagicDefence;
        public int TechnicalPoint;
        public float AttackRecastTime;
        public float MoveRecastTime;
        public float AttackRange;
        public int Scale;
        public bool IsLargeDie;
        public float RotateDuration60;
        public float RotateDuration120;
        public float RotateDuration180;
        public bool IsRotate180DirRight;
        public ImmutableHashSet<UnitData.ROLE_TYPE> RoleTypes;
        public ImmutableHashSet<UnitData.TEAM_TYPE> TeamTypes;
        public GuildId GuildId;
        public ImmutableHashSet<UnitData.CHARACTERISTIC_TYPE> CharacteristicTypes;
        public AttackType AttackType;
        public int Price;
        public bool IsToken;
        public IReadOnlyList<EquipmentId> RankupRank1EquipIds;
        public IReadOnlyList<EquipmentId> RankupRank2EquipIds;
        public WeaponType WeaponType;
        public float StartSkillTime;
        public float EndSkillTime;
        public float StartVisibleTime;
        public float EndVisibleTime;
        public float[] RotationDurations;
        public IReadOnlyList<EquipmentId> GetRankUpEquipIds(int rank);*/


		public enum ROLE_TYPE
		{
			NONE,
			WARRIOR = 101,
			HUNTER_OLD,
			BLADEMASTER,
			MAGE,
			KNIGHT,
			ASSASIN,
			LANCER,
			BATTLEMAGE,
			PRIEST,
			MYSTIC,
			DRAGON,
			MIRROR,
			HUNTER,
			INVINCIBLE = 999
		}

		public enum TEAM_TYPE
		{
			NONE,
			体力強化 = 201,
			TP回復,
			回避,
			攻撃強化,
			ライトニング,
			スタン,
			魔法防御,
			一時無敵,
			強化移植,
			特殊強化,
			TP減少,
			物理防御減少,
			ツインズソウル,
			確定ダメ\u30FCジ,
			ミラ\u30FC,
			攻撃速度
		}

	}
}
