using EpicCalculator.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicCalculator.BLTest
{
    [TestClass]
    [TestCategory("Scientific Operations")]
    public class ScientificOperationsUnitTest
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
        public void Power()
        {
            //Arrange
            double baseNum = 2;
            double powerNum = 10;
            double expectedResult = 1024;

            //Act
            var actResult = _client.Power(baseNum, powerNum);

            //Assert
            Assert.AreEqual<double>(expectedResult, actResult);
        }

        [TestMethod]
        public void Log()
        {
            //Arrange
            double angle = 10;
            double logBase = 10;
            double expectedResult = 1;

            //Act
            var actResult = _client.Log(angle, logBase);

            //Assert
            Assert.AreEqual<double>(expectedResult, actResult);
        }

        [TestMethod]
        public void Sin90()
        {
            //Arrange
            double angle = 90;
            double expectedResult = 1;

            //Act
            var actResult = _client.Sin(angle);

            //Assert
            Assert.AreEqual<double>(expectedResult, actResult);
        }

        [TestMethod]
        public void Cos90()
        {
            //Arrange
            double angle = 90;
            double expectedResult = 0;

            //Act
            var actResult = _client.Cos(angle);

            //Assert
            Assert.AreEqual<double>(expectedResult, actResult);
        }

        [TestMethod]
        public void Tan45()
        {
            //Arrange
            double degrees = 45;
            double expectedResult = 1;

            //Act
            var actResult = _client.Tan(degrees);

            //Assert
            Assert.AreEqual<double>(expectedResult, actResult);
        }
    }
}
