
/*
 Task: Check if each corresponding place in the two numbers(ones, tens, hundreds, …) sums to the same total.
            Input: Your program should read two integer numbers from the user with the same number of digits(example: number1 = 234, number2 = 564).
            Output: Your program should print out: True or False based on the result.
            
            Examples:
            Number1 = 153 , Number2 = 345  => 1 + 3 ≠ 5 + 4 ≠ 3 + 5 Program prints False.
            Number1 = 543 , Number2 = 456  => 5 + 4 = 4 + 5 = 3 + 6 Program prints True.
            
            Things to look for: 
            - Do proper validation on the user’s input.
            - Write the task in a separate method.
            - Provide adequate comments.- Provide adequate user prompts.*/
using System;

namespace MathChallenge
{
    class MainClass
	{
		private static bool CompareDigits()
		{

			Console.WriteLine("Hello and Welcome to the Math Challenge.\nYou will need to enter two intergers with the same numbers of digits!");
			//Declared variables 
			int userEnteredNum1;
			int userEnteredNum2;

			//Outputs a question to the user and reads in input to initialize variable 1
			Console.WriteLine("Enter the 1st interger: ");
			userEnteredNum1 = Convert.ToInt32(Console.ReadLine());
			string StringOfNum1 = userEnteredNum1.ToString();//Converts the int values into strings so the length of the int can be checked for value 1

			//Outputs a question to the user and reads in input to initialize variable 2
			Console.WriteLine("Enter the 2nd interger: ");
			userEnteredNum2 = Convert.ToInt32(Console.ReadLine());
			string StringOfNum2 = userEnteredNum2.ToString();//Converts the int values into strings so the length of the int can be checked for value 1

			//Checks that both strings have the same number of characters and displays the out come to the user
			if (StringOfNum1.Length != StringOfNum2.Length)
			{
				Console.WriteLine("Sorry those intergers do not have the same number of digits. Please use a int with the same number of digits");
			}
			else
			{
				Console.WriteLine("True\nAwesome! The digits in your numbers({0} and {1}) have the same sum totals. ", userEnteredNum1, userEnteredNum2);
			}


			//TODO Add code base that increments a variable that holds and increments the elements by 1 each time 
            int numDigit1 = 0;
           

			do
            {
                numDigit1 = numDigit1+1;
               
                Console.WriteLine(numDigit1);

				int intArrayElementIndex1 = Convert.ToInt32(StringOfNum1[numDigit1] + Convert.ToInt32(StringOfNum2[numDigit1]));
				
                int intArrayElementIndex2 = Convert.ToInt32(StringOfNum1[numDigit1] + Convert.ToInt32(StringOfNum2[numDigit1]));

                int intArrayElementIndex3 = Convert.ToInt32(StringOfNum1[numDigit1] + Convert.ToInt32(StringOfNum2[numDigit1]));

				Console.WriteLine(intArrayElementIndex1);
				Console.WriteLine(intArrayElementIndex2);

				if ((intArrayElementIndex1 == intArrayElementIndex2) && (intArrayElementIndex2 == intArrayElementIndex3) && (intArrayElementIndex1 == intArrayElementIndex3))
				{
					return true;
				}
				else
				{
					return false;
				}
            }
            while (numDigit1 != Convert.ToInt32(StringOfNum1.Length) );

           
     

            //All above is attempting to create an incremental loop for the element index


            /*
			//New variables are created to store the individual digits of the intergers
			//This is possble by using ConvertTo Int32 on the elements of the strings and since Strings are by definition Character arrays this reverts the digits back to ints.
			int onesPlace = Convert.ToInt32(StringOfNum1[0] + Convert.ToInt32(StringOfNum2[0]));
			int twosPlace = Convert.ToInt32(StringOfNum1[1] + Convert.ToInt32(StringOfNum2[1]));
			int threesPlace = Convert.ToInt32(StringOfNum1[2] + Convert.ToInt32(StringOfNum2[2]));


			if ((onesPlace == twosPlace) && (twosPlace == threesPlace) && (onesPlace == threesPlace))
			{
				return true;
			}
			else
			{
				return false;
			}
            */
		}

        public static void Main(string[] args)
        {
            CompareDigits();//Method call

            //Outputs False if the input doesn't match the requirements met in the opening statement
            if (CompareDigits() == false)
            {
                Console.WriteLine("False!\nThose numbers do not have digits with the same sum totals sorry.");
            }

        }
    }
}
