using MessagePack;
using Priari.ServerShared.MessagePack.Formatters;
using Priari.ServerShared.Primitives;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackFormatter(typeof(YeetFormatter))]
    public struct Yeet
    {
        public bool success;

        public Yeet(bool status)
        {
            this.success = status;
        }
    }
}
