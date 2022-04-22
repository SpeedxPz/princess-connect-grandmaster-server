using MessagePack;
using Priari.ServerShared.MessagePackObjects.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects.User
{
    [MessagePackObject]
    public class UserHomeDataResponse
    {
        [Key(0)] 
        public UserResponse User { get; set; }

        [Key(1)]
        public UserItemResponse Furnitures { get; set; }

        [Key(2)]
        public BossBattleRemainHpResponse BossRemainHp { get; set; }

        [Key(3)]
        public BossBattleDeckListResponse DeckList { get; set; }

        [Key(4)]
        public InformationListResponse ForceDisplayInformations { get; set; }

        [Key(5)]
        public long RequestedAt { get; set; }
    }
}
