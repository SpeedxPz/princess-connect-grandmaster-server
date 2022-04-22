using MessagePack;
using Priari.ServerShared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class FieldCellDataMpo
    {
        [Key(0)]
        public FieldCellGimmickType GimmickType { get; set; }

        [Key(1)]
        public IReadOnlyList<float> Values { get; set; }


    }
}
