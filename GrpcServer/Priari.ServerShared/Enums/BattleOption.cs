using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.Enums
{
	public enum BattleOption
	{
		None = 0,
		毎ラウンドリロ\u30FCル無料 = 1,
		敗北時リロ\u30FCル無料 = 2,
		ドロップ増加 = 4,
		ギミックマスあり = 8,
		初期ユニット配布スキップ = 16,
		ギルドモ\u30FCド = 32,
		All = 63
	}
}
