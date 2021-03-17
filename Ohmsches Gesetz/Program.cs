using System;

namespace Ohmsches_Gesetz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("R1 (in Ohm): ");
            string userInput = Console.ReadLine();
            int r1 = Convert.ToInt32(userInput);
            
            Console.Write("R2 (in Ohm): "); 
            userInput = Console.ReadLine();
            int r2 = Convert.ToInt32(userInput);
            
            Console.WriteLine("Reihenschaltung: " + (r1 + r2) + " Ohm");
            Console.WriteLine("Parallelschaltung: " + ((r1 * r2) / (r1 + r2)) + " Ohm");
        }
    }
}