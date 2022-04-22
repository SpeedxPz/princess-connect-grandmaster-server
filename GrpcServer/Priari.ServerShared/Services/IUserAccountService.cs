using System;
using System.Collections.Generic;
using System.Text;
using MagicOnion;
using Priari.ServerShared.Enums;
using Priari.ServerShared.MessagePackObjects.User;
using Priari.ServerShared.Primitives;

namespace Priari.ServerShared.Services
{
    public interface IUserAccountService : IService<IUserAccountService>, IServiceMarker
    {
        UnaryResult<ServiceResult<MasterDataResponse, MasterCacheResult>> GetMasterDataAsync(string hash);
        UnaryResult<ServiceResult<InitialDataResponse>> GetInitialDataAsync();
        UnaryResult<ServiceResult<CreateUserResponse>> CreateUserAsync(string userName);
        UnaryResult<ServiceResult<GetAccessTokenResponse, GetAccessTokenResult>> GetAccessTokenAsync(int viewerId, string authenticationToken);
    }
}
