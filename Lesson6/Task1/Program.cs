using System;
using System.Collections.Generic;
using System.Xml.Linq;
using static System.Console;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 6;
            int[,] g = new int[n, n]
               {
               { 0,1,3,0,0,0 }, //0
               { 1,0,0,4,0,0 }, //1
               { 3,0,0,2,0,5 }, //2
               { 0,4,2,0,7,3 }, //3
               { 0,0,0,7,0,9 }, //4
               { 0,0,5,3,9,0 }, //5
                           };

            var colorV = new int[n];
            Queue<int> queue = new Queue<int>();

            int startV = 0;
            queue.Enqueue(startV);
            colorV[startV] = 1;
            while (queue.Count != 0)
            {
                var v = queue.Dequeue();
                Console.WriteLine($"вершина {v + 1}");

                for (int i = 0; i < n; i++)
                {
                    if (g[v, i] != 0 && colorV[i] == 0 && i != v)
                    {
                        queue.Enqueue(i);
                        colorV[i] = 1;
                    }
                }
            }
        }
    }
}
