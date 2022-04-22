using Grpc.Net.Client;
using MagicOnion.Server.Hubs;
using Priari.ServerShared.Enums;
using Priari.ServerShared.Hub;
using Priari.ServerShared.MessagePackObjects;
using System;
using System.Threading.Tasks;

namespace Priari.MatchMakingServer
{
    public class BattleHub : StreamingHubBase<IBattleHub, IBattleHubReceiver>, IBattleHub
    {
        public static BattleHub instance;
        public static IGroup group;
        public async Task AbandonAsync()
        {
            Logger.WriteLog($"<=== AbandonAsync");
        }

        public async Task<BattleAttachResponse> AttachAsync(Ulid battleId)
        {
            group = await Group.AddAsync("takumi");
            instance = this;

            //Entry Point
            Logger.WriteLog($"<=== AttachAsync");
            Logger.WriteLog($"BattleId: {battleId}");

            return new BattleAttachResponse();
        }

        public async Task BuyExp()
        {
            Logger.WriteLog($"<=== BuyExp");
        }

        public async Task BuyShopUnit(int uniqueKey)
        {
            Logger.WriteLog($"<=== BuyShopUnit");
            Logger.WriteLog($"uniqueKey: {uniqueKey}");
        }

        public async Task BuyShopUnitToDeck(int uniqueKey, int deckIndex)
        {
            Logger.WriteLog($"<=== BuyShopUnitToDeck");
            Logger.WriteLog($"uniqueKey: {uniqueKey} | deckIndex: {deckIndex}");
        }

        public async Task BuyShopUnitToField(int uniqueKey, int positionX, int positionY, int fieldIndex)
        {
            Logger.WriteLog($"<=== BuyShopUnitToField");
            Logger.WriteLog($"uniqueKey: {uniqueKey} | positionX: {positionX} | positionY: {positionY} | fieldIndex: {fieldIndex}");
        }

        public async Task ChangeDeckUnitPosition(int beforeIndex, int afterIndex)
        {
            Logger.WriteLog($"<=== ChangeDeckUnitPosition");
            Logger.WriteLog($"uniqueKey: {beforeIndex} | deckIndex: {afterIndex}");
        }

        public async Task ChangeFieldUnitPosition(int uniqueKey, int positionX, int positionY, int index)
        {
            Logger.WriteLog($"<=== ChangeFieldUnitPosition");
            Logger.WriteLog($"uniqueKey: {uniqueKey} | positionX: {positionX} | positionY: {positionY} | index: {index}");
        }

        public async Task DebugMenuAddEquipment(int id)
        {
            Logger.WriteLog($"<=== DebugMenuAddEquipment");
            Logger.WriteLog($"id: {id}");
        }

        public async Task DebugMenuAddUnit(int id, int rank)
        {
            Logger.WriteLog($"<=== DebugMenuAddUnit");
            Logger.WriteLog($"id: {id} | rank: {rank}");
        }

        public async Task DebugMenuEditPlayerInfo(int viewerId, int? life, int? gold)
        {
            Logger.WriteLog($"<=== DebugMenuEditPlayerInfo");
            Logger.WriteLog($"viewerId: {viewerId} | life: {life} | gold: {gold}");
        }

        public async Task DebugMenuForceCompleteWaitForCommand()
        {
            Logger.WriteLog($"<=== DebugMenuForceCompleteWaitForCommand");
        }

        public async Task DebugMenuForceSurrenderPlayers()
        {
            Logger.WriteLog($"<=== DebugMenuForceSurrenderPlayers");
        }

        public async Task DisassembleEquipment(params int[] equipmentKeys)
        {
            Logger.WriteLog($"<=== DisassembleEquipment");
            Logger.WriteLog("equipmentKeys: " + Newtonsoft.Json.JsonConvert.SerializeObject(equipmentKeys));
        }

        public async Task DisassembleEquipmentWithEquipped(int unitKey, params int[] equipmentKeys)
        {
            Logger.WriteLog($"<=== DisassembleEquipmentWithEquipped");
            Logger.WriteLog($"unitKey: {unitKey}");
            Logger.WriteLog("equipmentKeys: " + Newtonsoft.Json.JsonConvert.SerializeObject(equipmentKeys));
        }

        public async Task DistributeUnit()
        {
            Logger.WriteLog($"<=== DistributeUnit");
        }

        public async Task EquipmentToUnit(int unitKey, int equipmentKey)
        {
            Logger.WriteLog($"<=== EquipmentToUnit");
            Logger.WriteLog($"unitKey: {unitKey} | equipmentKey: {equipmentKey}");
        }

        public async Task EquipmentToUnitSynthesis(int unitKey, int srcEquipmentKey, int afterSynthesisId, params int[] synthesisMaterialKeys)
        {
            Logger.WriteLog($"<=== EquipmentToUnitSynthesis");
            Logger.WriteLog($"unitKey: {unitKey} | srcEquipmentKey: {srcEquipmentKey} | afterSynthesisId: {afterSynthesisId}");
            Logger.WriteLog("synthesisMaterialKeys: " + Newtonsoft.Json.JsonConvert.SerializeObject(synthesisMaterialKeys));
        }

        public async Task FieldDeployDeckUnit(int uniqueKey, int positionX, int positionY, int index)
        {
            Logger.WriteLog($"<=== FieldDeployDeckUnit");
            Logger.WriteLog($"uniqueKey: {uniqueKey} | positionX: {positionX} | positionY: {positionY} | index: {index}");
        }

        public async Task InitialPickUpCancelSelectUnit(int unitUniqueKey)
        {
            Logger.WriteLog($"<=== InitialPickUpCancelSelectUnit");
            Logger.WriteLog($"unitUniqueKey: {unitUniqueKey}");
        }

        public async Task InitialPickUpSelectUnit(int unitUniqueKey)
        {
            Logger.WriteLog($"<=== InitialPickUpSelectUnit");
            Logger.WriteLog($"unitUniqueKey: {unitUniqueKey}");
        }

        public async Task MigrateEquipmentBetweenUnits(int fromUnitKey, int toUnitKey, int equipmentKey)
        {
            Logger.WriteLog($"<=== MigrateEquipmentBetweenUnits");
            Logger.WriteLog($"fromUnitKey: {fromUnitKey} | toUnitKey: {toUnitKey} | equipmentKey: {equipmentKey}");
        }

        public async Task NotifyPickUpItem(int itemIndex)
        {
            Logger.WriteLog($"<=== NotifyPickUpItem");
            Logger.WriteLog($"itemIndex: {itemIndex}");
        }

        public async Task NotifyPickUpUnit(int uniqueKey)
        {
            Logger.WriteLog($"<=== NotifyPickUpUnit");
            Logger.WriteLog($"uniqueKey: {uniqueKey}");
        }

        public async Task<UserReconnectResponse> NotifyPlayerReConnected()
        {
            Logger.WriteLog($"<=== NotifyPlayerReConnected");
            return new UserReconnectResponse();
        }

        public async Task OwnedEquipmentSynthesis(int srcEquipmentKey, int afterSynthesisId, params int[] synthesisMaterialKeys)
        {
            Logger.WriteLog($"<=== OwnedEquipmentSynthesis");
            Logger.WriteLog($"srcEquipmentKey: {srcEquipmentKey} | afterSynthesisId: {afterSynthesisId}");
            Logger.WriteLog("synthesisMaterialKeys: " + Newtonsoft.Json.JsonConvert.SerializeObject(synthesisMaterialKeys));
        }

        public async Task PickUpItem(int itemIndex)
        {
            Logger.WriteLog($"<=== PickUpItem");
            Logger.WriteLog($"itemIndex: {itemIndex}");
        }

        public async Task PickUpOverallBuff(int selectedOverallBuffId)
        {
            Logger.WriteLog($"<=== PickUpOverallBuff");
            Logger.WriteLog($"selectedOverallBuffId: {selectedOverallBuffId}");
        }

        public async Task PickUpUnit(int uniqueKey)
        {
            Logger.WriteLog($"<=== PickUpUnit");
            Logger.WriteLog($"uniqueKey: {uniqueKey}");
        }

        public async Task RankUpEquipment(int equipmentKey, int afterEquipmentId)
        {
            Logger.WriteLog($"<=== RankUpEquipment");
            Logger.WriteLog($"equipmentKey: {equipmentKey} | afterEquipmentId: {afterEquipmentId}");
        }

        public async Task RankUpEquipmentWithEquipped(int unitKey, int equipmentKey, int afterEquipmentId)
        {
            Logger.WriteLog($"<=== RankUpEquipmentWithEquipped");
            Logger.WriteLog($"unitKey: {unitKey} | equipmentKey: {equipmentKey} | afterEquipmentId: {afterEquipmentId}");
        }

        public async Task RankupUnit(int unitKey)
        {
            Logger.WriteLog($"<=== RankupUnit");
            Logger.WriteLog($"unitKey: {unitKey}");
        }

        public async Task RankupUnitByToken(int unitKey)
        {
            Logger.WriteLog($"<=== RankupUnitByToken");
            Logger.WriteLog($"unitKey: {unitKey}");
        }

        public async Task RankupUnitWithEquipment(int unitKey)
        {
            Logger.WriteLog($"<=== RankupUnitWithEquipment");
            Logger.WriteLog($"unitKey: {unitKey}");
        }

        public async Task Ready()
        {
            Logger.WriteLog($"<=== Ready");
        }

        public async Task ReceiveDropEquipment(params int[] uniqueKeys)
        {
            Logger.WriteLog($"<=== ReceiveDropEquipment");
            Logger.WriteLog("uniqueKeys: " + Newtonsoft.Json.JsonConvert.SerializeObject(uniqueKeys));
        }

        public async Task ReceiveLotteryEquipment(int stockIndex, params int[] uniqueKeys)
        {
            Logger.WriteLog($"<=== ReceiveLotteryEquipment");
            Logger.WriteLog($"stockIndex: {stockIndex}");
            Logger.WriteLog("uniqueKeys: " + Newtonsoft.Json.JsonConvert.SerializeObject(uniqueKeys));
        }

        public async Task ReceiveTeamTakeOverUnit()
        {
            Logger.WriteLog($"<=== ReceiveTeamTakeOverUnit");
        }

        public async Task ReceiveTeamTakeOverUnitToDeck(int deckIndex)
        {
            Logger.WriteLog($"<=== ReceiveTeamTakeOverUnitToDeck");
            Logger.WriteLog($"deckIndex: {deckIndex}");
        }

        public async Task ReceiveTeamTakeOverUnitToField(int positionX, int positionY, int index)
        {
            Logger.WriteLog($"<=== ReceiveTeamTakeOverUnitToField");
            Logger.WriteLog($"positionX: {positionX} | positionY: {positionY} | index: {index}");
        }

        public async Task RefreshShopUnit()
        {
            Logger.WriteLog($"<=== RefreshShopUnit");
        }

        public async Task RemoveAllEquipmentFromUnit(int unitKey)
        {
            Logger.WriteLog($"<=== RemoveAllEquipmentFromUnit");
            Logger.WriteLog($"unitKey: {unitKey}");
        }

        public async Task RemoveEquipmentFromUnit(int unitKey, params int[] equipmentKeys)
        {
            Logger.WriteLog($"<=== RemoveEquipmentFromUnit");
            Logger.WriteLog($"unitKey: {unitKey}");
            Logger.WriteLog("equipmentKeys: " + Newtonsoft.Json.JsonConvert.SerializeObject(equipmentKeys));
        }

        public async Task RequestRedistributeNpcData()
        {
            Logger.WriteLog($"<=== RequestRedistributeNpcData");
        }

        public async Task ReturnFieldUnitToDeck(int uniqueKey, int index)
        {
            Logger.WriteLog($"<=== ReturnFieldUnitToDeck");
            Logger.WriteLog($"uniqueKey: {uniqueKey} | index: {index}");
        }

        public async Task ReturnTeamTransferUnitToDeck(int index)
        {
            Logger.WriteLog($"<=== ReturnTeamTransferUnitToDeck");
            Logger.WriteLog($"index: {index}");
        }

        public async Task ReturnTeamTransferUnitToField(int positionX, int positionY, int index)
        {
            Logger.WriteLog($"<=== ReturnTeamTransferUnitToField");
            Logger.WriteLog($"positionX: {positionX} | positionY: {positionY} | index: {index}");
        }

        public async Task SelectEquipmentAndEquipToUnit(int equipmentKey, int selectEquipmentId, int targetUnitKey)
        {
            Logger.WriteLog($"<=== SelectEquipmentAndEquipToUnit");
            Logger.WriteLog($"equipmentKey: {equipmentKey} | selectEquipmentId: {selectEquipmentId} | targetUnitKey: {targetUnitKey}");
        }

        public async Task SelectEquipmentAsync(int equipmentKey, int selectEquipmentId)
        {
            Logger.WriteLog($"<=== SelectEquipmentAsync");
            Logger.WriteLog($"equipmentKey: {equipmentKey} | selectEquipmentId: {selectEquipmentId}");
        }

        public async Task SellUnit(int uniqueKey)
        {
            Logger.WriteLog($"<=== SellUnit");
            Logger.WriteLog($"uniqueKey: {uniqueKey}");
        }

        public async Task SendEmote(int emoteId)
        {
            Logger.WriteLog($"<=== SendEmote");
            Logger.WriteLog($"emoteId: {emoteId}");
        }

        public async Task SetBattleEventIntervalRate(float rate)
        {
            Logger.WriteLog($"<=== SetBattleEventIntervalRate");
            Logger.WriteLog($"rate: {rate}");
        }

        public async Task SetTeamTransferUnit(int uniqueKey)
        {
            Logger.WriteLog($"<=== SetTeamTransferUnit");
            Logger.WriteLog($"uniqueKey: {uniqueKey}");
        }

        public async Task SkipToRoundMatchCompletionAsync()
        {
            Logger.WriteLog($"<=== SkipToRoundMatchCompletionAsync");
        }

        public async Task<BattlePlayerDataMpo> ToggleShopLock()
        {
            Logger.WriteLog($"<=== ToggleShopLock");
            return new BattlePlayerDataMpo();
        }
        
        public async Task<bool> TrySignalAsync(int round, BattleSynchronizeSignal signal)
        {
            Logger.WriteLog($"<=== TrySignalAsync");
            Logger.WriteLog($"round: {round} | signal: {signal}");
            return true;
        }

        public async Task Unready()
        {
            Logger.WriteLog($"<=== Unready");
        }

        public async Task UpdateRecommendPartyData(int id)
        {
            Logger.WriteLog($"<=== UpdateRecommendPartyData");
            Logger.WriteLog($"id: {id}");
        }

        public async Task UseSupporterItem(int itemId)
        {
            Logger.WriteLog($"<=== UseSupporterItem");
            Logger.WriteLog($"itemId: {itemId}");
        }
    }
}
