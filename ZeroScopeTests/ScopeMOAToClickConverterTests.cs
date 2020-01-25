using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZeroScope;

namespace ZeroScopeTests
{
    [TestClass]
    public class ScopeMOAToClickConverterTests
    {

        [DataTestMethod]
        [DataRow(0.25, 1.0, 4.0)]
        [DataRow(4.0, 2.0, 0.0)]
        [DataRow(-2.0, 2.0, -1.0)]
        public void CalculatesClicks(double moaPerClick, double moa, double expected)
        {
            var converter = new ScopeMOAToClickConverter((decimal)moaPerClick);

            var output = converter.Convert((decimal)moa);

            Assert.AreEqual(expected, (double)output, 0.001);
        }

    }
}
