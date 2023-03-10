// Take one string from the input and print its last 5 characters.

string inputString = "";

while (inputString.Length < 5)
{
    Console.Write("Enter a string that will have a minimum of 5 characters > ");
    inputString = Console.ReadLine();

    if (inputString.Length < 5)
    {
        Console.WriteLine("The string entered is less than 5 characters !");
    }
}

string lastFiveChars = inputString.Substring(inputString.Length - 5);

Console.WriteLine("The last 5 characters of the entered string are: " + lastFiveChars);
