﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SortingTechniques
{
    public class SearchTheWordFromWordList
    {
        string[] Arr = { "Dhanu", "Kriti", "Kunal", "Kriya", "Ganesh", "Vandana", "Ankush", "Dhanashri", };
        public void List()
        {
            Console.WriteLine("Before Sorting List of word :");
            Console.Write("[ ");
            foreach (string str in Arr)
            {

                Console.Write(str + ", ");

            }
            Console.WriteLine("]");
            Console.WriteLine();
            Array.Sort(Arr);
            Console.WriteLine("\nAfter sorting List of word :");
            Console.Write("[ ");
            foreach (string str in Arr)
            {

                Console.Write(str + " ");

            }
            Console.WriteLine("]");
            Console.WriteLine();
        }
        public void Searching(string W)
        {
            int c = 0;
            foreach (string str in Arr)
            {
                if (W == str)
                {
                    Console.WriteLine("\nWord Found  " + W + "==" + str);
                    Console.WriteLine("\nPosition of Word in index : " + (Array.BinarySearch(Arr, W) - 1));
                    c = 1;
                }

            }
            if (c == 0)
            {
                Console.WriteLine("\nWord Not Found");
            }


        }
    }
}