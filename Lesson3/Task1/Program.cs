using System;
using System.Diagnostics;


namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"PointDistance  PointDistanceCl  PointDistanceShort  PointDistanceDouble");
            int T = 10;
            int N = 10000;
            Random rnd = new Random();
            int[,] arrpoints1 = new int[N, 2];
            int[,] arrpoints2 = new int[N, 2];
            PointStruct point1, point2;
            PointClass point3, point4;
            Stopwatch sw = new Stopwatch();
            for (int i = 0; i < N; ++i)
            {
                arrpoints1[i, 0] = rnd.Next(-100000, 100000);
                arrpoints1[i, 1] = rnd.Next(-100000, 100000);
                arrpoints2[i, 0] = rnd.Next(-100000, 100000);
                arrpoints2[i, 1] = rnd.Next(-100000, 100000);
            }
            sw.Start();
            for (int j = 0; j < N; j++)
            {
                point1 = new PointStruct { X = arrpoints1[j, 0], Y = arrpoints1[j, 0] };
                point2 = new PointStruct { X = arrpoints2[j, 0], Y = arrpoints2[j, 0] };
                var dist = Class1.PointDistance(point1, point2);
            }
            sw.Stop();
            Console.SetCursorPosition(3, 1);
            Console.Write($"{sw.Elapsed.TotalMilliseconds}");
            sw.Reset();
            sw.Start();
            for (int j = 0; j < N; j++)
            {
                point3 = new PointClass { X = arrpoints1[j, 0], Y = arrpoints1[j, 0] };
                point4 = new PointClass { X = arrpoints2[j, 0], Y = arrpoints2[j, 0] };
                var dist = Class1.PointDistanceCl(point3, point4);
            }
            sw.Stop();
            Console.SetCursorPosition(20, 1);
            Console.Write($"{sw.Elapsed.TotalMilliseconds} \t\t");
            sw.Reset();
            sw.Start();
            for (int j = 0; j < N; j++)
            {
                point1 = new PointStruct { X = arrpoints1[j, 0], Y = arrpoints1[j, 0] };
                point2 = new PointStruct { X = arrpoints2[j, 0], Y = arrpoints2[j, 0] };
                var dist = Class1.PointDistanceShort(point1, point2);
            }
            sw.Stop();
            Console.SetCursorPosition(40, 1);
            Console.Write($"{sw.Elapsed.TotalMilliseconds} ");

            sw.Reset();
            sw.Start();
            for (int j = 0; j < N; j++)
            {
                point1 = new PointStruct { X = arrpoints1[j, 0], Y = arrpoints1[j, 0] };
                point2 = new PointStruct { X = arrpoints2[j, 0], Y = arrpoints2[j, 0] };
                var dist = Class1.PointDistanceDouble(point1, point2);
            }
            sw.Stop();
            Console.SetCursorPosition(60, 1);
            Console.Write($"{sw.Elapsed.TotalMilliseconds}");






            

                
            
            //var point = new PointClass() { X = 42, Y = 42 };
            //var array = new PointClass[1];
            //array[0] = point;

            //var point = new PointStruct { X = 42, Y = 42 };
            //var array = new PointStruct[1];

        }
    }
}
