/* ● Create a class Student that has properties: Name, Academy and Group
   ● Create an array with 5 new Students(objects)
   ● The user should enter a name and the user information should be displayed in the console if a user by that name exists
   ● If there is no such user it should show an error message
*/



using Exercise3.Clases;

Student[] students = new Student[5];
students[0] = new Student { name = "Ljupche", academy = "SEDC", group = "G5" };
students[1] = new Student { name = "Mite", academy = "SEDC", group = "G5" };
students[2] = new Student { name = "Mice", academy = "SEDC", group = "G5" };
students[3] = new Student { name = "Dejan", academy = "SEDC", group = "G5" };
students[4] = new Student { name = "Hristina", academy = "SEDC", group = "G5" };

while(true)
{
    Console.Write("Enter student name: ");
    string name = Console.ReadLine();
    bool studentFound = false;

    foreach (Student student in students)
    {
        if (student.name == name)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Name: {student.name}, Academy: {student.academy}, Group: {student.group}");
            Console.ResetColor();
            studentFound = true;
        }
    }
    //break; - Tuka moze da stoj break za da zapre, ama zosto bi sakale da zapre? Neka proveruva kolku saka

    if (!studentFound)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"No student found with name: {name}");
        Console.ResetColor();
    }
}


