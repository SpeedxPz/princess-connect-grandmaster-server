using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.MessagePackObjects
{
    [MessagePackObject]
    public class BossBattleRemainHpResponse
    {
        [Key(0)]
        public int BossUnitId { get; set; }

        [Key(1)]
        public int RemainHp { get; set; }


    }
}
