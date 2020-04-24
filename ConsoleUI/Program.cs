using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string ageText = Console.ReadLine();

            bool isValidAge = int.TryParse(ageText, out int currentAge);
            if (isValidAge)
            {
                int kAge = currentAge - 20;
                if (kAge < 21)
                {
                    Console.WriteLine("You weren't alive in 2000");
                }
                else
                {
                    Console.WriteLine($"You were { kAge } in the year 2000");
                }
            }
            Console.ReadLine();
        }
    }
}
