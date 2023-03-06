string[] namesArray = new string[0];
string nameInput;

while (true)
{
    Console.Write("Enter a name :");
    nameInput = Console.ReadLine();

    Array.Resize(ref namesArray, namesArray.Length + 1);
    namesArray[namesArray.Length - 1] = nameInput;

    string continueInput;

    while (true)
    {
        Console.Write("Do you want to enter another name? (Y/N): ");
        continueInput = Console.ReadLine().ToUpper();
        
        if (continueInput == "Y" || continueInput == "N")
        {
            break;
        }
        else
        {
            Console.WriteLine("You must enter 'Y' or 'N'.");
        }

    }

    if (continueInput.ToUpper() == "N")
    {
        break;
    }
}

Console.WriteLine("\nAll names:");

foreach (string name in namesArray)
{
    Console.WriteLine(name);
}

