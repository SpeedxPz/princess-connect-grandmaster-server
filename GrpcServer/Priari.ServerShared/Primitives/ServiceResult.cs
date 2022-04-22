using System;
using System.Collections.Generic;
using System.Text;
using MessagePack;
using Priari.ServerShared.MessagePackObjects;

namespace Priari.ServerShared.Primitives
{
    [MessagePackObject]
    public class ServiceResult<T, TError> : IServiceResult
    {

        [Key(0)]
        public T Result { get; set; }

        [Key(1)]
        public bool Succeeded { get; set; }

        [Key(2)]
        public TError ErrorDetail { get; set; }

        /*public ServiceResult(T result, bool succeeded, TError errorDetail)
        {
            this.Result = result;
            this.Succeeded = succeeded;
            this.ErrorDetail = errorDetail;
        }*/
    }

    [MessagePackObject]
    public sealed class ServiceResult<T> : ServiceResult<T, GeneralError>
    {

    }
}
