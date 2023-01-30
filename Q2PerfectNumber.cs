using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment
{
    internal class Q2PerfectNumber
    {
        public static void perfectNumber()
        {
            Console.WriteLine("last number from  1 put value- ");
            int m = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<=m; i++)  
            {
                int sum = 0;
                for(int j =1; j<i; j++) 
                {
                    if(i%j== 0) 
                    {
                        sum = sum+ j;

                    }
                }
                if(sum ==i)
                {
                    Console.WriteLine("perfect no. is " +i); 
                        
                }
            }
            
        }
    }
}
