using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.Enums
{
    public enum GetAccessTokenResult
    {
        Success,
        NotFoundOrInvalidToken,
        Banned
    }
}
