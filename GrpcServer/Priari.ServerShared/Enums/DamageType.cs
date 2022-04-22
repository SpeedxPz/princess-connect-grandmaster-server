using System;
using System.Collections.Generic;
using System.Text;

namespace Priari.ServerShared.Enums
{
	public enum DamageType
	{
		None = 0,
		Physical = 1,
		Magical = 2,
		Piercing = 4,
		Critical = 8,
		Additional = 16,
		SureHit = 32,
		UseBaseAttack = 64,
		Avoid = 128,
		Calculated = -2147483648
	}
}
