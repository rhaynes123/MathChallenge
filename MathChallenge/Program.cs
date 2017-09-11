using System;
using System.Linq;

namespace MathChallenge
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Input: Your program should read two integer numbers from the user with the same number of digits(example: number1 = 234, number2 = 564).
            //Task: Check if each corresponding place in the two numbers(ones, tens, hundreds, …) sums to the same total.
            //Output: Your program should print out: True or False based on the result.
            //Examples:Number1 = 153 , Number2 = 345  => 1 + 3 ≠ 5 + 4 ≠ 3 + 5 Program prints False.Number1 = 543 , Number2 = 456  => 5 + 4 = 4 + 5 = 3 + 6 Program prints True.
            //Things to look for: -Do proper validation on the user’s input.- Write the task in a separate method.- Provide adequate comments.- Provide adequate user prompts.

            int userEnteredNum1;
            int userEnteredNum2;

            //TODO try to instead have the values entered directly into an array of ints
            Console.WriteLine("Enter the 1st interger: ");
            userEnteredNum1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the 2nd interger: ");
            userEnteredNum2 = Convert.ToInt32(Console.ReadLine());


            string lengthOfNum1 = userEnteredNum1.ToString();
			string lengthOfNum2 = userEnteredNum2.ToString();

            if(lengthOfNum1.Length != lengthOfNum2.Length)
            {
                Console.WriteLine("Sorry those intergers do not have the same number of digits. Please use a int with the same number of digits");
            }
            else 
            {
                Console.WriteLine("Thank you. Your nubers are {0} and {1}", userEnteredNum1, userEnteredNum2);
            }


        }
    }
}
