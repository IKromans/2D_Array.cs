using System;
using System.Linq;

namespace Program
{
    class TwoDArray
    {
        static void Main(string[] args)
        {
            int[,] array2d = new int[20, 20];

            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    Random rnd = new Random();
                    array2d[i, j] = rnd.Next(1000);
                    Console.Write("{0,3} ", array2d[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int minX = 0,
                minY = 0,
                maxX = 0,
                maxY = 0;
            int minValue = int.MaxValue, maxValue = int.MinValue;
            for (int x = 0; x < array2d.GetLength(0); x++)
            {
                for (int y = 0; y < array2d.GetLength(1); y++)
                {
                    if (array2d[x, y] < minValue)
                    {
                        minValue = array2d[x, y];
                        minX = x + 1;
                        minY = y + 1;
                    }
                    if (array2d[x, y] > maxValue)
                    {
                        maxValue = array2d[x, y];
                        maxX = x + 1;
                        maxY = y + 1;
                    }
                }
            }
            Console.WriteLine("The minimum value is {0} at position ({1}, {2})", minValue, minX, minY);
            Console.WriteLine("The maximum value is {0} at position ({1}, {2})", maxValue, maxX, maxY);
            Console.WriteLine();

            int[] flatArray = array2d.Cast<int>().ToArray();
            Array.Sort(flatArray);
            int[,] sortedArray = new int[array2d.GetLength(0), array2d.GetLength(1)];
            Buffer.BlockCopy(flatArray, 0, sortedArray, 0, flatArray.Length * sizeof(int));
            for (int i = 0; i < sortedArray.GetLength(0); i++)
            {
                for (int j = 0; j < sortedArray.GetLength(1); j++)
                {
                    Console.Write("{0,3} ", sortedArray[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
