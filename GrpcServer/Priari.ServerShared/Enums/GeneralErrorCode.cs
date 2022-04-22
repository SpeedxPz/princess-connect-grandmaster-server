using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.Enums
{
    public enum GeneralErrorCode
    {
        Unknown = 98000,
        NotFound,
        Conflict,
        ValidationFailed,
        BannedKeywordsContained,
        LimitExceeded
    }
}
