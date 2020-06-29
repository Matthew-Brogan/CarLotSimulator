using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property            


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            Car Volvo = new Car();
            Volvo.Year = 2020;
            Volvo.Make = "Volvo";
            Volvo.Model = "S60";
            Volvo.IsDriveable = true;
            Volvo.EngineNoises =Volvo.MakeEngineNoise("Veeeee,psh,Veeeeee");
            Volvo.HonkNoise = Volvo.MakeHonkNoise("Meeeeep meeeeep");
            Console.WriteLine($"{Volvo.Year}, {Volvo.Model}, {Volvo.Make}, {Volvo.IsDriveable}, {Volvo.EngineNoises}, {Volvo.HonkNoise}");

            Car Ford = new Car() { Year = 2020, Make = "Ford", Model = "Mustang", IsDriveable = true };
            Ford.EngineNoises = Ford.MakeEngineNoise("Vroooooon");
            Ford.HonkNoise = Ford.MakeHonkNoise("Haahhhnk");
            Console.WriteLine($"{Ford.Year}, {Ford.Make} , {Ford.Model} , {Ford.EngineNoises}, {Ford.HonkNoise}, {Ford.IsDriveable}");

            Car Honda = new Car(1988, "Honda", "SI", "Veeeeeteechchh", "bip, bip", true);
            Console.WriteLine($"{Honda.Year}, {Honda.Make} , {Honda.Model}, {Honda.EngineNoises}, {Honda.HonkNoise}, {Honda.IsDriveable}" );


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            CarLot Inventory = new CarLot();
           



            List<string> CarsList = new List<string>();
            CarsList.Add(Inventory.Cars("Toyota", "Supra", 1999));
            CarsList.Add(Inventory.Cars("Honda", "Civic", 2019));

            foreach (var car in CarsList)
            {
                Console.WriteLine(car);
            }
        }
    }
}
