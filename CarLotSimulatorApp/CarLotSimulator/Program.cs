using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLot = new CarLot(); 

            var dodge = new Car()
            {
                Year = 2014,
                Make = "Dodge",
                Model = "Dart",
                EngineNoise = "vroom",
                HonkNoise= "beepbeep",
                IsDriveable = "yes"
            };

            dodge.MakeEngineNoise();
            dodge.MakeHonkNoise();

            var vw = new Car()
            {
                Year = 2021,
                Make = "VW",
                Model = "ID.4",
                EngineNoise = "whoosh",
                HonkNoise = "ehhhh",
                IsDriveable = "yes" };
    
            vw.MakeEngineNoise();
            vw.MakeHonkNoise();

            var toyota = new Car()
            {
                Year = 2020,
                Make = "Toyota",
                Model = "Rav4",
                EngineNoise = "whir",
                HonkNoise = "boing",
                IsDriveable = "yes"
            };

            toyota.MakeEngineNoise();
            toyota.MakeHonkNoise();

            carLot.Cars = new List<Car>() { dodge, vw, toyota };

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

        foreach(var car in carLot.Cars)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
                car.MakeEngineNoise();
                car.MakeHonkNoise();
                Console.WriteLine("-----------------");

            }


           

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
