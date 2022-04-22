using MessagePack;
using MessagePack.Formatters;
using Priari.ServerShared.MessagePackObjects.User;
using Priari.ServerShared.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePack.Formatters
{
    public sealed class MasterDataResponseFormatter : IMessagePackFormatter<MasterDataResponse>, IMessagePackFormatter
    {
        MasterDataResponse IMessagePackFormatter<MasterDataResponse>.Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
        {
            MessagePackType type = reader.NextMessagePackType;
            Console.WriteLine(type.ToString());
            throw new NotImplementedException();
        }

        void IMessagePackFormatter<MasterDataResponse>.Serialize(ref MessagePackWriter writer, MasterDataResponse value, MessagePackSerializerOptions options)
        {
            writer.WriteNil();
            throw new NotImplementedException();
        }
    }
}
