using System;
using System.Collections.Generic;
using System.Text;

namespace Mhl.Num
{
	static class GetNumDigits
	{
		static public List<uint> Get(int num)
		{
			int n = System.Math.Abs(num);
			List<uint> digits = new List<uint>();
			do
			{
				int d = n % 10;
				digits.Add((uint)d);
				n /= 10;
			} while (n > 0);
			return digits;
		}
	}
}
