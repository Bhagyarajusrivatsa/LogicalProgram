using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    public class FibanaucciSeries

    {
        public static void Fibanaucci_Series()
        {
            int n = 10; // number of terms to generate
            int firstTerm = 0, secondTerm = 1, nextTerm;

            Console.WriteLine("Fibonacci Series:");

            for (int i = 1; i <= n; i++)
            {
                Console.Write(firstTerm + " ");

                nextTerm = firstTerm + secondTerm;
                firstTerm = secondTerm;
                secondTerm = nextTerm;
            }

            Console.ReadLine();
        }
    }
}

