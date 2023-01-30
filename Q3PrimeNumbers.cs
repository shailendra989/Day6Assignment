using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment
{
    internal class Q3PrimeNumbers
    {
        public static void  primeNumbers()
        {
            Console.WriteLine("write prime no.");
            int m = Convert.ToInt32(Console.ReadLine());
            int isFound = 0;

            for(int i=2; i<m; i++)
            {
                if(m%i== 0)
                {
                    isFound= 1;
                    break;
                    
                }                
            }
            if(isFound == 1)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                Console.WriteLine("Prime Number");
            }
        }
    }
}
