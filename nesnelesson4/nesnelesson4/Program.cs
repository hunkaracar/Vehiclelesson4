using nesnelesson4;


namespace nesnelesson4;


class program
{
    public static void Main()
    {
        Vehicle vehicle = new Vehicle();

        vehicle.Engine = 6.0; //vehicle da yazdığımız koddan dolayı bura sıfır(0) değeri alır.
        vehicle.Model = "ford";
        vehicle.NumberOfWheel = 4;
        vehicle.Price = 2500000;
        vehicle.Transmission = "auto";

        Console.WriteLine(vehicle.ToString());
        Console.WriteLine("**********************");


        Car car = new Car(2.4,"volvo",6,750000,"auto");
        Bus bus = new Bus(3.5,"mercedes",6,1000000,"manuel");
        Truck truck = new Truck(5.0,"Man",4,1938011,"auto");//12 den büyük value girersek exception hatası verir.


        Console.WriteLine(car.ToString());
        car.Start();
        Console.WriteLine("working car engine to 1 hours");
        car.Stop();
        Console.WriteLine("**********************");
        Console.WriteLine(bus.ToString());
        Console.WriteLine("**********************");
        Console.WriteLine(truck.ToString());

       


    }
}