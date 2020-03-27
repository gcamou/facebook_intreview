using System;

namespace Facebook_Intreview
{
    class Program
    {
        static void Main(string[] args)
        {
            // Case 1, two arrays, with same numbers of data
            //int[] a = new int[] { 1, 3, 5 };
            //int[] b = new int[] { 2, 4, 6 };

            // Case 2, two arrays, one with more elements than the other
            //int[] a = new int[] { 1, 5 };
            //int[] b = new int[] { 2, 4, 6 };

            // Case 3, two arrays, one array empty and the other has elements
            //int[] a = new int[0];
            //int[] b = new int[] { 2, 4, 6 };

            // Case 3, two arrays, one array empty and the other has elements
            int[] a = new int[] { 1, 5, 19};
            int[] b = new int[] { 2, 4, 6 };

            PrintArray(a, 0, b, 0);
        }

        static void PrintArray(int[] arrayA, int depthA, int[] arrayB, int depthB)
        {
            if (arrayA.Length <= depthA && arrayB.Length <= depthB) return;

            if (arrayA.Length == depthA)
            {
                Console.Write(arrayB[depthB] + ",");
                depthB++;
            }
            else if (arrayB.Length == depthB)
            {
                Console.Write(arrayA[depthA] + ",");
                depthA++;
            }
            else if (arrayA[depthA] < arrayB[depthB])
            {
                Console.Write(arrayA[depthA] + ",");
                depthA++;
            }
            else
            {
                Console.Write(arrayB[depthB] + ",");
                depthB++;
            }

            PrintArray(arrayA, depthA, arrayB, depthB);
        }
    }
}
