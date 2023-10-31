using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // corrected version
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.

            var lotWithCars = new CarLot();

            //DONE: Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            //*************BONUS*************//
            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            // Using Dot Notation to call the variable
            var michaelsCar = new Car();
            michaelsCar.Year = 2013;
            michaelsCar.Make = "ford";
            michaelsCar.Model = "focus";
            michaelsCar.EngineNoise = "Vroom";
            michaelsCar.HonkNoise = "Beep";
            michaelsCar.IsDrivable = true;

            // add michaelsCar to the carlot
            lotWithCars.listOfCars.Add(michaelsCar);

            // Using Object Initializer Syntax
            var stevesCar = new Car()
            {
                Year = 2019,
                Make = "Tesla",
                Model = "Cyber Truck",
                EngineNoise = "Tik a Tik a Tik a Tik",
                HonkNoise = "Toot Toot",
                IsDrivable = false,
            };

            // add stevesCar to the carlot
            lotWithCars.listOfCars.Add(stevesCar);

            // Using the constructor to allow parameter values to be placed inside properties
            var brettsCar = new Car(2013, "Honda", "Civic", "Vrooooom", "Vruuuga", true);

            // add brettsCar to the carlot
            lotWithCars.listOfCars.Add(brettsCar);

            // Call the methods for each car
            Console.WriteLine("------------------------------------------ calling the methods ------------------------------------------");
            michaelsCar.MakeEngineNoise(michaelsCar.EngineNoise);
            michaelsCar.MakeEngineNoise("test");
            stevesCar.MakeEngineNoise(stevesCar.EngineNoise);
            brettsCar.MakeEngineNoise(brettsCar.EngineNoise);
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars

            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine("The following is a list of all the cars itemized in a list of the carlot, \"lotWithCars\", by year, make and model.");

            foreach (var car in lotWithCars.listOfCars)
            {
                Console.WriteLine($" Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }

        }
    }
}
