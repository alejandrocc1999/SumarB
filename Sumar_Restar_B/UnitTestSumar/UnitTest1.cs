using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumarB.Controllers;

namespace UnitTestSumar
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTest1()
        {
            //Arrange
            SumaController sumaController = new SumaController();
            int a = 2;
            int b = 3;
            int expected = 5;
            //Act
            int resultado = sumaController.Add(a, b);
            //Assert
            Assert.AreEqual(expected, resultado);
        }
    }
}
