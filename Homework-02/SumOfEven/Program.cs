int[] inputNumbers = new int[6];
int sum = 0;

for (int i = 0; i < inputNumbers.Length; i++)
{

    bool validInput = false;

    while (!validInput)
    {

        Console.WriteLine("Enter a number:");
        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out int number))
        {

            inputNumbers[i] = number;
            validInput = true;
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }
}

for (int i = 0; i < inputNumbers.Length; i++)
{
    if (inputNumbers[i] % 2 == 0)
    {
        sum += inputNumbers[i];
    }
}

Console.WriteLine("Result is: " + sum);


