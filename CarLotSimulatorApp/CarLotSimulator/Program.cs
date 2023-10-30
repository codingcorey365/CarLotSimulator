using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Done: Create a seperate class file called Car
            //Done: Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Done: Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //Done: methods should take one string parameter: the respective noise property
            //Done: Now that the Car class is created we can instanciate 3 new cars
            //Done: Set the properties for each of the cars
            //Done: Call each of the methods for each car

            //********************************************* BONUS x1 ************************************************
            //Done: Set the properties utilizing the 3 different ways we learned about, one way for each car

            //********************************************* BONUS x2 ************************************************
            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            //-------------------------------------------- calling with dot notation ---------------------------------

            var carLot1 = new CarLot();
            var carLot2 = new CarLot();

            var car1 = new Car
            {
                Year = 2009,
                Make = "Ford",
                Model = "Taurus",
                EngineNoise = "Clunk",
                HonkNoise = "Hooonk"
            };


            car1.MakeEngineNoise();
            car1.MakeHonkNoise();
            carLot1.CarsOnLot.Add(car1);
            Console.WriteLine(car1);
            //-------------------------------------------- Object Initializer Syntax ----------------------------------

            var car2 = new Car() { Year = 2016, Make = "Dodge", Model = "Challenger", EngineNoise = "Vroom!!", HonkNoise = "HONK!!" };

            //car2.Year = 2016;
            //car2.Make = "Dodge";
            //car2.Model = "Challenger";
            car2.MakeEngineNoise();
            car2.MakeHonkNoise();
            carLot2.CarsOnLot.Add(car2);
            Console.WriteLine(car2);

            //---------------------------------------------  custom constructor ---------------------------------------
            var car3 = new Car(1990, "ford", "taurus", "noises", "Beep Beep", true);

            //car3.Year = 1990;
            //car3.Make = "ford";
            //car3.Model = "taurus";
            //car3.MakeEngineNoise();
            //car3.MakeHonkNoise();
            carLot1.CarsOnLot.Add(car3);
            foreach (Car lotCar in carLot1.CarsOnLot)
            {
                Console.WriteLine($"{lotCar.Make} {lotCar.Model} {lotCar.Year}");
            }
            //Console.WriteLine({car3.Make});

            Console.WriteLine("----------------------------The list of cars on lot 1---------------------------------------");

            //foreach (var item in carLot1.CarsOnLot)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("Number of cars on lot");
           
            
        }
    }
}
