using Homework5Exercise2.Modules;
using System.Xml;

List<Car> cars = new List<Car>()
{
    new Car ("Hyndai", 120),
    new Car ("Mazda", 130),
    new Car ("Ferrarri", 280),
    new Car ("Porsche", 250),
};

List<Driver> drivers = new List<Driver>()
{
    new Driver ("Bob", 5),
    new Driver ("Greg", 3),
    new Driver ("Jill", 4),
    new Driver ("Anne", 2),
};

Console.WriteLine("Choose a car No.1: ");
DisplayCars(cars);
int car1Index = GetUserIndex(cars.Count);


Console.WriteLine("Choose driver for car No.1: ");
DisplayDrivers(drivers);
int driver1Index = GetUserIndex(drivers.Count);

Console.WriteLine("Choose car No.2: ");
DisplayCars(cars);
int car2Index = GetUserIndex(cars.Count);

Console.WriteLine("Choose driver for car No.2: ");
DisplayDrivers(drivers);
int driver2Index = GetUserIndex(drivers.Count);

Car car1 = cars[car1Index - 1];
car1.Driver = drivers[driver1Index - 1];

Car car2 = cars[car2Index - 1];
car2.Driver = drivers[driver2Index - 1];

if(car1.CalculateSpeed() > car2.CalculateSpeed())
{
    Console.WriteLine($"Car No.1 ({car1.Model}) was faster.");
}
else
{
    Console.WriteLine($"Car No.2 ({car2.Model}) was faster. ");
}


static void DisplayCars(List<Car> cars)
{
    for(int i = 0; i<cars.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {cars[i].Model} (Speed: {cars[i].Speed})");
    }
}

static int GetUserIndex(int maxIndex)
{
    int index = 0;
    while(index < 1 || index > maxIndex)
    {
        Console.WriteLine($"Enter a number between 1 and {maxIndex}: ");
        int.TryParse(Console.ReadLine(), out index);
    }
    return index;
}

static void DisplayDrivers(List<Driver> drivers)
{
    for (int i = 0; i < drivers.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {drivers[i].Name} (Skill level: {drivers[i].Level})");
    }
}