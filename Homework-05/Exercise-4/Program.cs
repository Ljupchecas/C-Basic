using Exercise_4.Clases;


List<Customer> customers = new List<Customer>();
customers.Add(new Customer("1234-1234-1234-1234", 4325, "Bob", "Bobsky", 650.75M));
customers.Add(new Customer("55-66", 1234, "Ljupche", "Cas", 500));


bool done = false;

while (!done)
{
    Console.WriteLine("Welcome to the ATM app");
    Console.Write("Please enter your card number: ");
    string cardNumberInput = Console.ReadLine().Replace("-", "");

    Customer customer = null;

    foreach (Customer c in customers)
    {
        if (c.GetCardNumber() == cardNumberInput)
        {
            customer = c;
            break;
        }
    }

    if (customer == null)
    {
        Console.WriteLine("Card not found. Do you want to register a new card? (Y/N)");
        string registerInput = Console.ReadLine();

        if (registerInput.ToLower() == "y")
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter your new card number: ");
            string cardNumber = Console.ReadLine().Replace("-", "");
            Console.Write("Enter a new pin: ");
            int pin = int.Parse(Console.ReadLine());
            Console.Write("Enter an initial deposit amount: ");
            decimal balance = decimal.Parse(Console.ReadLine());

            customer = new Customer(cardNumber, pin, firstName, lastName, balance);
            customers.Add(customer);
        }
        else
        {
            Console.WriteLine("Goodbye!");
            done = true;
        }
    }
    else
    {
        Console.Write("Enter Pin: ");
        int pinInput = int.Parse(Console.ReadLine());

        if (customer.CheckPin(pinInput))
        {
            Console.WriteLine("Welcome {0}!", customer.GetFullName());
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Cash Withdrawal");
            Console.WriteLine("3. Cash Deposit");
            Console.Write("> ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Your balance is {0:C}", customer.GetBalance());
                    break;
                case 2:
                    Console.Write("Enter amount to withdraw: ");
                    decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                    customer.Withdraw(withdrawAmount);
                    break;
                case 3:
                    Console.Write("Enter amount to deposit: ");
                    decimal depositAmount = decimal.Parse(Console.ReadLine());
                    customer.Deposit(depositAmount);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine("Do you want to perform another action? (Y/N)");
            string performAnotherAction = Console.ReadLine();

            if (performAnotherAction.ToLower() == "n")
            {
                Console.WriteLine("Thank you for using the ATM app.");
                done = true;
            }
        }
        else
        {
            Console.WriteLine("Incorrect Pin.");
        }
    }
}




