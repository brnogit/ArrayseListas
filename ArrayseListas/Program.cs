using System;

namespace ArrayseListas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            var numbersCopy = new int[10];
            var numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            //0-based
            for (var i = 0; i < numbers.Length; i++)
            {
                numbersCopy[i] = numbers[i];
            }
            #endregion Arrays

            #region LINQ
            #endregion LINQ
        }
    }
}
