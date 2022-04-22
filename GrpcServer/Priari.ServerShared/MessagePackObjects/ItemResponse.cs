using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;


namespace Priari.ServerShared.MessagePackObjects.User
{

    [MessagePackObject]
    public class ItemResponse
    {
        [Key(0)]
        public int ItemId { get; set; }

        [Key(1)]
        public int PossessCount { get; set; }

        public ItemResponse(int itemId, int possesscount)
        {
            this.ItemId = itemId;
            this.PossessCount = possesscount;
        }

    }
}