string[] studentsG1 = { "Ljupche", "Dejan", "Sanja", "Tanja", "Tode" };
string[] studentsG2 = { "Mite", "Mice", "Tomo", "Dimitar", "Dragisha" };

int group = 0;
bool validInput = false;

while (!validInput)
{
    Console.WriteLine("Enter student group (1 or 2): ");
    string userInput = Console.ReadLine();

    if (int.TryParse(userInput, out int number) && (number == 1 || number == 2))
    {
        group = number;
        validInput = true;
    }
    else
    {
        Console.WriteLine("Please enter 1 or 2.");
    }
}

if (group == 1)
{
    Console.WriteLine("The students in G1 :");
    foreach (string student in studentsG1)
    {
        Console.WriteLine(student);
    }
}
else if (group == 2)
{
    Console.WriteLine("The students in G2 :");
    foreach (string student in studentsG2)
    {
        Console.WriteLine(student);
    }
}


