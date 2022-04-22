using MagicOnion;
using MessagePack;
using Priari.ServerShared.MessagePack.Formatters;
using Priari.ServerShared.MessagePackObjects.User;
using Priari.ServerShared.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.Services
{
    [MessagePackFormatter(typeof(UlidMessagePackFormatter))]
    public interface IUserService : IService<IUserService>, IServiceMarker
    {
        UnaryResult<ServiceResult<CurrentBattleResponse>> GetCurrentBattleAsync();
        UnaryResult<ServiceResult<UserHomeDataResponse>> GetUserHomeDataAsync();
        UnaryResult<int> Debug(Ulid message);
    }
}
