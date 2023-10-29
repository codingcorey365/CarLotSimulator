using System;


namespace CarLotSimulator //namespace
{

    //Done: Create a seperate class file called Car
    //Done: Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
    //Done: Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
    //The methods should take one string parameter: the respective noise property


    public class Car //class
    {

        // ------------------------------------- constructors ------------------------------------------------------------

        public Car()//default constructor
        {
            CarLot.NumberOfCarsOnLot++;
        }

        public Car(string engineNoise, string honkNoise)//custom constructor
        {
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;// property and value
        }

        public Car(int year, string make, string model)//custom constructor
        {
            Year = year;
            Make = make;
            Model = model;            
        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)//custom constructor
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }


        // ----------------------------------------- Properties  ---------------------------------------

        public int Year {  get; set; }
        public string Make {  get; set; }
        public string Model {  get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }


        //-------------------------------------------- Methods ----------------------------------------

        public void MakeEngineNoise()
        {
            
            Console.WriteLine(EngineNoise); 
        }

        //-------------------------------------------- Methods ----------------------------------------

        public void MakeHonkNoise()
        {
            
            Console.WriteLine(HonkNoise); 
        }

        //-------------------------------------------- Methods ----------------------------------------
        public override string ToString()
        {
            return $"{Year} {Make} {Model}";
        }

    }
}
