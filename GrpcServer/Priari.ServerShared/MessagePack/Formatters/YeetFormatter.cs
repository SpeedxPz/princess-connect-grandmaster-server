using MessagePack;
using MessagePack.Formatters;
using Priari.ServerShared.MessagePackObjects;
using Priari.ServerShared.MessagePackObjects.User;
using Priari.ServerShared.Primitives;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Priari.ServerShared.MessagePack.Formatters
{
    public sealed class YeetFormatter : IMessagePackFormatter<Yeet>, IMessagePackFormatter
    {
        Yeet IMessagePackFormatter<Yeet>.Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
        {
            Console.WriteLine($"Reader Current Position: {reader.Position.GetInteger()}");
            Console.WriteLine($"Reader Length: {reader.Sequence.Length}");


            Console.WriteLine(Ulid.NewUlid().ToString());

            Ulid result = Ulid.Parse(reader.ReadBytes().GetValueOrDefault().ToArray());
            
            //Console.WriteLine($"Reader Current Position: {reader.Position.GetInteger()}");

            //Console.WriteLine(reader.ReadUInt32());

            //Console.WriteLine("Formatter");
            //File.WriteAllBytes("D:\\hello.bytes", reader.Sequence.ToArray());
            File.WriteAllBytes("D:\\ulid_recv.bytes", reader.ReadBytes().GetValueOrDefault().ToArray());
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


            //return new Yeet(reader.ReadBoolean());
            return new Yeet(true);
        }

        void IMessagePackFormatter<Yeet>.Serialize(ref MessagePackWriter writer, Yeet value, MessagePackSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
