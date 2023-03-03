// Не ми испаѓа со .TryParse исто како и проблемот со калкулатор задачата.
// Сакам да направам кога ќе внесам било што друго освен број да пише порака да внесам број.

Console.WriteLine("Enter a frist number:");
double number1 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter a second number:");
double number2 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter a third number:");
double number3 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter a fourth number:");
double number4 = double.Parse(Console.ReadLine());

double averageNumber = (number1 + number2 + number3 + number4) / 4;

Console.WriteLine("The Average Number is:  " + averageNumber);




