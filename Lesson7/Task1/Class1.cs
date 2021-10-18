using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class RectRoad
    {
        static int[,] tem = new int[100, 100];

        static RectRoad()
        {
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    tem[i, j] = -1;
                }
            }
        }

        public static int RoadCount(int m, int n)
        {

            if (m == 1 && n == 1)
            {
                tem[1, 1] = 1;
                return 1;
            }
            else if (m == 1 && n != 1)
            {
                if (tem[m,n] == -1)
                {
                    tem[m,n] = RoadCount(m, n - 1);
                    return RoadCount(m, n - 1);
                }
                return tem[m, n];
            }
            else if (m != 1 && n == 1)
            {
                if (tem[m, n] == -1)
                {
                    tem[m, n] = RoadCount(m - 1, n);
                    return RoadCount(m - 1, n);
                }
                return tem[m, n];
                
            }
            else
            {
                if (tem[m, n] == -1)
                {
                    tem[m, n] = RoadCount(m, n - 1) + RoadCount(m - 1, n);
                    return RoadCount(m, n - 1) + RoadCount(m - 1, n);
                }
                return tem[m, n];
                
            }
        }
        public static void PrintRoad(int m, int n)
        {
            int x;
            x = RectRoad.RoadCount(m, n);
            Console.WriteLine(x);
        }
    }
}
