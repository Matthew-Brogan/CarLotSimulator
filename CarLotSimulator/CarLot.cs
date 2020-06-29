using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CarLotSimulator
{
    class CarLot
    {
        //Create a CarLot class
        //It should have at least one property: a List of cars
        //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
        //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        public List<Car> carList { get; set; } = new List<Car>();
        
        public string Make;
        public string Model;
        public int Year;

        


        public string Cars(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            return $"{Make}, {Model},{Year}";
        }

    }
}
