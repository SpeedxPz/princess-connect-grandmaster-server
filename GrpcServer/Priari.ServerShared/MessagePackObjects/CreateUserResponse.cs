using MessagePack;
using Priari.ServerShared.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects.User
{
    [MessagePackObject]
    public class CreateUserResponse
    {
        [Key(1)] //str
        public string AuthenticationToken { get; set; }

        [Key(2)] //int
        public int ViewerId { get; set; }

        [Key(3)] // bin8
        public byte[] DeviceIdentifier { get; set; }

        [Key(4)] // fixstr
        public string Name { get; set; }
    }
}
