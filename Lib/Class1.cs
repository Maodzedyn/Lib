using System;
using System.Collections.Generic;

namespace Lib
{
    public class MyMath
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static double Sub(double a, double b)
        {
            return a - b;
        }
        public static double Mul(double a, double b)
        {
            return a * b;
        }
        public static double Div(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException();
                return a / b;
        }
        public static IEnumerable<double> XTest(double a, double b, double c) {
            double D = Math.Pow(b, 2) - (4 * a * c);
            if (D < 0)
                throw new Exception("No answers");

            return new List<double>() {
               ((-b + Math.Sqrt(D)) / (2 * a)),
            ((-b - Math.Sqrt(D)) / (2 * a))
        }; 
            
        }
    }
}
