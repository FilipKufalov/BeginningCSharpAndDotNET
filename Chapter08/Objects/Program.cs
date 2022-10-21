using System;

namespace Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chicken chicken = new Chicken("Marko", 2);
            chicken.Age += 1;

            chicken.EatFood();
            chicken.Cluck();

            Animal newChicken = new Chicken("Iva", 2);
            newChicken.EatFood();
        }
    }
}
