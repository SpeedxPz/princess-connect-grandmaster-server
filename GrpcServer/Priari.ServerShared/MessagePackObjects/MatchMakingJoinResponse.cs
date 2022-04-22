using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class MatchMakingJoinResponse
    {
        [Key(0)]
        public MatchMakingUserDataMpo[] GroupUsers { get; set; }
    }
}
