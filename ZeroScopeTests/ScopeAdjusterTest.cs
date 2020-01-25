using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ZeroScope;

namespace ZeroScopeTests
{
    [TestClass]
    public class ScopeAdjusterTest
    {

        [DataTestMethod]
        public void CalculatesScopeAdjustment()
        {
            var calculator = new Mock<IMOACalculator>();
            calculator.Setup(c => c.Calculate(It.IsAny<decimal>(), It.IsAny<decimal>())).Returns(1.0M);

            var converter = new Mock<IMOAToClickConverter>();
            converter.Setup(c => c.Convert(It.IsAny<decimal>())).Returns(4.0M);

            var adjuster = new ScopeAdjuster(calculator.Object, converter.Object);

            var output = adjuster.Calculate(2.0M, 3.0M);

            calculator.Verify(c => c.Calculate(2.0M, 3.0M), Times.Once);
            converter.Verify(c => c.Convert(1.0M), Times.Once);
            Assert.AreEqual(4.0, (double)output, 0.001);
        }

    }
}
