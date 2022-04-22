using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class MatchMakingEntryRequest
    {
        [Key(0)]
        public int DummyKindId;

    }
}
