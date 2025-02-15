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
            Assert.AreEqual((a + b), result);
        }
    }

    public class Calculator
    {
        public int Add(int a, int b) => a + b;
    }
}