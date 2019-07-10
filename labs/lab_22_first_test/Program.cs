using System;
using System.Linq;

namespace lab_22_first_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class LabWork
    {
        public int CubeNumbers(int x, int y, int z)
        {
            return (x * y * z);
        }

        static public int CubeNumbersStatic(int x, int y, int z)
        {
            return (x * y * z);
        }

        public static int GetLengthOfArray(int[] myArray)
        {  
            return myArray.Length;
        }

        public static int SumTotalOfArrayMembers(int[] array)
        {
            int sumOfArray = 0;

            // return sum of array members
            foreach(int number in array)
            {
                sumOfArray += number;
            }

            return sumOfArray;
        }

        public static double MultiplicationAndFactors(double x, double y, double n)
        {
            return Math.Pow(x*y, n);
        }

        public static int[] SortArray(int[] array)
        {
            int[] sortedArray = array.OrderBy(i => i).ToArray();
            return sortedArray;
        }

        /*
        public static int[] SortCats(string[] name, int[] array)
        {
            foreach(int i in array)
            {
               
            }
            int[] sortedArray = array.OrderBy(i => i).ToArray();
            return sortedArray;
        }
        */
    }
}
