using System;
using System.Collections.Generic;
using System.Linq;

namespace Number_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a list of numbers seprated by commas.");

            string numberList = Console.ReadLine();
 
            string[] numberSplit = numberList.Split(",");

            Console.WriteLine("Would you like to multiply or square?");

            string userOperator = Console.ReadLine();

            if(userOperator == "multiply")
            {
                var control = 1;
                foreach (string number in numberSplit)
                {
                    int numberfied = Int32.Parse(number);
                    int solution = control * numberfied;
                    control = solution;
                }
            Console.WriteLine($"Their product is: {control}");
            }
            else if(userOperator == "square")
            {
                var answer = new List<int>();
                foreach (string number in numberSplit)
                {
                    int numberfied = Int32.Parse(number);
                    int square = numberfied * numberfied;
                    answer.Add(square);
                }
                Console.WriteLine($"This is each number squared: {string.Join(',', answer)}");
            }


            Console.ReadLine();
        }
    }
}
