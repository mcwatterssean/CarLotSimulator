using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            //Standard member initialization 
            CarLot lot = new CarLot();            //ClassName.StaticMember
            

            Car sonata = new Car();
            lot.CarList.Add(sonata);
            sonata.Year = 1999;
            sonata.Make = "Hyundai";
            sonata.Model = "Sonata";
            sonata.EngineNoise = "Vroom";
            sonata.HonkNoise = "Honk";
            sonata.isDriveable = true;

            sonata.MakeEngineNoise();
            sonata.MakeHonkNoise();

            //Object initializer syntax
            Car beetle = new Car() { Year = 2000, Make = "Volkswagon", Model = "Beetle", EngineNoise = "nothing", HonkNoise = "beep beep" };
            lot.CarList.Add(beetle);

            beetle.MakeEngineNoise();
            beetle.MakeHonkNoise();

            //Constructor initialization

            Car fakeCar = new Car(1800, "Fake Manufacturer", "Fake Model", "CHUGA CHUGA CHUGA", "boop", true);
            lot.CarList.Add(fakeCar);
       
            fakeCar.MakeEngineNoise();
            fakeCar.MakeHonkNoise();

            Console.WriteLine("-----------------------");




            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            Console.WriteLine($"Number of cars created {CarLot.numberOfCars}");

            foreach(var car in lot.CarList)
            {
                Console.WriteLine($"\n\nYear: {car.Year} Make: {car.Make} Model: {car.Model}");
            }

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
