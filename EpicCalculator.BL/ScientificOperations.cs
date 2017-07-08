using System;
using System.Collections.Generic;
using System.Text;

namespace EpicCalculator.BL
{
    public partial class EpicCalculatorClient : IEpicCalculatorClient
    {
        public double Power(double baseNum, double powerNum)
        {
            return Math.Pow(baseNum, powerNum);
        }

        public double Log(double number, double logBase)
        {
            return Math.Log(number, logBase);
        }

        public double Sin(double degrees)
        {
            return Math.Sin(GetAngle(degrees));
        }

        public double Cos(double degrees)
        {
            return Math.Cos(GetAngle(degrees));
        }

        public double Tan(double degrees)
        {
            return Math.Tan(GetAngle(degrees));
        }

        private double GetAngle(double degrees)
        {
            return (Math.PI * degrees / 180.0);
        }
    }
}
