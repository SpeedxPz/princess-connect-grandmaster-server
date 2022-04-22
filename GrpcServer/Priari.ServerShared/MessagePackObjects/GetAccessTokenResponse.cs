using MessagePack;
using Priari.ServerShared.Enums;
using Priari.ServerShared.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects.User
{
    [MessagePackObject]
    public class GetAccessTokenResponse
    {
        [Key(0)]
        public GetAccessTokenResult Result { get { return GetAccessTokenResult.Success; } }

        [Key(1)]
        public string AccessToken;

        [Key(2)]
        public DateTimeOffset Expiration;

        [Key(3)]
        public int ViewerId;

        [Key(4)]
        public byte[] DeviceIdentifier;


    }
}
