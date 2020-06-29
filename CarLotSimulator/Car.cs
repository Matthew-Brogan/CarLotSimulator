using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace CarLotSimulator
{
    class Car
    {
        //TODO

        //Create a seperate class file called Car Done
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property    
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoises { get; set; }
        public string HonkNoise { get; set; }
        public  bool IsDriveable { get; set; }
        public Car()
        {

        }
        public string MakeEngineNoise(string EngineNoise)
        {
            this.EngineNoises = EngineNoise;
            return EngineNoises;

        }
        public string MakeHonkNoise(string honk)
        {
            this.HonkNoise = honk;
            return honk;
        }
        public Car(int Year, string Make, string Model, string EngineNoise , string HonkNoise, bool IsDrivable)
        {
            this.Year = Year;
            this.Make = Make;
            this.Model = Model;
            this.EngineNoises = MakeEngineNoise(EngineNoise);
            this.HonkNoise = MakeHonkNoise(HonkNoise);
            this.IsDriveable = IsDrivable;
            
        }

        //Now that the Car class is created we can instanciate 3 new cars
        //Set the properties for each of the cars
        //Call each of the methods for each car
    }
}
