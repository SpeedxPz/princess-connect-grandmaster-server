using System;
using System.Collections.Generic;
using System.Text;
using MessagePack;
using Priari.ServerShared.Enums;
using Priari.ServerShared.MessagePack.Formatters;

namespace Priari.ServerShared.MessagePackObjects.User
{

    //[MessagePackFormatter(typeof(AuthenticationTokenFormatter))]
    [MessagePackObject]
    public class UserResponse
    {
        [Key(0)]
        public int ViewerId;

        [Key(1)]
        public string Name;

        [Key(2)]
        public int AvatarId;

        [Key(3)]
        public int BoardId;

        [Key(4)]
        public TutorialStep TutorialStep;

        [Key(5)]
        public int CompletedBattleCount;
        
        [Key(6)]
        public int Grade; //GradeId

        [Key(7)]
        public long BattlePoint;

        [Key(8)]
        public DateTimeOffset LastLoggedInAt;

        public UserResponse()
        {
        }
    }
}
