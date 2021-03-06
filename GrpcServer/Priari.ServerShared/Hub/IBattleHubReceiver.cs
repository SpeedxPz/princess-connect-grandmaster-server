using Priari.ServerShared.Enums;
using Priari.ServerShared.MessagePackObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.Hub
{
    public interface IBattleHubReceiver
    {
		void OnAttached(int viewerId);
		void OnDetached(bool force);
		void OnPhaseChanged(BattlePhase currentPhase, BattlePhase previousPhase);
		void OnRoundBegin(BattleRoundBeginDataMpo data);
		void OnBoardEventReceived(BattleBoardEventResponse[] responses, float time, OperateType replayType);
		void OnInformNextRound(int round, int npcId);
		void OnSetupRound(SetupRoundResponse response);
		void OnNpcRoundStart(NpcRoundStartResponse[] responses);
		void OnBossRoundStart(BossRoundStartResponse response);
		void OnPreparetionCountStart(RemainTimeResponse response);
		void OnMatchResult(BattleMatchResultDataMpo result);
		void OnRoundResult(BattleRoundResultsMpo results);
		void OnDefeatPlayer(BattleResultInfoMpo[] player, BattleTeamDataMpo[] teams);
		void OnUpdateResultsHistory(BattleLogRoundResultsHistoryMpo history);
		void OnUpdateResultsHistoryByMatchId(BattleLogRoundResultsHistoryMpo history, int matchId);
		void OnRefreshShopUnit(BattlePlayerDataMpo player, FreeShopRefreshResponse freeShopRefreshInfo);
		void OnBuyShopUnit(BattlePlayerDataMpo player, int uniqueKey);
		void OnBuyShopUnitToDeck(BattlePlayerDataMpo player);
		void OnBuyShopUnitToField(BattlePlayerDataMpo player);
		void OnBuyShopUnitAndRankUp(BattlePlayerDataMpo player, BattleUnitDataMpo rankUppedUnitData);
		void OnBuyShopUnitToDeckAndRankUp(BattlePlayerDataMpo player, BattleUnitDataMpo rankUppedUnitData);
		void OnBuyShopUnitToFieldAndRankUp(BattlePlayerDataMpo player, BattleUnitDataMpo rankUppedUnitData);
		void OnSellUnit(BattlePlayerDataMpo player);
		void OnBuyExp(BattlePlayerDataMpo player);
		void OnChangeDeckUnitPosition(BattlePlayerDataMpo player);
		void OnChangeFieldUnitPosition(BattlePlayerDataMpo player);
		void OnFieldDeployDeckUnit(BattlePlayerDataMpo player);
		void OnReturnFieldUnitToDeck(BattlePlayerDataMpo player);
		void OnRankupUnit(BattlePlayerDataMpo player, BattleUnitDataMpo rankUppedUnitData);
		void OnRankupUnitByToken(BattlePlayerDataMpo player, BattleUnitDataMpo rankUppedUnitData);
		void OnCheckFieldUnitCount(BattlePlayerDataMpo[] players);
		void OnStartCharacterPickUp(BattleTeamDataMpo[] teams, BattleUnitDataMpo[] units);
		void OnEndCharacterPickUp(BattlePlayerDataMpo[] players, BattleUnitDataMpo[] units);
		void OnPickUpUnit(BattlePlayerDataMpo player, BattleUnitDataMpo unit);
		void OnPickUpUnitAndRankUp(BattlePlayerDataMpo player, BattleUnitDataMpo pickUpUnit, BattleUnitDataMpo rankUppedUnitData);
		void OnChangePickUpTeam(BattleTeamDataMpo nextTeam, int[] pickupPossibleTeamIds);
		void OnNotifyPickUpUnit(BattlePlayerDataMpo player, int pickUniqueKey);
		void OnStartAnythingPickUp(BattleTeamDataMpo[] teams, PickupItemPackDataMpo[] itemPacks);
		void OnEndAnythingPickUp(BattlePlayerDataMpo[] players, PickupItemPackDataMpo[] itemPacks);
		void OnChangeAnyghingPickUpTeam(BattleTeamDataMpo nextTeam, int[] pickupPossibleTeamdIds);
		void OnPickUpItem(BattlePlayerDataMpo player, PickupItemPackDataMpo itemPackData);
		void OnNotifyPickUpItem(BattlePlayerDataMpo player, int itemPackIndex);
		void OnReciveCycleReward(CycleRewardLotteryResultMpo[] results);
		void OnEquipmentToUnit(EquipmentToUnitResponse response);
		void OnReceiveDropEquipment(BattlePlayerDataMpo player, BattleEquipmentDataMpo[] receiveEquipments);
		void OnReceiveLotteryEquipment(BattlePlayerDataMpo player, int stockIndex, BattleEquipmentDataMpo[] receiveEquipments);
		void OnReceiveTeamTakeOverUnit(BattlePlayerDataMpo player);
		void OnReceiveTeamTakeOverUnitToDeck(BattlePlayerDataMpo player);
		void OnReceiveTeamTakeOverUnitToField(BattlePlayerDataMpo player);
		void OnReceiveTeamTakeOverUnitAndRankUp(BattlePlayerDataMpo player, BattleUnitDataMpo rankUppedUnitData);
		void OnReceiveTeamTakeOverUnitToDeckAndRankUp(BattlePlayerDataMpo player, BattleUnitDataMpo rankUppedUnitData);
		void OnReceiveTeamTakeOverUnitToFieldAndRankUp(BattlePlayerDataMpo player, BattleUnitDataMpo rankUppedUnitData);
		void OnSetTeamTransferUnit(BattlePlayerDataMpo player);
		void OnReturnTeamTransferUnitToDeck(BattlePlayerDataMpo player);
		void OnReturnTeamTransferUnitToField(BattlePlayerDataMpo player);
		void OnOwnedEquipmentSynthesis(BattlePlayerDataMpo player);
		void OnRequestCancel(BattlePlayerDataMpo player);
		void OnSetupInitialPlayerInfoByUpdatePlayerLevel(BattlePlayerDataMpo[] players);
		void OnUpdateRecommendPartyData(int viewerId, int recommendPartyDataId);
		void OnSetupInitialPlayerInfoBySelectUnitStart(BattlePlayerDataMpo[] players, BattleOption battleOption, FieldCellDataMpo[] fieldCellDatas);
		void OnSetupInitialPlayerInfoBySelectUnitEnd(BattlePlayerDataMpo[] players);
		void OnNotifyInitialDistributeUnits(BattlePlayerDataMpo[] players, BattleOption battleOption, FieldCellDataMpo[] fieldCellDatas);
		void OnInitialUnitsDistributeEnd(BattlePlayerDataMpo[] players);
		void OnInitialPickUpSelectUnit(BattleUnitDataMpo unit);
		void OnInitialPickUpCancelSelectUnit(BattleUnitDataMpo unit);
		void OnInitialPickUpUnit(BattlePlayerDataMpo player);
		void OnDistributeInitialUnit(BattlePlayerDataMpo player);
		void OnInitialPickUpUnitAndRankUp(BattlePlayerDataMpo player, int rankUppedUnitUniqueKey);
		void OnDistributeInitialUnitAndRankUp(BattlePlayerDataMpo player, int rankUppedUnitUniqueKey);
		void OnStartOverallBuffPickUp(OverallBuffLotteryResultMpo[] lotteryResults);
		void OnEndOverallBuffPickUp(BattlePlayerDataMpo[] players, int[] overallBuffIds);
		void OnPickUpOverallBuff(BattlePlayerDataMpo player);
		void OnStartGuildBuffRoulette(GuildId guildId);
		void OnEndGuildBuffRoulette();
		void OnSelectEquipment(BattlePlayerDataMpo player);
		void OnReady(int[] readyPlayers);
		void OnUnready(int[] readyPlayers);
		void OnSendEmote(int player, int emoteId);
		void OnDisassembleEquipment(BattlePlayerDataMpo player, int getTokenNum);
		void OnDisassembleEquipmentWithEquipped(BattlePlayerDataMpo player, int getTokenNum, EquipmentToUnitResponse unit);
		void OnRemoveEquipmentFromUnit(EquipmentToUnitResponse response);
		void OnMigrateEquipmentBetweenUnits(EquipmentToUnitResponse fromUnitResponse, EquipmentToUnitResponse toUnitResponse);
		void OnUseSupporterItem(BattlePlayerDataMpo player);
		void OnExecuteBoosterItems(BattlePlayerDataMpo player);
		void OnUpdatePlayers(BattlePlayerDataMpo[] players);
		void OnReceiveDropitems(BattlePlayerDataMpo[] players);
		void OnBattleComplete(BattleResultInfoMpo[] results);
		void OnIdleTimeout();
	}
}
