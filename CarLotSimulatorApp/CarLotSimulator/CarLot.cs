using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator // namespace
{
    //Done: Create a CarLot class
    //It should have at least one property: a List of cars
    //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
    //At the end iterate through the list printing each of car's Year, Make, and Model to the console

    public class CarLot // class
    {
            //public List<string> carsOnLot = new List<string>();
        
        public CarLot() //constructor
        {
            // Is Blank....
            //public List<string> carsOnLot = new List<string>();
        }

        public List<Car> CarsOnLot = new List<Car>(); // List made in the scope of class

        public static int NumberOfCarsOnLot { get; set; } // ???? calls the variable?

    }
}
