using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating an object of Car() Class by using the Type Inference
            //called Car1
            var Car1 = new Car();
            //using dot notation to call members on Car1
            Car1.Color = "White";
            Car1.Year = 2010;
            Car1.Mileage = 11000;

            WriteLine($"This car is painted {Car1.Color}, was built in {Car1.Year}," +
                $" and had {Car1.Mileage} miles on it.");

            ReadKey();
        }
    }
    //Declaring the Car() Class
    //This class has 3 properties: color, year, and Mileage
    public class Car
    {
        //Defining properties
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
    }
}
