using AreaLib.Models;
using NUnit.Framework;

namespace AreaLib.Test
{
	public class Tests
	{
		[Test]
		public void TestTriangle()
		{
			var triangle = new Triangle(3,5,4);
			Assert.IsTrue(triangle.CalculateArea == 6);
			Assert.IsTrue(triangle.RightTriangle);
		}

		[Test]
		public void TestRound()
		{
			var round = new Round(11);
			Assert.IsTrue(round.CalculateArea == 380.132711084365);
		}
	}
}