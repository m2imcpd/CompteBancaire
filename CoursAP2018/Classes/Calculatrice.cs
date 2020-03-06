using System;
using System.Collections.Generic;
using System.Text;

namespace CoursAP2018.Classes
{
    public class Calculatrice
    {
        //public delegate double CalculeDelegate(double a, double b);

        public Func<double, double, double> methodeCalcule;
        public static double Addition(double a, double b)
        {
            Console.WriteLine(a + b);
            return a + b;
        }

        public static double Soustraction(double a, double b)
        {
            Console.WriteLine(a - b);
            return a - b;
        }

        public static void Calcule(double a, double b, Func<double, double, double> methodeCalcule)
        {
            Console.WriteLine(methodeCalcule(a, b));
        }

        //public void Calcule(double a, double b)
        //{
        //    Console.WriteLine(methodeCalcule(a, b));
        //}

    }
}
