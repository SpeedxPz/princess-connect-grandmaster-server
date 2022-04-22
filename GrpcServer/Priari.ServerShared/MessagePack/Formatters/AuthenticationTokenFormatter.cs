using MessagePack;
using MessagePack.Formatters;
using Priari.ServerShared.MessagePackObjects.User;
using Priari.ServerShared.Primitives;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Priari.ServerShared.MessagePack.Formatters
{
    public sealed class AuthenticationTokenFormatter : IMessagePackFormatter<UserResponse>, IMessagePackFormatter
    {
        UserResponse IMessagePackFormatter<UserResponse>.Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
        {
            Console.WriteLine("Formatter");
            File.WriteAllBytes("D:\\hello.bytes", reader.Sequence.ToArray());
            //string output = reader.ReadString();
            //MessagePackType type = reader.NextMessagePackType;
            //reader.Skip();
            /* reader.TryReadNil();
             reader.ReadString();*/

            /*Console.WriteLine(reader.Position.GetInteger());
            Console.WriteLine(reader.Sequence.Length);
            Console.WriteLine(reader.Sequence.Length-reader.Position.GetInteger()-10);
            File.WriteAllBytes("D:\\hello.bytes", reader.Sequence.ToArray());
            Console.WriteLine("Saved");*/




            //Console.WriteLine(output);
            /*Console.WriteLine("Not Implemented");
            Console.WriteLine("1" + reader.TryReadNil());
            Console.WriteLine("2" + reader.ReadString());
            Console.WriteLine("3" + reader.ReadString());*/

            //string output = "";


            return new UserResponse();
        }

        void IMessagePackFormatter<UserResponse>.Serialize(ref MessagePackWriter writer, UserResponse value, MessagePackSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
