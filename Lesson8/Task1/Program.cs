using System;
using System.Collections;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 43, 17, 87, 92, 31, 6, 96, 13, 66, 62, 4 };

            Console.WriteLine("Bucket Sort");        
            List<int> sorted = BucketSort.Sort(array);
            for (int i = 0; i < sorted.Count; i++) Console.Write($"{sorted[i]} ");
            Console.ReadLine();
        }
    }
}
