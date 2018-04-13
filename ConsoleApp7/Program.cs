using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            compareTwoNumbers();

        }




        public static void compareTwoNumbers()
        {
            bool isEqual = false;

            // Asks user for two numbers

            Console.WriteLine("Please enter a number:");
            string input1 = Console.ReadLine();

            Console.WriteLine("Please enter another number with the same number of digits");
            string input2 = Console.ReadLine();

            // Check if the amount of digits are the same for the two numbers
            if (input1.Length != input2.Length)
            {
                Console.WriteLine("Sorry the 2 numbers did not have the same amount of digits");
                return;
            }

            // Check if user input are numbers
            int input1AsInt;
            int input2AsInt;
            if (!(int.TryParse(input1, out input1AsInt)) || !(int.TryParse(input2, out input2AsInt)))
            {
                Console.WriteLine("Sorry you did not enter numbers");
                return;
            }






            // loop through each digit in the numbers
            int[] numbersFromInput1 = new int[input1.Length];
            for (int i = 0; i < input1.Length; i++)
            {
                numbersFromInput1[i] = Int32.Parse(input1[i].ToString());
            }

            int[] numbersFromInput2 = new int[input2.Length];
            for (int i = 0; i < input2.Length; i++)
            {
                numbersFromInput2[i] = Int32.Parse(input2[i].ToString());
            }

            // check if the sum of digit positions are equal.
            for (int i = 0; i < input1.Length - 1; i++)
            {
                int firstSum = numbersFromInput1[i] + numbersFromInput2[i];
                int secondSum = numbersFromInput1[i + 1] + numbersFromInput2[i + 1];
                if (firstSum == secondSum)
                {
                    isEqual = true;
                }
                else
                {
                    isEqual = false;
                    break;
                }

            }

            // Prints True if digits are equal and false if they aren't
            if (isEqual == true)
            {
                Console.WriteLine("True");

            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
