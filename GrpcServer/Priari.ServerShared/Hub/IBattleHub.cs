using MagicOnion;
using Priari.ServerShared.Enums;
using Priari.ServerShared.MessagePackObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Priari.ServerShared.Hub
{
    public interface IBattleHub : IStreamingHub<IBattleHub, IBattleHubReceiver>, IStreamingHubMarker, IServiceMarker
    {
		Task<BattleAttachResponse> AttachAsync(Ulid battleId);
		Task<bool> TrySignalAsync(int round, BattleSynchronizeSignal signal);
		Task RefreshShopUnit();
		Task BuyShopUnit(int uniqueKey);
		Task BuyShopUnitToDeck(int uniqueKey, int deckIndex);
		Task BuyShopUnitToField(int uniqueKey, int positionX, int positionY, int fieldIndex);
		Task ChangeFieldUnitPosition(int uniqueKey, int positionX, int positionY, int index);
		Task ChangeDeckUnitPosition(int beforeIndex, int afterIndex);
		Task SellUnit(int uniqueKey);
		Task BuyExp();
		Task<BattlePlayerDataMpo> ToggleShopLock();
		Task FieldDeployDeckUnit(int uniqueKey, int positionX, int positionY, int index);
		Task RankupUnit(int unitKey);
		Task RankupUnitWithEquipment(int unitKey);
		Task RankupUnitByToken(int unitKey);
		Task ReturnFieldUnitToDeck(int uniqueKey, int index);
		Task EquipmentToUnit(int unitKey, int equipmentKey);
		Task ReceiveDropEquipment(params int[] uniqueKeys);
		Task ReceiveLotteryEquipment(int stockIndex, params int[] uniqueKeys);
		Task DistributeUnit();
		Task PickUpUnit(int uniqueKey);
		Task NotifyPickUpUnit(int uniqueKey);
		Task PickUpItem(int itemIndex);
		Task NotifyPickUpItem(int itemIndex);
		Task PickUpOverallBuff(int selectedOverallBuffId);
		Task InitialPickUpSelectUnit(int unitUniqueKey);
		Task InitialPickUpCancelSelectUnit(int unitUniqueKey);
		Task ReceiveTeamTakeOverUnit();
		Task ReceiveTeamTakeOverUnitToDeck(int deckIndex);
		Task ReceiveTeamTakeOverUnitToField(int positionX, int positionY, int index);
		Task SetTeamTransferUnit(int uniqueKey);
		Task ReturnTeamTransferUnitToDeck(int index);
		Task ReturnTeamTransferUnitToField(int positionX, int positionY, int index);
		Task<UserReconnectResponse> NotifyPlayerReConnected();
		Task EquipmentToUnitSynthesis(int unitKey, int srcEquipmentKey, int afterSynthesisId, params int[] synthesisMaterialKeys);
		Task OwnedEquipmentSynthesis(int srcEquipmentKey, int afterSynthesisId, params int[] synthesisMaterialKeys);
		Task RankUpEquipment(int equipmentKey, int afterEquipmentId);
		Task RankUpEquipmentWithEquipped(int unitKey, int equipmentKey, int afterEquipmentId);
		Task Ready();
		Task Unready();
		Task SetBattleEventIntervalRate(float rate);
		Task SendEmote(int emoteId);
		Task UpdateRecommendPartyData(int id);
		Task DisassembleEquipment(params int[] equipmentKeys);
		Task DisassembleEquipmentWithEquipped(int unitKey, params int[] equipmentKeys);
		Task SkipToRoundMatchCompletionAsync();
		Task SelectEquipmentAsync(int equipmentKey, int selectEquipmentId);
		Task SelectEquipmentAndEquipToUnit(int equipmentKey, int selectEquipmentId, int targetUnitKey);
		Task AbandonAsync();
		Task RemoveEquipmentFromUnit(int unitKey, params int[] equipmentKeys);
		Task RemoveAllEquipmentFromUnit(int unitKey);
		Task MigrateEquipmentBetweenUnits(int fromUnitKey, int toUnitKey, int equipmentKey);
		Task UseSupporterItem(int itemId);
		Task RequestRedistributeNpcData();
		Task DebugMenuAddUnit(int id, int rank);
		Task DebugMenuAddEquipment(int id);
		Task DebugMenuEditPlayerInfo(int viewerId, int? life, int? gold);
		Task DebugMenuForceCompleteWaitForCommand();
		Task DebugMenuForceSurrenderPlayers();
	}
}
