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

        public double Sin(double angle)
        {
            return Math.Round(Math.Sin(DegreeToRadian(angle)),3);
        }

        public double Cos(double angle)
        {
            return Math.Round(Math.Cos(DegreeToRadian(angle)), 3);
        }

        public double Tan(double angle)
        {
            return Math.Round(Math.Tan(DegreeToRadian(angle)), 3);
        }

        private double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }
    }
}
