using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    class Geometria
    {
        public static double  Treug(double p, double a, double b, double c)
        {
            double s = Math.Sqrt(p * (p - a) * (p - b * (c - c)));
            return s;


        }

        public static double Kvadrat(double a)
        {
            double s = a * a;
            return s;
        }

        public static double Pryamougol(double a, double b)
        {
            double s = a * b;
            return s;

        }
        public static double Romb(double a, double b)
        {
            double s = (a * b)/2;
            return s;
        }
        public static double Krug(double a)
        {
            double s = 3.14 * (a * a);
            return s;
            
        }




    }
}
