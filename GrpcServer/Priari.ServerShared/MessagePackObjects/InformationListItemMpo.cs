using MessagePack;
using Priari.ServerShared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class InformationListItemMpo
    {
        [Key(0)]
        public int InformationId { get; set; }

        [Key(1)]
        public InformationType InformationType { get; set; }

        [Key(2)]
        public string Title { get; set; }

        [Key(3)]
        public string Body { get; set; }

        [Key(4)]
        public DateTimeOffset PublishStartAt { get; set; }
    }
}
