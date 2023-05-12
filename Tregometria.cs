using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    class Tregometria
    {
     public static double Sina (double a)
        {
            double s = Math.Sin(a);
            return s;
        }
        public static double Cosa(double a)
        {
            double s = Math.Cos(a);
            return s;
        }
        public static double Tang(double a)
        {
            double s = Math.Tan(a);
            return s;
        }
        public static double Cotang(double a)
        {
            double s = 1 / Math.Tan(a);
            return s;
        }

    }
}
