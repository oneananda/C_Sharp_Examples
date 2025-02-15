namespace MSTest_Basic
{
    [TestClass]
    public class BasicTests
    {
        [TestMethod]
        public void Calculator_Add_Returns_Correct_Sum()
        {
            // Arrange
            var calc = new Calculator();
            int a = 10, b = 20;

            // Act
            int result = calc.Add(a, b);

            // Assert
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void Calculator_Add_With_NegativeNumbers_Returns_Correct_Sum()
        {
            // Arrange
            var calc = new Calculator();
            int a = -5, b = 15;

            // Act
            int result = calc.Add(a, b);

            // Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Calculator_Divide_ByZero_Throws_Exception()
        {
            // Arrange
            var calc = new Calculator();
            int numerator = 10, denominator = 0;

            // Act
            calc.Divide(numerator, denominator);

            // Assert is handled by the ExpectedException attribute.
        }
    }

    public class Calculator
    {
        public int Add(int a, int b) => a + b;

        public float Divide(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException("Can't divide by zero!");
            return a / b;
        }
    }
}