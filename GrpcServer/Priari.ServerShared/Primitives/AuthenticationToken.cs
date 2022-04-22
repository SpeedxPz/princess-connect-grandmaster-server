using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using MessagePack;
using Priari.ServerShared.MessagePack.Formatters;

namespace Priari.ServerShared.Primitives
{
    //[MessagePackFormatter(typeof(AuthenticationTokenFormatter))]
    [MessagePackObject]
    public readonly struct AuthenticationToken : IEquatable<AuthenticationToken>
    {
        [Key(0)]
        public readonly string _value;
        public AuthenticationToken(string value)
        {
            this._value = value;
        }

        //public string value { get { return _value; } }

        public sealed class AuthenticationToken2
        {

        }

        bool IEquatable<AuthenticationToken>.Equals(AuthenticationToken other)
        {
            throw new NotImplementedException();
        }
    }
}
