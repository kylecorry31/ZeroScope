using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZeroScope;

namespace ZeroScopeTests
{
    [TestClass]
    public class ReferenceMOACalculatorTests
    {
        [DataTestMethod]
        [DataRow(100.0, 1.047, 1.0)]
        [DataRow(200.0, 1.047, 0.5)]
        [DataRow(50.0, 1.047, 2.0)]
        [DataRow(100.0, -1.047, -1.0)]
        public void CalculatesMOA(double distanceToTarget, double distanceFromCenter, double expected)
        {
            var calculator = new ReferenceMOACalculator();

            var output = calculator.Calculate((decimal)distanceToTarget, (decimal)distanceFromCenter);

            Assert.AreEqual(expected, (double)output, 0.001);
        }

    }
}
