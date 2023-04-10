using static Practice___Classes__Week_1_.Bike;

namespace Practice___Classes__Week_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //public Car(string make, string model, int year, string color, int mileage)
            Car car = new Car("Toyota","Camery", 2021, "Black", 1000);
            Console.WriteLine(car);

            //public Bike(string brand, BikeType type, string color, int numberofwheels)
            Bike bike = new Bike("Diamondback", Bike.BikeType.electric, "blue", 2);
            Console.WriteLine(bike);

            //public House(string type, string year, string bedrooms, string bathrooms, string sqareft)
            House house = new House("Condo", "2015", "2", "1.5", 500);
            Console.WriteLine(house);
        }
    }
}