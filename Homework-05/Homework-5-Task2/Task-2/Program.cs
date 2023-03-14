using Task_2.Clases;

Driver[] drivers = new Driver[4]
       {
            new Driver { Name = "Bob", Level = 2 },
            new Driver { Name = "Greg", Level = 4 },
            new Driver { Name = "Jill", Level = 5 },
            new Driver { Name = "Anne", Level = 3 }
       };

Car[] cars = new Car[4]
{
            new Car { Model = "Hyundai", Speed = 120 },
            new Car { Model = "Mazda", Speed = 140 },
            new Car { Model = "Ferrari", Speed = 200 },
            new Car { Model = "Porsche", Speed = 180 }
};

bool done = false;

while (!done)
{

    Console.WriteLine("Choose a car no.1:");
    for (int i = 0; i < cars.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {cars[i].Model}");
    }
    int carIndex1 = int.Parse(Console.ReadLine()) - 1;

    Console.WriteLine("Choose Driver:");
    for (int i = 0; i < drivers.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {drivers[i].Name}");
    }
    int driverIndex1 = int.Parse(Console.ReadLine()) - 1;

    Console.WriteLine("Choose a car no.2:");
    for (int i = 0; i < cars.Length; i++)
    {
        if (i != carIndex1)
        {
            Console.WriteLine($"{i + 1}. {cars[i].Model}");
        }
    }
    int carIndex2 = int.Parse(Console.ReadLine()) - 1;

    Console.WriteLine("Choose Driver:");
    for (int i = 0; i < drivers.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {drivers[i].Name}");
    }
    int driverIndex2 = int.Parse(Console.ReadLine()) - 1;

    cars[carIndex1].Driver = drivers[driverIndex1];
    cars[carIndex2].Driver = drivers[driverIndex2];

    RaceCars(cars[carIndex1], cars[carIndex2]);

    Console.WriteLine("Do you want to race again? (y/n)");
    string answer = Console.ReadLine();
    if (answer == "n")
    {
        done = true;
    }
}

static void RaceCars(Car car1, Car car2)
{
    int car1Speed = car1.CalculateSpeed();
    int car2Speed = car2.CalculateSpeed();

    if (car1Speed > car2Speed)
    {
        Console.WriteLine($"Car no. {car1.Model} was faster. It was going at a speed of {car1Speed} and was driven by {car1.Driver.Name}.");
    }
    else if (car1Speed < car2Speed)
    {
        Console.WriteLine($"Car no. {car2.Model} was faster. It was going at a speed of {car2Speed} and was driven by {car2.Driver.Name}.");
    }
    else
    {
        Console.WriteLine("Both cars were equally fast.");
    }
}

