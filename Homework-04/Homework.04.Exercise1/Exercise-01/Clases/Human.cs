using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01.Clases
{
    public class Human
    {
        public Human()
        {
            FirstName = FirstName;
            LastName = LastName;
            age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int age { get; set; }

        public void GetPersonStats()
        {
            Console.WriteLine($"{FirstName} {LastName} {age} years old");
        }



    }
}

