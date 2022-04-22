using MagicOnion;
using MagicOnion.Server;
using MessagePack;
using Priari.ServerShared.Services;
using System;

namespace Priari.Server
{
    public class ServiceStatusService : ServiceBase<IServiceStatusService>, IServiceStatusService
    {
        public async UnaryResult<Nil> SendPreflightAsync()
        {
            foreach (var data in Context.CallContext.RequestHeaders)
            {
                Console.WriteLine(data);
            }

            
            return new Nil();
        }
    }
}
