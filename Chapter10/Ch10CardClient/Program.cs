using Ch10CardLib;
using System;

namespace Ch10CardClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            myDeck.Shuffle();
            for (int i = 0; i < 52; i++)
            {
                Card tempCard = myDeck.GetCard(i);
                Console.WriteLine(tempCard.ToString());
                if ( i != 51)
                    Console.Write("");
                else
                    Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
