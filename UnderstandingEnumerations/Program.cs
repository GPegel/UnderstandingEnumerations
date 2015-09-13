using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingEnumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            // Console.WriteLine ("Hello World!");

            Console.WriteLine("Type a superhero's name to see his nickname:");
            string userValue = Console.ReadLine();

            Superhero myValue;

            if (Enum.TryParse<Superhero>(userValue, true, out myValue))
            {

                switch (myValue)
                {
                    case Superhero.Batman:
                        Console.WriteLine("Caped Cruisader");
                        break;
                    case Superhero.Spiderman:
                        Console.WriteLine("Sticky guy");
                        break;
                    case Superhero.Superman:
                        Console.WriteLine("Man of steel");
                        break;
                    default:
                        break;
                }
            }

            Console.ReadLine();
        }
    }

    enum Superhero
    {
        Batman,
        Spiderman,
        Superman
    }
}
