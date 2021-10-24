// C# program to sort an array
// using bucket sort
using System;
using System.Collections;
using System.Collections.Generic;
class BucketSort
{
    public static List<int> Sort(int[] x)
    {
        List<int> Array = new List<int>();

        int numOfBuckets = 10;
        List<int>[] buckets = new List<int>[numOfBuckets];
        for (int i = 0; i < numOfBuckets; i++)
        {
            buckets[i] = new List<int>();
        }
        for (int i = 0; i < x.Length; i++)
        {
            int bucket = (x[i] / numOfBuckets);
            buckets[bucket].Add(x[i]);
        }

        for (int i = 0; i < numOfBuckets; i++)
        {
            List<int> temp = MinSort(buckets[i]);
            Array.AddRange(temp);
        }
        return Array;
    }


    public static List<int> MinSort(List<int> arr)
    {
        for (int i = 0; i < arr.Count; i++)
        {
            int Min = arr[i];
            int ind = i;
            for (int j = i; j < arr.Count; j++)
            {
                if (arr[j] < Min)
                {
                    Min = arr[j];
                    ind = j;
                }
            }
            int temp = arr[ind];
            arr[ind] = arr[i];
            arr[i] = temp;
            
        }

        return arr;
    }
}