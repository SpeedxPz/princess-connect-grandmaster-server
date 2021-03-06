using MessagePack;
using Priari.ServerShared.MessagePack.Formatters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class MatchMakingCancelRequest
    {
        [MessagePackFormatter(typeof(UlidMessagePackFormatter))]
        [Key(0)]
        public Ulid EntryId;
    }
}
