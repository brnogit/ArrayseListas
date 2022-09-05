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
            // int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            //0-based
            for (var i = 0; i < numbers.Length; i++)
            {
                numbersCopy[i] = numbers[i];
            }

            // retornar uma lista de inteiro
            var numbersString = "0 1 2 3 4 5 6 7 8 9";
            var numbersArray = numbersString.Split(' ');
            var numbersConvertedFromString = Array.ConvertAll(numbersArray, Convert.ToInt32);
            #endregion Arrays

            #region LINQ
            #endregion LINQ
        }
    }
}
