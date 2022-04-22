using System;
using System.IO;
using System.Linq;
using Grpc.Net.Client;
using MagicOnion;
using MagicOnion.Client;
using MagicOnion.Server;
using Priari.ServerShared;
using Priari.ServerShared.Enums;
using Priari.ServerShared.MessagePackObjects.User;
using Priari.ServerShared.Primitives;
using Priari.ServerShared.Services;

namespace Priari.Services
{

    public class UserAccountService : ServiceBase<IUserAccountService>, IUserAccountService
    {
   

        public async UnaryResult<ServiceResult<MasterDataResponse, MasterCacheResult>> GetMasterDataAsync(string hash)
        {
            foreach (var data in Context.CallContext.RequestHeaders)
            {
                Console.WriteLine(data);
            }

            foreach (var data in Context.CallContext.RequestHeaders)  {
                Console.WriteLine(data);
            }

            var result = new ServiceResult<MasterDataResponse, MasterCacheResult>();

            MasterDataResponse resp = new MasterDataResponse();
            resp.Data = File.ReadAllBytes("D:\\masterdata.bytes"); // Read the masterdata
            resp.Hash = "f9dfbd808fc2ed491c3efdee942f0f1ba212630e0f413758fdd4b39bd170a034";


            result.Result = resp;
            result.Succeeded = true;
            result.ErrorDetail = MasterCacheResult.Success;

            Console.WriteLine($"Received:{hash}");

            return result;
        }

        public async UnaryResult<ServiceResult<CreateUserResponse>> CreateUserAsync(string userName)
        {
            foreach (var data in Context.CallContext.RequestHeaders)
            {
                Console.WriteLine(data);
            }

            Console.WriteLine($"Received:{userName}");

            CreateUserResponse createUserResponse = new CreateUserResponse();
            createUserResponse.Name = userName;
            createUserResponse.AuthenticationToken = "VWl2dCtLWEJucXgyaFhhc2Rhc2Rhc2RhZGFzZGFzZGFqa2lvM200OTIzODRtMjM5cG12MjNpb3BybTIzb3BbNHYyNDIzNGxXTzQ2L3BDdFF4UT09";
            createUserResponse.ViewerId = 135112345;
            createUserResponse.DeviceIdentifier = new byte[] { 0x01, 0x7f, 0xea, 0x11, 0x31, 0x44, 0x55, 0x10, 0x3a, 0x77, 0xb1, 0x07, 0x28, 0x17, 0x45, 0x40 };

            var result = new ServiceResult<CreateUserResponse>();
            result.Succeeded = true;
            result.Result = createUserResponse;
            result.ErrorDetail = new GeneralError();
            return result;
        }

        public async UnaryResult<ServiceResult<GetAccessTokenResponse, GetAccessTokenResult>> GetAccessTokenAsync(int viewerId, string authenticationToken)
        {

            foreach (var data in Context.CallContext.RequestHeaders)
            {
                Console.WriteLine(data);
            }

            

            Console.WriteLine($"Received: Viewer ID {viewerId}, authenticationToken {authenticationToken}");

            GetAccessTokenResponse getAccessTokenResponse = new GetAccessTokenResponse();
            getAccessTokenResponse.AccessToken = ""; // JWT Here {"alg":"HS512","typ":"JWT"}{"ViewerId":0,"DisplayName":"Nyaru","DeviceIdentifier":"000000000","nbf":000000,"exp":000000,"iat":000000}
            getAccessTokenResponse.ViewerId = 135112345;
            getAccessTokenResponse.DeviceIdentifier = new byte[] { 0x01, 0x7f, 0xea, 0x11, 0x31, 0x44, 0x55, 0x10, 0x3a, 0x77, 0xb1, 0x07, 0x28, 0x17, 0x45, 0x40 };

            var result = new ServiceResult<GetAccessTokenResponse, GetAccessTokenResult>();
            result.Succeeded = true;
            result.Result = getAccessTokenResponse;
            result.ErrorDetail = GetAccessTokenResult.Success;
            return result;

        }

        public async UnaryResult<ServiceResult<InitialDataResponse>> GetInitialDataAsync()
        {
            foreach (var data in Context.CallContext.RequestHeaders)
            {
                Console.WriteLine(data);
            }

            InitialDataResponse initialDataResponse = new InitialDataResponse();
            initialDataResponse.User = new UserResponse();
            initialDataResponse.User.AvatarId = 1105901;
            initialDataResponse.User.ViewerId = 135112345;
            initialDataResponse.User.Name = "Nyaru";
            initialDataResponse.User.BoardId = 1;
            initialDataResponse.User.TutorialStep = TutorialStep.PROLOGUE_END;
            initialDataResponse.User.CompletedBattleCount = 5;
            initialDataResponse.User.BattlePoint = 100000;
            initialDataResponse.User.LastLoggedInAt = DateTime.Now;
            initialDataResponse.User.Grade = 8;



            var result = new ServiceResult<InitialDataResponse>();
            result.Succeeded = true;
            result.ErrorDetail = new GeneralError();
            result.Result = initialDataResponse;
            return result;
        }
    }
}
