int[] numbers = new int[5];
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    bool validInput = false;

    while (!validInput)
    {
        Console.WriteLine("Enter a number: ");
        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out int number))
        {
            numbers[i] = number;
            validInput = true;
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");

        }
    }
}

for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}

Console.WriteLine("Result is:  " + sum);
