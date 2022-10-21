using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Chicken : Animal
    {
        public Chicken(string name, int age)
        {
            Name = name ?? "";
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public void EatFood()
        {
            Console.WriteLine($"{Name} is eating food!");
        }
        public void Breed()
        {
            Console.WriteLine($"{Name} is breeding!");
        }
        public void Cluck()
        {
            Console.WriteLine($"{Name} is Clucking!");
        }
        public void LayEgg()
        {
            Console.WriteLine($"{Name} is laying eggs!");
        }
    }
}
