// Ич не ми текнува моментално како да направам проверка дали е број, и ако не е да прекине програмата.
// Не ми работи тука она што работеше во ЈС != number.
// Првично пробав со int.Parse ама кога не е број пука програмот.

Console.WriteLine("Enter a frist number:");
var number1 = Console.ReadLine();
bool num1 = int.TryParse(number1, out int parsedNumber1);

Console.WriteLine("Enter a second number:");
var number2 = Console.ReadLine();
bool num2 = int.TryParse(number2, out int parsedNumber2);


Console.WriteLine("Enter a operator:");
var operation = Console.ReadLine();

var result = 0;

if (operation == "+")
{
    result = parsedNumber1 + parsedNumber2;
}
else if (operation == "-")
{
    result = parsedNumber1 - parsedNumber2;
}
else if (operation == "*")
{
    result = parsedNumber1 * parsedNumber2;
}
else if (operation == "/")
{
    result = parsedNumber1 / parsedNumber2;
}
else
{
    Console.WriteLine("Enter an operator (+, -, *, /):");
}

Console.WriteLine("Result: " + result);













