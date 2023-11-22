
using FactoryMethodEx1;
using FactoryMethodEx1.Factory;
using FactoryMethodEx1.Factory.ConcreteFactories;

Console.WriteLine("Welcome to Factory Method Example");

VehicleFactory vFactory = null;

while (true)
{
    Console.WriteLine("\nPlease choose a vehicle typle: (1) Car, (2) Motorcycle, (3) Bike , (4) Quit");
    int option = Convert.ToInt32(Console.ReadLine());

    if (option == 4)
    {
        Console.WriteLine("Thanks for using the system");
        break;
    }
    else if (option >= 1 && option <=3)
    {
        switch (option)
        {
            case 1:
                vFactory = new CarFactory();
                break;
            case 2:
                vFactory = new MotorcycleFactory();
                break;
            case 3:
                vFactory = new BikeFactory();
                break;
                
        }
        IVehicle vehicle = vFactory.OrderVehicle();

        Console.WriteLine($"You have used a {vehicle.GetType().Name}. \n");
    }
    else
    {
        Console.WriteLine($"Your option is not valid: {option}");
        break;
    }

    
}

