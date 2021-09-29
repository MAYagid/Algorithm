using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{

    class Class1
    {
        public static long Fib_Rec(int n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else return Fib_Rec(n - 1) + Fib_Rec(n - 2);
        }

        public static long Fib(int n)
        {
            long a1 = 0;
            long a2 = 1;
            for (int i = 0; i < n; i++)
            {
                long t = a1;
                a1 = a1 + a2;
                a2 = t;
            }
            return a1;
        }
    }
}
