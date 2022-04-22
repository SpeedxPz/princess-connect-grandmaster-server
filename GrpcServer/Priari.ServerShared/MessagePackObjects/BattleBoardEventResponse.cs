using MessagePack;
using Priari.ServerShared.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    [Union(0, typeof(BattleBoardNopEventResponse))]
    [Union(1, typeof(BattleBoardMoveFieldEventResponse))]
    [Union(2, typeof(BattleBoardResetRecastTimeEventResponse))]
    [Union(3, typeof(BattleBoardResetSkillRecastTimeEventResponse))]
    [Union(4, typeof(BattleBoardAttackOperateEventResponse))]
    [Union(5, typeof(BattleBoardSkillOperateEventResponse))]
    [Union(6, typeof(BattleBoardTargetDeadEventResponse))]
    [Union(7, typeof(BattleBoardBoxDropEventResponse))]
    [Union(8, typeof(BattleBoardBlowAwayOperateEventResponse))]
    [Union(9, typeof(BattleBoardRushOperateEventResponse))]
    [Union(10, typeof(BattleBoardAddFieldUnitEventResponse))]
    [Union(11, typeof(BattleBoardHpDamageEventResponse))]
    [Union(12, typeof(BattleBoardHpHealEventResponse))]
    [Union(13, typeof(BattleBoardChangeTechnicalPointEventResponse))]
    [Union(14, typeof(BattleBoardCompleteEventResponse))]
    [Union(15, typeof(BattleBoardSkillDamageEventResponse))]
    [Union(16, typeof(BattleBoardStunEventResponse))]
    [Union(17, typeof(BattleBoardDebugMessageEventResponse))]
    [Union(18, typeof(BattleBoardSkillHpHealEventResponse))]
    [Union(19, typeof(BattleBoardTPDamageEventResponse))]
    [Union(20, typeof(BattleBoardSkillTPDamageEventResponse))]
    [Union(21, typeof(BattleBoardTPHealEventResponse))]
    [Union(22, typeof(BattleBoardSkillTPHealEventResponse))]
    [Union(23, typeof(BattleBoardSendFieldUnitEventResponse))]
    [Union(24, typeof(BattleBoardReceiveFieldUnitEventResponse))]
    [Union(25, typeof(BattleBoardStatusEffectAddedEventResponse))]
    [Union(26, typeof(BattleBoardStatusEffectRemovedEventResponse))]
    [Union(27, typeof(BattleBoardUnitStatusSyncEventResponse))]
    [Union(28, typeof(BattleBoardBarrierEventResponse))]
    [Union(29, typeof(BattleBoardEquipmentSkillDamageEventResponse))]
    [Union(30, typeof(BattleBoardBarrierDamageEventResponse))]
    [Union(31, typeof(BattleBoardTeleportEventResponse))]
    [Union(32, typeof(BattleBoardIntoGimmickFieldCellEventResponce))]
    [Union(33, typeof(BattleBoardGoOutGimmickFieldCellEventResponce))]
    [Union(34, typeof(BattleBoardEquipEquipmentHasPassiveSkillEventResponse))]
    [Union(35, typeof(BattleBoardSkillSummonUnitEventResponse))]
    [Union(36, typeof(BattleBoardSkillMoveEventResponse))]
    [Union(37, typeof(BattleBoardWeaponChangeEventResponse))]
    [Union(38, typeof(BattleBoardEmptySkillOperateEventResponse))]
    [Union(39, typeof(BattleBoardCounterSkillOperateEventResponse))]
    [Union(40, typeof(BattleBoardAttachBarrierEventResponse))]
    [Union(41, typeof(BattleBoardCounterSkillDamageEventResponse))]


    public abstract class BattleBoardEventResponse
    {
        [Key(0)]
        public int MatchId { get; set; }

        [Key(1)]
        public float RaisedAt { get; set; }
    }
}
