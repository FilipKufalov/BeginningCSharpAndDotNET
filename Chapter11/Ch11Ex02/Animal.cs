using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch11Ex02
{
    public class Animal
    {
        protected string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Animal(string newName) => name = newName;
        public void Feed() => Console.WriteLine($"{name} has been fed.");
    }
}