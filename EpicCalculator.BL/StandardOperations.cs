using System;

namespace EpicCalculator.BL
{
    public partial class EpicCalculatorClient : IEpicCalculatorClient
    {
        public double Add(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }

        public double Subtract(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }

        public double Multiply(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }

        public double Divide(double firstNum, double secondNum)
        {
            return firstNum / secondNum;
        }
    }
}
