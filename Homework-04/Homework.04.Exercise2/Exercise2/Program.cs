//● Create a class Dog
//● Add properties: Name, race, color
//● The dog needs to have an Eat method that returns message: The dog is now eating. A Play method returning a message :
//  The dog is now playing. and a ChaseTail method
//  that returns a message: Dog is now chasing its tail.
//● The user needs to create the dog object by inputs and then given an option to choose one of the actions mentioned above.




using Exercise2.Clases;

Dog dog = new Dog();

while (true)
{
    Console.Write("Enter a dog name > ");
    string dogName = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(dogName) || !dogName.All(char.IsLetter))
    {
        Console.WriteLine("Please enter a valid dog name !");
    }
    else
    {
        dog.Name = dogName;
        break;
    }
}

while (true)
{
    Console.Write("Enter a dog race > ");
    string race = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(race) || !race.All(char.IsLetter))
    {
        Console.WriteLine("Please enter a valid dog race !");
    }
    else
    {
        dog.Race = race;
        break;
    }
}

while (true)
{
    Console.Write("Enter a dog color > ");
    string color = Console.ReadLine();

    if(string.IsNullOrWhiteSpace(color) || !color.All(char.IsLetter))
    {
        Console.WriteLine("Please enter a valid dog color !");
    }
    else
    {
        dog.color = color;
        break;
    }
}

Console.WriteLine();
Console.WriteLine("Press Enter to continue the program");

while (true)
{
    ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

    if (keyInfo.Key == ConsoleKey.Enter)
    {
        break;
    }
}

while (true)
{
    Console.Write("Please select one of the methods offered - Eat, Play or Chase-Tail >");
    string inputMethod = Console.ReadLine().ToLower();

    if (inputMethod == "eat")
    {
        dog.Eat();
        break;
    }
    else if (inputMethod == "play")
    {
        dog.Play();
        break;
    }
    else if (inputMethod == "chase-tail")
    {
        dog.ChaseTail();
        break;
    }
    else
    {
        Console.WriteLine("Please select one of the options offered");
    }
}



