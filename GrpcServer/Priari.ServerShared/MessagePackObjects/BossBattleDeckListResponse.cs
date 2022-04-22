using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class BossBattleDeckListResponse
    {
        [Key(0)]
        public BossBattleDeckDataMpo[] Decks { get; set; }

    }
}
