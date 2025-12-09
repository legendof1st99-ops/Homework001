using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(" Grade calculator score");
                    Console.Write("Enter your score (0-100) or type 'exit' to restart: ");
                    string input = Console.ReadLine();
                    Console.WriteLine();

                    // Allow immediate restart command before parsing
                    if (!string.IsNullOrEmpty(input) && input.Trim().Equals("exit", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Restarting...");
                        Console.WriteLine();
                        Console.Clear();
                        continue;
                    }

                    //A -> 100-80
                    //B + -> 79 - 75
                    //B-> 74 - 70
                    //C + -> 69 - 65
                    //C-> 64 - 60
                    //D + -> 59 - 55
                    //D-> 54 - 50
                    //F-> 49 - 0

                    if (int.TryParse(input, out int score) && score >= 0 && score <= 100)
                    {
                        string result;

                        if (score >= 80) result = "Your grade is A.";
                        else if (score >= 75) result = "Your grade is B+.";
                        else if (score >= 70) result = "Your grade is B.";
                        else if (score >= 65) result = "Your grade is C+.";
                        else if (score >= 60) result = "Your grade is C.";
                        else if (score >= 55) result = "Your grade is D+.";
                        else if (score >= 50) result = "Your grade is D.";
                        else result = "Your grade is F.";

                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
                    }

                    // After processing input, allow user to restart the program by typing 'exit'
                    Console.WriteLine();
                    Console.Write("Type 'exit' to restart or press Enter to quit: ");
                    string command = Console.ReadLine();

                    if (!string.IsNullOrEmpty(command) && command.Trim().Equals("exit", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Restarting...");
                        Console.WriteLine();
                        Console.Clear();
                        continue;
                    }

                    // Any other input (including empty) quits the program
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("You input wrong number.");
                    return;
                }
            }
        }
    }
}