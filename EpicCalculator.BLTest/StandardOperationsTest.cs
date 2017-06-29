using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EpicCalculator.BL;

namespace EpicCalculator.BLTest
{
    [TestClass]
    public class StandardOperationsTest
    {
        private IEpicCalculatorClient _client;

        [TestInitialize]
        public void Init()
        {
            _client = new EpicCalculatorClient();
        }

        [TestCleanup]
        public void CleanUp()
        {

        }

        [TestMethod]
        public void AddTwoPositiveNumbers()
        {
            //Arrange
            double firstNum = 10;
            double secondNum = 5;
            double expectedResult = 15;

            //Act
            var actResult = _client.Add(firstNum, secondNum);

            //Assert
            Assert.AreEqual<double>(expectedResult, actResult);
        }

        [TestMethod]
        public void AddTwoNegativeNumbers()
        {
            //Arrange
            double firstNum = -10;
            double secondNum = -5;
            double expectedResult = -15;

            //Act
            var actResult = _client.Add(firstNum, secondNum);

            //Assert
            Assert.AreEqual<double>(expectedResult, actResult);
        }

        [TestMethod]
        public void AddDifferentSignsNumbers()
        {
            //Arrange
            double firstNum = -10;
            double secondNum = 5;
            double expectedResult = -5;

            //Act
            var actResult = _client.Add(firstNum, secondNum);

            //Assert
            Assert.AreEqual<double>(expectedResult, actResult);
        }

        [TestMethod]
        public void SubtractTwoPositiveNumbers()
        {
            //Arrange
            double firstNum = 10;
            double secondNum = 5;
            double expectedResult = 5;

            //Act
            var actResult = _client.Subtract(firstNum, secondNum);

            //Assert
            Assert.AreEqual<double>(expectedResult, actResult);
        }

        [TestMethod]
        public void SubtractTwoNegativeNumbers()
        {
            //Arrange
            double firstNum = -10;
            double secondNum = -5;
            double expectedResult = -5;

            //Act
            var actResult = _client.Subtract(firstNum, secondNum);

            //Assert
            Assert.AreEqual<double>(expectedResult, actResult);
        }

        [TestMethod]
        public void SubtractDifferentSignsNumbers()
        {
            //Arrange
            double firstNum = -10;
            double secondNum = 5;
            double expectedResult = -15;

            //Act
            var actResult = _client.Subtract(firstNum, secondNum);

            //Assert
            Assert.AreEqual<double>(expectedResult, actResult);
        }

        [TestMethod]
        public void MultiplyTwoPositiveNumbers()
        {
            //Arrange
            double firstNum = 10;
            double secondNum = 5;
            double expectedResult = 50;

            //Act
            var actResult = _client.Multiply(firstNum, secondNum);

            //Assert
            Assert.AreEqual<double>(expectedResult, actResult);
        }

        [TestMethod]
        public void MultiplyTwoNegativeNumbers()
        {
            //Arrange
            double firstNum = -10;
            double secondNum = -5;
            double expectedResult = 50;

            //Act
            var actResult = _client.Multiply(firstNum, secondNum);

            //Assert
            Assert.AreEqual<double>(expectedResult, actResult);
        }

        [TestMethod]
        public void MultiplyDifferentSignsNumbers()
        {
            //Arrange
            double firstNum = -10;
            double secondNum = 5;
            double expectedResult = -50;

            //Act
            var actResult = _client.Multiply(firstNum, secondNum);

            //Assert
            Assert.AreEqual<double>(expectedResult, actResult);
        }

        [TestMethod]
        public void DivideTwoPositiveNumbers()
        {
            //Arrange
            double firstNum = 10;
            double secondNum = 5;
            double expectedResult = 2;

            //Act
            var actResult = _client.Divide(firstNum, secondNum);

            //Assert
            Assert.AreEqual<double>(expectedResult, actResult);
        }

        [TestMethod]
        public void DivideTwoNegativeNumbers()
        {
            //Arrange
            double firstNum = -10;
            double secondNum = -5;
            double expectedResult = 2;

            //Act
            var actResult = _client.Divide(firstNum, secondNum);

            //Assert
            Assert.AreEqual<double>(expectedResult, actResult);
        }

        [TestMethod]
        public void DivideDifferentSignsNumbers()
        {
            //Arrange
            double firstNum = -10;
            double secondNum = 5;
            double expectedResult = -2;

            //Act
            var actResult = _client.Divide(firstNum, secondNum);

            //Assert
            Assert.AreEqual<double>(expectedResult, actResult);
        }
    }
}
