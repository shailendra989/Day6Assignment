using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment
{
    internal class Q1FabbonacciSeries
    {

       
        public static void fabbonaciSeries()
        {
            Console.WriteLine("series how many time term - ");
            int a = Convert.ToInt32(Console.ReadLine());
            int lastDigit = 2;
            int SecondLastDigit = 1;
            Console.WriteLine("1");
            Console.WriteLine("2");
            for(int i=3;i<a;i++)
            {
                int nextdigit = lastDigit + SecondLastDigit;
                Console.WriteLine(nextdigit);
                SecondLastDigit = lastDigit;
                lastDigit= nextdigit;


            }

        }
    }
}
