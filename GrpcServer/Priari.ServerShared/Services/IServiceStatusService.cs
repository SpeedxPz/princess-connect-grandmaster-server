using MagicOnion;
using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.Services
{
    public interface IServiceStatusService : IService<IServiceStatusService>, IServiceMarker
    {
        UnaryResult<Nil> SendPreflightAsync();
    }
}
