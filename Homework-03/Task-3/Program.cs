// Create a function that takes a number as input. This method should return the sum of the digits in the number.

static int CalculateDigitSum(int number)
{
    int sum = 0;

    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }

    return sum;
}

bool validInput = false;

while (!validInput)
{
    Console.Write("Enter a number >  ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out int number))
    {
        int finallySum = CalculateDigitSum(number);
        Console.WriteLine("The sum of the digits > " + finallySum);
        validInput = true;
    }
    else
    {
        Console.WriteLine("Please enter a number !");
    }
}







