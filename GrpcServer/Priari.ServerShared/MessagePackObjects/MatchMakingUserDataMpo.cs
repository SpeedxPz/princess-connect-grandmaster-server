using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class MatchMakingUserDataMpo
    {
        [Key(0)]
        public string UserName { get; set; }

        [Key(1)]
        public int AvatarId { get; set; }

        [Key(2)]
        public int GradeId { get; set; }

        [Key(3)]
        public int ViewerId { get; set; }

        public MatchMakingUserDataMpo(string UserName, int AvartarId, int GradeId, int ViewverId)
        {
            this.UserName = UserName;
            this.AvatarId = AvartarId;
            this.GradeId = GradeId;
            this.ViewerId = ViewverId;
        }
    }
}
