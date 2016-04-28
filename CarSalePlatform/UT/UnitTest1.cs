using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarSalePlatform;

namespace UT
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			Car car = new Car("Tom");

			Assert.AreEqual(car.Drive(), "Tom is driving");
		}
	}
}
