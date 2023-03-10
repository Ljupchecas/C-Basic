//*Make a method called AgeCalculator
//* The method will have one input parameter, your birthday date
//* The method should return your age
//* Show the age of a user after he inputs a date
//> Note: take into consideration if the birthday is today, after or before today


bool validInput = false;

while (!validInput)
{
    Console.Write("Enter your birthday (yyyy-mm-dd) > ");
    string input = Console.ReadLine();
    int age = AgeCalculator(input);

    if (age >= 0)
    {
        Console.WriteLine("Your age is: " + age);
        validInput = true;
    }
    else
    {
        Console.WriteLine("You entered the wrong input. Try agen ! ");
    }
}
int AgeCalculator(string noParsedBirthday)
{
    DateTime today = DateTime.Today;
    if (DateTime.TryParse(noParsedBirthday, out DateTime parsedBirthday))
    {
        int age = today.Year - parsedBirthday.Year;
        if (parsedBirthday > today.AddYears(-age))
        {
            age--;
        }
        return age;
    }
    return -1;
}



