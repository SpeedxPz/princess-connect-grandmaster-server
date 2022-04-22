using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects.User
{

    [MessagePackObject]
    public class UserItemResponse
    {
        [Key(0)]
        public int ViewerId { get; set; }

        [Key(1)]
        public IReadOnlyList<ItemResponse> Items { get; set; }

    }
}
