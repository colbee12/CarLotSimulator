using System;
using System.Net.Http;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLotOne = new CarLot();
            
            
            //TODO
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            var carOne = new Car();
            carOne.Make = "Honda";
            carOne.Model = "fit";
            carOne.Year = 2000;
            carOne.IsDriveable = true;
            
            carOne.MakeHonkNoise("honk");
            carOne.MakeEnginNoise("vroom");

            carLotOne.ParkingLot.Add(carOne);
            
            ///////////////////////////////

            var carTwo = new Car()
            {
                Make = "BMW",
                Model = "IXL",
                Year = 2001,
                IsDriveable = true,
            };
            carTwo.MakeHonkNoise("Beep");
            carTwo.MakeEnginNoise("vroom Vroom");
            
            carLotOne.ParkingLot.Add(carTwo);
            
            
            
            ////////////////////////////////////

            var carThree = new Car("Ford", "stang", 2006, true);
            
            carThree.MakeHonkNoise("honk Honk");
            carThree.MakeEnginNoise("Roar");
            
            carLotOne.ParkingLot.Add(carThree);
            
            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            
            carLotOne.CheckCars();
        }
    }
}
