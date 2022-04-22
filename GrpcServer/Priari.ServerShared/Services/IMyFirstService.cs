using System;
using System.Collections.Generic;
using System.Text;
using MagicOnion;

namespace Priari.ServerShared.Services
{
    public interface IMyFirstService : IService<IMyFirstService>
    {
        UnaryResult<int> SumAsync(int x, int y);
    }
}
