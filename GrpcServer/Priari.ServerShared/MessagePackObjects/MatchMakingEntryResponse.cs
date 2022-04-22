using MessagePack;
using Priari.ServerShared.MessagePack.Formatters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class MatchMakingEntryResponse
    {
        [MessagePackFormatter(typeof(UlidMessagePackFormatter))]
        [Key(0)]
        public Ulid EntryId;

        [Key(1)]
        public int DummyKindId;

    }
}
