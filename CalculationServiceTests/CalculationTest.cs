using Testing;

namespace CalculationServiceTests
{
    /*
    1. test metodlari yalniz ve yalniz public void olur geriye hecne dondurmemelidir
    SUT - SYSTEM UNDER TEST
    2. Naming

     */
    [TestClass]
    public class CalculationTest
    {
        private readonly CalculationService _sut;
        public CalculationTest()
        {
            _sut = new CalculationService();
        }


        [TestMethod]
        [DataRow(4, 5)]
        [DataRow(10, 5)]
        [DataRow(80, 5)]
        [DataRow(90, 5)]
        public void MethodSum_ShouldReturnPositiveNumber_ForTwoPositiveNumbers(double a, double b)
        {
            // AAA -> triple A
            // Arrange

            // Act
            var actual = _sut.Sum(a, b);

            // Assert
            Assert.AreEqual(a + b, actual);
        }
        [TestMethod]
        [DynamicData(nameof(TestingNumbers))]
        public void MethodDivide_ShouldReturnDigit_ForTwoWholeNumber(double a, double b)
        {
            // Arrange

            // Act
            var res = _sut.Divide(a, b);

            // Assert
            Assert.AreEqual(a / b, res);
        }

        [TestMethod]
        public void MethodDivide_ShouldReturnZero_ForZeroNumber()
        {
            // Arrange
            double a = 5.2;
            double b = 0;

            // Act
            var res = _sut.Divide(a, b);

            // Assert
            Assert.AreEqual(0, res);
        }

        public static IEnumerable<object[]> TestingNumbers(object value)
        {
            return new[]
            {
            new object[] { true, new object[] { 100, 20 } },
            new object[] { true, new object[] { 100, 20 } },
            new object[] { true, new object[] { 10, 20 } },
            new object[] { true, new object[] { 10, 20 } },
            new object[] { true, new object[] { 100, 20 } },
            new object[] { true, new object[] { 100, 20 } }
        };
        }

    }
}
