using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZeroScope;

namespace ZeroScopeTests
{
    [TestClass]
    public class ScopeAdjusterTest
    {

        [DataTestMethod]
        [DataRow(0.25, 0.25, 100.0, 0.0, 0.0, 0.0, 0.0, Direction.None, Direction.None)]
        [DataRow(0.25, 0.25, 800.0, 0.0, -16.0, 0.0, 8.0, Direction.None, Direction.Right)]
        [DataRow(0.25, 0.25, 800.0, 0.0, 16.0, 0.0, 8.0, Direction.None, Direction.Left)]
        [DataRow(0.25, 0.25, 800.0, -16.0, 0.0, 8.0, 0.0, Direction.Up, Direction.None)]
        [DataRow(0.25, 0.25, 800.0, 16.0, 0.0, 8.0, 0.0, Direction.Down, Direction.None)]
        [DataRow(2.0, 0.25, 800.0, -16.0, 0.0, 1.0, 0.0, Direction.Up, Direction.None)]
        [DataRow(0.25, 2.0, 800.0, 0.0, -16.0, 0.0, 1.0, Direction.None, Direction.Right)]
        [DataRow(1.0, 0.5, 100.0, -1.0, 1.0, 1.0, 2.0, Direction.Up, Direction.Left)]

        public void CalculatesScopeAdjustments(double vertMOAPerClick, double horMOAPerClick, double dist, double vertOffset, double horOffset, double vClicks, double hClicks, Direction vDir, Direction hDir)
        {
            var scope = new ScopeInfo { VerticalMOAPerClick = (decimal)vertMOAPerClick, HorizontalMOAPerClick = (decimal)horMOAPerClick };
            var shot = new ShotInfo { ShootingDistance = (decimal)dist, VerticalBulletOffset = (decimal)vertOffset, HorizontalBulletOffset = (decimal)horOffset };
            var expected = new ScopeAdjustment { HorizontalClicks = (decimal)hClicks, VerticalClicks = (decimal)vClicks, HorizontalDirection = hDir, VerticalDirection = vDir };

            var adjuster = new ScopeAdjuster();

            var output = adjuster.Calculate(scope, shot);

            Assert.AreEqual(expected, output);
        }

    }
}
