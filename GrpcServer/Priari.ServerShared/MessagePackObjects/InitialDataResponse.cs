using System;
using System.Collections.Generic;
using System.Text;
using MessagePack;
using MessagePack.Formatters;
using Priari.ServerShared.MessagePack.Formatters;

namespace Priari.ServerShared.MessagePackObjects.User
{

    [MessagePackObject]
    public class InitialDataResponse
    {
        //[MessagePackFormatter(typeof(TypelessFormatter))]
        
        [Key(0)]
        public UserResponse User { get; set; }

        public InitialDataResponse()
        {     
        }

    }
}
