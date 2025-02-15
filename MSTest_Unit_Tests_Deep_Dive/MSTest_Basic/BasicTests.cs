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

        // Parameterized test for the Add method using DataTestMethod and DataRow
        [DataTestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(100, 200, 300)]
        [DataRow(-5, 5, 0)]
        public void Calculator_Add_DataTestMethod(int a, int b, int expected)
        {
            // Arrange
            var calc = new Calculator();

            // Act
            int result = calc.Add(a, b);

            // Assert
            Assert.AreEqual(expected, result);
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
        public void Calculator_Subtract_Returns_Correct_Result()
        {
            // Arrange
            var calc = new Calculator();
            int a = 20, b = 10;

            // Act
            int result = calc.Subtract(a, b);

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

        public int Subtract(int a, int b) => a - b;

        public float Divide(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException("Can't divide by zero!");
            return a / b;
        }
    }
}