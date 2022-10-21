using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Animal : iAnimal
    {
        public Animal()
        {
            Name = default;
            Age = default;
        }

        public Animal(string name, int age)
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
    }
}
