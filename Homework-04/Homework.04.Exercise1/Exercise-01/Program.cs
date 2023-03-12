/*  
    ● Create a class Human
    ● Add properties: FirstName, LastName, Age
    ● Create a method called GetPersonStats that returns the full name of the human as well as their age
    ● Create an object human by asking the user to fill the required information
    ● Call the GetPersonStats method and print the result in the console after the object is created
*/

using Exercise_01.Clases;

Human human = new Human();

while (true)
{
    Console.Write("Enter first name: ");
    string firstName = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(firstName) || !firstName.All(char.IsLetter))
    {
        Console.WriteLine("Please enter a valid first name.");
    }
    else
    {
        human.FirstName = firstName;
        break;
    }
}

while (true)
{
    Console.Write("Enter last name: ");
    string lastName = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(lastName) || !lastName.All(char.IsLetter))
    {
        Console.WriteLine("Please enter a valid last name.");
    }
    else
    {
        human.LastName = lastName;
        break;
    }
}

while (true)
{
    Console.Write("Enter age: ");

    if (int.TryParse(Console.ReadLine(), out int age))
    {
        human.age = age;
        break;
    }
    else
    {
        Console.WriteLine("Please enter a valid age.");
    }
}


human.GetPersonStats();

