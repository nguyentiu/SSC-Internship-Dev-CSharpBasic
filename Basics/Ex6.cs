using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Exercises.Basics
{
    internal class Ex6
    {
        public static void Run()
        {
            Console.Write("Enter a score (or press Enter to leave it blank): ");
            string input = Console.ReadLine();
            int? score = string.IsNullOrEmpty(input) ? (int?)null : Convert.ToInt32(input);

            if (score.HasValue)
            {
                Console.WriteLine("Score: " + score.Value);
            }
            else
            {
                Console.WriteLine("No score entered.");
            }
        }
    }
}
