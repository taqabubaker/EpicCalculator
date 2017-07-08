using System;
using System.Collections.Generic;
using System.Text;

namespace EpicCalculator.BL
{
    public interface IEpicCalculatorClient
    {
        #region CalculatorOperations Services

        double Add(double firstNum, double secondNum);
        double Subtract(double firstNum, double secondNum);
        double Multiply(double firstNum, double secondNum);
        double Divide(double firstNum, double secondNum);

        #endregion

        #region ScientificOperations Services

        double Power(double baseNum, double powerNum);
        double Log(double number, double logBase);
        double Sin(double angle);
        double Cos(double angle);
        double Tan(double angle);

        #endregion
    }
}
