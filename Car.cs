using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment
{
    internal class Car
    {
        String companyName;
        String modelNumber;
        String typeEngine;

        public Car(string companyName, string modelNumber, string typeEngine)
        {
            this.companyName = companyName;
            this.modelNumber = modelNumber;
            this.typeEngine = typeEngine;
        }

        public void printAboutCar()
        {
            Console.WriteLine("Car is of this " + companyName + " company" + " and model is " + this.modelNumber + " of type " + this.typeEngine);
        } 
    }
}
