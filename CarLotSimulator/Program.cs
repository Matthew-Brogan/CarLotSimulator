using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            CarLot carLot = new CarLot();
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
            Volvo.EngineNoises = "wwhhhheeeeeeeeen";
            Volvo.HonkNoise = "Meeeeep meeeeep";
            //Console.WriteLine($"{Volvo.Year}, {Volvo.Model}, {Volvo.Make}, {Volvo.IsDriveable}, {Volvo.EngineNoises}, {Volvo.HonkNoise}");
            Console.WriteLine(Volvo.MakeEngineNoise(Volvo.EngineNoises));
            Console.WriteLine(Volvo.MakeEngineNoise(Volvo.HonkNoise));


            Car Ford = new Car() { Year = 2020, Make = "Ford", Model = "Mustang", EngineNoises = "Vroom", HonkNoise = "Haahhhnk" , IsDriveable = true };
            Console.WriteLine(Ford.MakeEngineNoise(Ford.EngineNoises));
            Console.WriteLine(Ford.MakeHonkNoise(Ford.HonkNoise));
            //Console.WriteLine($"{Ford.Year}, {Ford.Make} , {Ford.Model} , {Ford.EngineNoises}, {Ford.HonkNoise}, {Ford.IsDriveable}");

            Car Honda = new Car(1988, "Honda", "SI", "Veeeeeteechchh", "bip, bip", true);
            //Console.WriteLine($"{Honda.Year}, {Honda.Make} , {Honda.Model}, {Honda.EngineNoises}, {Honda.HonkNoise}, {Honda.IsDriveable}" );
            Console.WriteLine(Honda.MakeEngineNoise(Honda.EngineNoises));
            Console.WriteLine(Honda.MakeHonkNoise(Honda.HonkNoise));
            carLot.carList.Add(Volvo);
            carLot.carList.Add(Ford);
            carLot.carList.Add(Honda);



            foreach(Car car in carLot.carList)
            {
                Console.WriteLine($"Year = {car.Year}, Make = {car.Make}, Model = {car.Model}");
            }
            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            



            
        }
    }
}
