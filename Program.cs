using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = { 3, 7, 22, 2, 78 };
            int mn = 0, mx = 0;

            Console.Write("\n[");
            for (int i = 0; i < a.Length; i++)
            {   
                if (i < a.Length - 1)
                  Console.Write("{0} ", a[i]);
                else
                  Console.Write("{0}", a[i]);
                if (a[i] > a[mx]) mx = i;
                if (a[i] < a[mn]) mn = i;
            }
            Console.WriteLine("] -> {0}", a[mx] - a[mn]);

            Console.ReadKey();
        }
    }
}
