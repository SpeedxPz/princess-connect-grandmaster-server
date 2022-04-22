using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Grpc.Net.Client;
using MagicOnion;
using MagicOnion.Client;
using MagicOnion.Server;
using Priari.ServerShared;
using Priari.ServerShared.Enums;
using Priari.ServerShared.MessagePackObjects;
using Priari.ServerShared.MessagePackObjects.User;
using Priari.ServerShared.Primitives;
using Priari.ServerShared.Services;

namespace Priari.Services
{

    public class UserService : ServiceBase<IUserService>, IUserService
    {
        public async UnaryResult<ServiceResult<CurrentBattleResponse>> GetCurrentBattleAsync()
        {
            foreach (var data in Context.CallContext.RequestHeaders)
            {
                Console.WriteLine(data);
            }

            var result = new ServiceResult<CurrentBattleResponse>();
            result.Succeeded = false;
            result.Result = null;
            var err = new GeneralError();
            err.Code = GeneralErrorCode.NotFound;
            err.Reason = "アクティブなバトルは存在しません";
            result.ErrorDetail = err;
            return result;
        }

        public async UnaryResult<ServiceResult<UserHomeDataResponse>> GetUserHomeDataAsync()
        {
            foreach (var data in Context.CallContext.RequestHeaders)
            {
                Console.WriteLine(data);
            }

            var resp = new UserHomeDataResponse();

            var user = new UserResponse();
            user.AvatarId = 1105901;
            user.ViewerId = 135112345;
            user.Name = "Nyaru";
            user.BoardId = 1;
            user.TutorialStep = TutorialStep.PROLOGUE_END;
            user.CompletedBattleCount = 5;
            user.BattlePoint = 100000;
            user.LastLoggedInAt = DateTime.Now;
            user.Grade = 8;
            resp.User = user;


            var furniture = new UserItemResponse();
            furniture.ViewerId = 135112345;

            List<ItemResponse> list = new List<ItemResponse>();
            list.Add(new ItemResponse(1, 1));
            list.Add(new ItemResponse(2, 1));
            list.Add(new ItemResponse(3, 1));
            list.Add(new ItemResponse(4, 1));
            list.Add(new ItemResponse(5, 1));
            list.Add(new ItemResponse(6, 1));
            list.Add(new ItemResponse(7, 1));
            list.Add(new ItemResponse(8, 1));
            list.Add(new ItemResponse(9, 1));
            furniture.Items = list;

            resp.Furnitures = furniture;

            var bossRemainHp = new BossBattleRemainHpResponse();
            bossRemainHp.BossUnitId = 310100;
            bossRemainHp.RemainHp = 50000;
            resp.BossRemainHp = bossRemainHp;

            var bossDeckList = new BossBattleDeckListResponse();
            resp.DeckList = bossDeckList;

            var forceDisplayInfo = new InformationListResponse();
            resp.ForceDisplayInformations = forceDisplayInfo;

            resp.RequestedAt = DateTimeOffset.Now.ToUnixTimeSeconds();
            

            var result = new ServiceResult<UserHomeDataResponse>();
            result.Succeeded = true;
            result.Result = resp;
            result.ErrorDetail = new GeneralError();



            return result;

        }

        public async UnaryResult<int> Debug(Ulid message)
        {
            Console.WriteLine(message.ToString());
            return 0;
        }
    }
}
