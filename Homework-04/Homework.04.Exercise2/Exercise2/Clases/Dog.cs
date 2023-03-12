
namespace Exercise2.Clases
{
    public class Dog
    {

        public Dog() 
        {
            Name = Name;
            Race = Race;
            color = color;
        }

        public string Name { get; set; }
        public string Race { get; set; }
        public string color { get; set; }

        
        public void Eat()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The {color} dog {Race} {Name} is now eating");
            Console.ResetColor();
        }

        public void Play()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The {color} dog {Race} {Name} is now playing");
            Console.ResetColor();
        }

        public void ChaseTail()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The {color} dog {Race} {Name}  is now chasing its tail.");
            Console.ResetColor();
        }



    }
}
