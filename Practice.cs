using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment
{
    internal class Practice
    {
        string name;
        public Practice() {
            Console.WriteLine("Default Constructor");
        }

        public Practice(string name) {
            this.name = name;
            Console.WriteLine("Parameter constructor");
        }
        
        public void add(int a , int b)
        {
            Console.WriteLine(a + b);
            Console.WriteLine(name);
        }
    }
}
