using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumarB.Controllers;

namespace UnitTestMultiply
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MultiplyTest1()
        {
            //Arrange
            SumaController multiplyController = new SumaController();
            int a = 2;
            int b = 5;
            int expected = 10;
            //Act
            int resultado = multiplyController.Mul(a, b);
            //Assert
            Assert.AreEqual(expected, resultado);
        }
    }
}
