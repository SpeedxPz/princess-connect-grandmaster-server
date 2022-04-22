using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.Primitives
{
    public interface IObjectId<T> where T : struct
    {
        T Id { get; }
    }
}
