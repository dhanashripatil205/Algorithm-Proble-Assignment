using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTechniques
{
    public class PrimeNoInGIvenRange
    {
        public static void FindPrimeNo()
        {
            Console.WriteLine("Enter the Starting range : ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Ending range : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;
            int i, j;
            Console.WriteLine("Prime Numbers in range between 1-1000 are : ");
            for (i = 2; i <= 1000; i++)
            {
                for (j = 2; j <= 1000; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write("\t" + i);
                }
                isPrime = true;
            }
            Console.ReadLine();
        }
    }
}
