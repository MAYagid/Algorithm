using System;

namespace Task2
{
    
    class Program
    {
        public static int BinFind(int[] array, int value)
        {
            int start, end;
            int cur;
            start = 0;
            end = array.Length - 1;
            cur = (start + end) / 2;
            while (array[cur] != value)
            {
                //Console.WriteLine($"{start}, {end}");
                if (array[cur] < value)
                {
                    start = cur + 1;
                    
                }
                else
                {
                    end = cur - 1;
                }
                cur = (start + end) / 2;
                if (start > end)
                {
                    return -1;
                }
            } 
            
            return cur;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Сложность О(log_2(N))");
            int[] arr = {1,3,4,5, 8, 10, 12, 13,17,20,21,23 };
            int val = 9;
            Console.WriteLine(BinFind(arr, val));
        }
    }
}
