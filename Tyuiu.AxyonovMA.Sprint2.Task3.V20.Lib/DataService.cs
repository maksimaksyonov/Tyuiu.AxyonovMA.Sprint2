using tyuiu.cources.programming.interfaces.Sprint2;
using System;

namespace Tyuiu.AxyonovMA.Sprint2.Task3.V20.Lib
{
    public class DataService : ISprint2Task3V20
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 1)
            {
                // y = x * ((x + 1) / (x - 1))^x
                y = x * Math.Pow((x + 1) / (x - 1), x);
            }
            else if (x == 0)
            {
                // y = (x^2 - cos(x^2) + 10) / (x^2 - sin(x^2) + 12)
                double numerator = Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10;
                double denominator = Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12;
                y = numerator / denominator;
            }
            else if (x > -24 && x <= 1)
            {
                // y = (1 + 1/x^2)^x
                y = Math.Pow(1 + 1 / Math.Pow(x, 2), x);
            }
            else
            {
                // x < -24: y = x + 10x - (1/x)
                y = x + 10 * x - (1 / x);
            }

            return Math.Round(y, 3);
        }
    }
}