using hwC_Step.Enums;

namespace hwC_Step.Models
{
    internal class Car
    {
        public Fuels FuelType { get; set; }
        public int Fuel { get; set; }
        public CarFuelType Model { get; set; }

        public Car() { }

        public Car(
            Fuels fuelType, 
            CarFuelType model,
            int fuel)
        {
            FuelType = fuelType;
            Model = model;
            Fuel = fuel;
        }


        public void refuel()
        {
            if (FuelType == Fuels.Electric)
            {
                Console.WriteLine("The car is being charged with electricity.");
            }
            else if (FuelType == Fuels.Gasoline)
            {
                Console.WriteLine("The car is being refueled with gasoline.");
            }
            else if (FuelType == Fuels.Diesel)
            {
                Console.WriteLine("The car is being refueled with diesel.");
            }
            else
            {
                Console.WriteLine("Congrats you just broke your car");
            }
        }
        public void Drive() { 
        if(FuelType == Fuels.Electric)
            {
                Console.WriteLine("The car is driving silently on electric power.");
            }
            else if (FuelType == Fuels.Gasoline)
            {
                Console.WriteLine("The car is driving with a roar on gasoline power.");
            }
            else if (FuelType == Fuels.Diesel)
            {
                Console.WriteLine("The car is driving steadily on diesel power.");
            }
            else
            {
                Console.WriteLine("Congrats you just broke your car");
            }
        }
    }
}
