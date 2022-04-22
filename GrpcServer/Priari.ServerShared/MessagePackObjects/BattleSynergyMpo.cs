using MessagePack;
using Priari.ServerShared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class BattleSynergyMpo
    {
        [Key(0)]
        public SynergyType SynergyType { get; set; }

        [Key(1)]
        public int Id { get; set; }

        [Key(2)]
        public int CurrentFieldCount { get; set; }

        [Key(3)]
        public int NextCount { get; set; }

        [Key(4)]
        public bool IsConfirmed { get; set; }


    }
}
