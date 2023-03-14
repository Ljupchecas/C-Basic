using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4.Clases
{
    public class Customer
    {
        private string cardNumber;
        private int pin;
        private string firstName;
        private string lastName;
        private decimal balance;

        public Customer(string cardNumber, int pin, string firstName, string lastName, decimal balance)
        {
            this.cardNumber = cardNumber;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }

        public string GetCardNumber()
        {
            return this.cardNumber;
        }
        public bool CheckPin(int pin)
        {
            return this.pin == pin;
        }

        public string GetFullName()
        {
            return this.firstName + " " + this.lastName;
        }

        public decimal GetBalance()
        {
            return this.balance;
        }

        public bool Withdraw(decimal amount)
        {
            if (this.balance >= amount)
            {
                this.balance -= amount;
                Console.WriteLine("You withdrew {0:C}. You have {1:C} left on your account.", amount, this.balance);
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
                return false;
            }
        }

        public void Deposit(decimal amount)
        {
            this.balance += amount;
            Console.WriteLine("You deposited {0:C}. Your new balance is {1:C}.", amount, this.balance);
        }
    }
}

