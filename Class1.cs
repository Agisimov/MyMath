using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public class Algebra

    {
        public static int Summ(int [] a )
        {
            int sum=0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;

        }


        public static int NumberMax(int [] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (i<a.Length)
                {
                    if (a[i] <= a[i + 1])
                    {
                        sum = a[i + 1];
                    }
                    else
                    {
                        sum = a[i];
                    }
                }
                
            }
            return sum;

        }
        public static int NumberMin(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (i<a.Length)
                {
                    if (a[i] >= a[i + 1])
                    {
                        sum = a[i + 1];
                    }
                    else
                    {
                        sum = a[i];
                    }
                }
               
            }
            return sum;

        }

        public static double Srednee(int[] a)

        {
            double sum =0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
               
            }
            sum = sum / a.Length;
            return sum;
        }



    }
}
    