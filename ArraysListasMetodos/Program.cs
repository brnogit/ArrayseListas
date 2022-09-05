﻿using System;
using System.Collections.Generic;

namespace ArraysListasMetodos
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            #region Listas
            var list = new List<int> { 0, 1, 2, 3, 4 };
            var listFromArray = new List<int>(numbers);

            list.Add(5);
            list.AddRange(new List<int> {  6, 7 });
            list.AddRange(new int[] { 8, 9 });

            var count = list.Count;
            var contains14 = list.Contains(14);
            var contains2 = list.Contains(2);

            Console.WriteLine("Lista reversa: ");
            list.Reverse();
            list.ForEach(l => Console.WriteLine(l));

            Console.WriteLine("Lista ordenada");
            list.Sort();
            list.ForEach(l => Console.WriteLine(l));

            list.Remove(4);
            list.RemoveAll(l => l > 5);

            list.Clear();
            #endregion
        }
    }
}
