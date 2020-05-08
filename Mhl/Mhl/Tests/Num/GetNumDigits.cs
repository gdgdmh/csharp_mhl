using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Mhl.Tests.Num
{
	/// <summary>
	/// 
	/// </summary>
	class GetNumDigits
	{
		[SetUp]
		public void Setup()
		{
		}

		/// <summary>
		/// 0
		/// </summary>
		[Test]
		public void Test1()
		{
			List<uint> list = Mhl.Num.GetNumDigits.Get(0);
			Assert.AreEqual(list[0], 0);
		}

		/// <summary>
		/// 負の値(1桁)
		/// </summary>
		[Test]
		public void Test2()
		{
			List<uint> list = Mhl.Num.GetNumDigits.Get(-5);
			Assert.AreEqual(list[0], 5);
		}

		/// <summary>
		/// 正の値(2桁)
		/// </summary>
		[Test]
		public void Test3()
		{
			List<uint> list = Mhl.Num.GetNumDigits.Get(12);
			Assert.AreEqual(list[0], 2);
			Assert.AreEqual(list[1], 1);
		}

		/// <summary>
		/// 正の値(3桁)
		/// </summary>
		[Test]
		public void Test4()
		{
			List<uint> list = Mhl.Num.GetNumDigits.Get(567);
			Assert.AreEqual(list[0], 7);
			Assert.AreEqual(list[1], 6);
			Assert.AreEqual(list[2], 5);
		}

		/// <summary>
		/// 負の値(3桁)
		/// </summary>
		[Test]
		public void Test5()
		{
			List<uint> list = Mhl.Num.GetNumDigits.Get(-888);
			Assert.AreEqual(list[0], 8);
			Assert.AreEqual(list[1], 8);
			Assert.AreEqual(list[2], 8);
		}

		/// <summary>
		/// 負の値最大値-1
		/// </summary>
		[Test]
		public void Test6()
		{
			// int min
			List<uint> list = Mhl.Num.GetNumDigits.Get(-2147483648 + 1);
			Assert.AreEqual(list[0], 7);
			Assert.AreEqual(list[1], 4);
			Assert.AreEqual(list[2], 6);
			Assert.AreEqual(list[3], 3);
			Assert.AreEqual(list[4], 8);
			Assert.AreEqual(list[5], 4);
			Assert.AreEqual(list[6], 7);
			Assert.AreEqual(list[7], 4);
			Assert.AreEqual(list[8], 1);
			Assert.AreEqual(list[9], 2);
			//-2,147,483,648 ～ 2,147,483,647
		}

		/// <summary>
		/// 負の値最大値
		/// </summary>
		[Test]
		public void Test7()
		{
			// System.Math.Absで例外が発生する
			Assert.Throws<System.OverflowException>(() => Mhl.Num.GetNumDigits.Get(-2147483648));
		}

		/// <summary>
		/// 正の値最大値
		/// </summary>
		[Test]
		public void Test8()
		{
			// int max
			List<uint> list = Mhl.Num.GetNumDigits.Get(2147483647);
			Assert.AreEqual(list[0], 7);
			Assert.AreEqual(list[1], 4);
			Assert.AreEqual(list[2], 6);
			Assert.AreEqual(list[3], 3);
			Assert.AreEqual(list[4], 8);
			Assert.AreEqual(list[5], 4);
			Assert.AreEqual(list[6], 7);
			Assert.AreEqual(list[7], 4);
			Assert.AreEqual(list[8], 1);
			Assert.AreEqual(list[9], 2);
		}
	}
}
