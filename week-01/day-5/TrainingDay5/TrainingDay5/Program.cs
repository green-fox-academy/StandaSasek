using System;
using System.Collections.Generic;
using System.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace TrainingDay5
{
    class Program
    {
        static void Main(string[] args)
        {
            // PRINT BIGGER
            // Write a program that asks for two numbers and prints the bigger one

            /*  Console.WriteLine("Insert a number:");
              string input = Console.ReadLine();
              bool isInputCorrect = Int32.TryParse(input, out int number);
              if (isInputCorrect)
              {
                  Console.WriteLine("Thank you. Now insert the second number:");
                  string input1 = Console.ReadLine();
                  bool isInputCorrect1 = Int32.TryParse(input1, out int number1);
                  if (isInputCorrect1)
                  {
                      if (number1 > number)
                      {
                          Console.WriteLine(number1 + " - a second number is bigger");
                      } else if (number > number1)
                      {
                          Console.WriteLine(number + " - a first number is bigger");
                      } else if (number == number1)
                      Console.WriteLine("Numbers are equal");
                  }
              }*/

            // PARTY INDICATOR
            // Write a program that asks for two numbers
            // The first number represents the number of girls that comes to a party, the
            // second the boys
            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20
            //
            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            //
            // It should print: Average party...
            // If there are less people coming than 20
            //
            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people

            /*Console.WriteLine("Insert the number of girls on a party:");
            string inputG = Console.ReadLine();
            bool isInputCorrectG = Int32.TryParse(inputG, out int numberG);
            if (isInputCorrectG)
            {
                Console.WriteLine("Thank you. Now insert the number of boys on a party:");
                string inputB = Console.ReadLine();
                bool isInputCorrectB = Int32.TryParse(inputB, out int numberB);
                if (isInputCorrectB)
                {
                    if (numberG == numberB && numberB + numberG >= 20)
                    {
                        Console.WriteLine("The party is exellent!");
                    }
                    else if (numberG != numberB && numberB + numberG >= 20)
                    {
                        Console.WriteLine("Quite cool party!");
                    }
                    else if (numberB + numberG < 20 && numberG > 0)
                    {
                        Console.WriteLine("Average party...");
                    }
                    else if (numberG < 1)
                    {
                        Console.WriteLine("Sausage party");
                    }
                }
            }*/

            // CONDITIONAL VARIABLE MUTATION
            /*double a = 24;
            int out1 = 0;

            // if a is even increment out by one

            if (a % 2 == 0)
            {
                out1++;
                Console.WriteLine(out1);
            }

            int b = 13;
            string out2 = "";
            // if b is between 10 and 20 set out2 to "Sweet!"
            // if less than 10 set out2 to "Less!",
            // if more than 20 set out2 to "More!"

            if (b > 10 & b < 20) // instructions do not cover b = 10 & b = 20
            {
                out2 = "Sweet!";
                Console.WriteLine(out2);

            }
            else if (b < 10)
            {
                out2 = "Less!";
                Console.WriteLine(out2);
            }
            else if (b > 20)
            {
                out2 = "More!";
                Console.WriteLine(out2);
            }

            int c = 123;
            int credits = 100;
            bool isBonus = false;
            // if credits are at least 50,
            // and isBonus is false decrement c by 2
            // if credits are smaller than 50,
            // and isBonus is false decrement c by 1
            // if isBonus is true c should remain the same

            if (credits >= 50 & isBonus == false)
            {
                c -= 2;
                Console.WriteLine(c);
            }
            else if (credits < 50 & isBonus == false)
            {
                c--;
                Console.WriteLine(c);
            }
            else if (isBonus == true)
            {
                Console.WriteLine(c);
            }


            int d = 81;
            int time = 120;
            string out3 = "";

            // if d is dividable by 4
            // and time is not more than 200
            // set out3 to "check"
            // if time is more than 200
            // set out3 to "Time out"
            // otherwise set out3 to "Run Forest Run!"

            if (d % 4 == 0 & time < 200)
            {
                out3 = "check";
                Console.WriteLine(out3);
            }
            else if (time > 200) // instructions do not cover: d is dividable by 4 & time = 200. 
            {
                out3 = "Time out";
                Console.WriteLine(out3);
            }
            else
            {
                out3 = "Run Forest Run!";
                Console.WriteLine(out3);
            }*/

            // CALCULATOR
            // Create a very simplistic calculator: ask for two numbers and an operation (add, subtract, multiply or divide)
            // Based on the operation provided print the result of the calculation.

            /* Console.WriteLine("Welcome to the Calculator!");
             Console.WriteLine("Please provide the first number:");

             string input1 = Console.ReadLine();  // Get the first number:
             bool isInputCorrect1 = double.TryParse(input1, out double number1); // double number1 = ...

             Console.WriteLine("Please provide the second number:");

             string input2 = Console.ReadLine();  // Get the second number:
             bool isInputCorrect2 = double.TryParse(input2, out double number2); // double number2 = ...

             Console.WriteLine("Please provide the operation (add, subtract, multiply or divide):");

             string input = Console.ReadLine();  // Get the operation from standard input:


             // string operation = ...

             // use the `switch` statement and the corresponding calculation
             // store the result of the calculation in the `result` variable
             double result = 0.0;
             switch
              (input)
             {
                 case "add":
                     result = number1 + number2;
                     break;
                 case "subtract":
                     result = number1 - number2;
                     break;
                 case "multiply":
                     result = number1 * number2;
                     break;
                 case "divide":
                     result = number1 / number2;
                     break;
                 default:
                     Console.Error.WriteLine("Invalid operation. Please try again.");
                     return;
             }

             Console.WriteLine($"The result of the calculation is {result}");*/

            // I WONT CHEAT ON THE EXAM
            // Create a program that writes this line 100 times:
            // "I won't cheat on the exam!"

            /* for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"{i + 1}. I won't cheat on the exam!"); //rewritten to for loop
            }
*/
            // PRINT EVEN
            // Create a program that prints all the even numbers between 0 and 500

            /*for (int i = 0; i < 501; i++) // rewritten to for loop
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }*/

            // MULTIPLICATION TABLE
            // Create a program that asks for a number and prints the multiplication table with that number
            //
            // Example:
            // The number 15 should print:
            //
            // 1 * 15 = 15
            // 2 * 15 = 30
            // 3 * 15 = 45
            // 4 * 15 = 60
            // 5 * 15 = 75
            // 6 * 15 = 90
            // 7 * 15 = 105
            // 8 * 15 = 120
            // 9 * 15 = 135
            // 10 * 15 = 150

            /* Console.WriteLine("Welcome to the Multiplication Table!");
             Console.WriteLine("Please provide a number:");

             string input = Console.ReadLine();  // Get a number:
             bool isInputCorrect = double.TryParse(input, out double number); // double number = ...

             for (int i = 1; i < 11; i++) // rewritten with for loop and switch statement
             {
                 double result = number * i;
                 switch (i)
                 {
                     case 10:
                         Console.WriteLine($"{i} * {number} = {result}");
                         break;
                     default:
                         Console.WriteLine($" {i} * {number} = {result}");
                         break;
                 }
             }
 */
            // COUNT FROM TO
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5

            /*Console.WriteLine("Please provide the first number:");
            string input1 = Console.ReadLine();  // Get a number:
            bool isInputCorrect1 = Int32.TryParse(input1, out int number1); // int number1 = ...

            Console.WriteLine("Please provide the second number:");
            string input2 = Console.ReadLine();  // Get a number:
            bool isInputCorrect2 = Int32.TryParse(input2, out int number2); // int number2 = ...

            if (number1 < number2)
            {
                while (number1 < number2)
                {
                    Console.WriteLine(number1);
                    number1++;
                }
            }
            else
            {
                Console.WriteLine("The second number should be bigger");
            }*/

            // FIZZ BUZZ
            // Write a program that prints the numbers from 1 to 100.
            // But for multiples of three print “Fizz” instead of the number
            // and for the multiples of five print “Buzz”.
            // For numbers which are multiples of both three and five print “FizzBuzz”.

            //  VERSION WITH SIMPLE IF ELSE CHECK AND WORDS

            /* for (int num = 1; num < 101; num++) // rewritten with for loop 
             {
                 if (num % 3 == 0 && num % 5 == 0) // check for both dividers first, so it will show FizzBuzz - if it's the last checked, it will never goes there!!!!  
                 {
                     Console.WriteLine("FizzBuzz");
                 }
                 else if (num % 3 == 0)
                 {
                     Console.WriteLine("Fizz");
                 }
                 else if (num % 5 == 0)
                 {
                     Console.WriteLine("Buzz");
                 }
                 else
                 {
                     Console.WriteLine(num);
                 }
             }*/

            // DRAW TRIANGLE
            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was

            /* Console.WriteLine("Please enter number of rows of your triangle: ");
             string input = Console.ReadLine();  // Get a number:
             bool isInputCorrect = Int32.TryParse(input, out int number); // int number = ...

             for (int row = 1; row <= number; row++)
             {
                 for (int col = 0; col < row; col++)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine();
             }*/

            // DRAW PYRAMID
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was

            /*Console.WriteLine("Please enter number of rows of your pyramid: ");
            string input = Console.ReadLine();  // Get a number:
            bool isInputCorrect = Int32.TryParse(input, out int number); // int number = ...

            for (int row = 1; row < number + 1; row++)
            {
                int space = 0; 
                for (int col = 0; col < (row * 2) - 1; col++)
                {                    
                    while (space < number - row)
                    {
                        Console.Write(" ");
                        space++;
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/

            // SECOND VERSION OF PYRAMID WITH LINES SEQUENCE CONCATENATED TO ONE STRING

            /* Console.WriteLine("Please enter number of rows of your pyramid: ");
             string input = Console.ReadLine();  // Get a number:
             bool isInputCorrect = Int32.TryParse(input, out int number); // int number = ...

             int columns = number - (number % 2);
             string diamond = "";

             for (int row = 1; row < number + 1; row++)
             {
                 int space = 0;
                 for (int col = 0; col < (row * 2) - 1; col++)
                 {
                     while (space < number - row)
                     {
                         diamond = diamond + " ";
                         space++;
                     }
                     diamond = diamond + "*";
                 }
                 diamond = diamond + "\n";

             }
             Console.Write(diamond);*/

            // DRAW DIAMOND
            // Write a program that reads a number from the standard input, then draws a
            // diamond like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //  *****
            //   ***
            //    *
            //
            // The diamond should have as many lines as the number was

            /* Console.WriteLine("Please enter number of rows of your diamond: ");
             string input = Console.ReadLine();  // Get a number:
             bool isInputCorrect = Int32.TryParse(input, out int number); // int number = ...
             string diamond = "";
             for (int row = 1; row - 1 < number / 2 + number % 2; row++)
             {
                 int space = 0;
                 for (int col = 0; col < (row * 2) - 1; col++)
                 {
                     while (space < number - row)
                     {
                         diamond = diamond + " ";
                         space++;
                     }
                     diamond = diamond + "*";
                 }
                 diamond = diamond + "\n";
             }
             for (int row = number / 2; row > 0; row--)
             {
                 int space = 0;
                 for (int col = 0; col < (row * 2) - 1; col++)
                 {
                     while (space < number - row)
                     {
                         diamond = diamond + " ";
                         space++;
                     }
                     diamond = diamond + "*";
                 }
                 diamond = diamond + "\n";
             }
             Console.Write(diamond);*/

            // DRAW SQUARE
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%%
            // %    %
            // %    %
            // %    %
            // %    %
            // %%%%%%
            //
            // The square should have as many lines as the number was

            /*Console.WriteLine("Please enter number of rows of your square: ");
            string input = Console.ReadLine();  // Get a number:
            bool isInputCorrect = Int32.TryParse(input, out int rows); // int rows = ...
            string square = "";

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < rows; col++)
                {
                    if (row == 0 || col == 0 || col == rows - 1 || row == rows - 1)
                    {
                        square = square + "*";
                    }
                    else
                    {
                        square = square + " ";

                    }
                }
                square = square + "\n";
            }
            Console.WriteLine(square);*/

            // DRAW DIAGONAL
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %%  %
            // % % %
            // %  %%
            // %%%%%
            //
            // The square should have as many lines as the number was

            /*Console.WriteLine("Please enter number of rows of your square: ");
            string input = Console.ReadLine();  // Get a number:
            bool isInputCorrect = Int32.TryParse(input, out int rows); // int rows = ...
            string square = "";

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < rows; col++)
                {
                    if (row == 0 || col == 0 || col == rows - 1 || row == rows - 1 || row == col)
                    {
                        square = square + "*";
                    }
                    else
                    {
                        square = square + " ";

                    }
                }
                square = square + "\n";
            }
            Console.WriteLine(square);*/

            // GUESS THE NUMBER
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8

            /* Random rnd = new Random();
             int myNumber = rnd.Next(0, 101);  // creates a number between MIN int value and 100 
             int userNumber = 0;
             string guess = "Please guess my number: ";
             string higher = "The stored number is higher";
             string lower = "The stored number is lower";
             string bingo = "You found the number:";

             while (userNumber != myNumber)
             {
                 Console.WriteLine(guess);
                 string input = Console.ReadLine();  // Get a number:
                 bool isInputCorrect = Int32.TryParse(input, out userNumber); // int user number = ...
                 if (userNumber < myNumber)
                 {
                     Console.WriteLine(higher);
                 }
                 else if (userNumber > myNumber)
                 {
                     Console.WriteLine(lower);
                 }
             }
             Console.WriteLine($"{bingo} {myNumber}");*/

            // PARAMETRIC AVERAGE

            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4

            /*Console.WriteLine("From how many numbers will we calculate the average?");
            string input = Console.ReadLine();
            bool isInputCorrect = Int32.TryParse(input, out int numberForCount);
            List<int> list = new List<int> { };
            decimal average = 0;
            double sum = 0;

            for (int i = 0; i < numberForCount; i++)
            {
                Console.WriteLine("Please enter an integer:");
                string input1 = Console.ReadLine();
                bool isInputCorrect1 = Int32.TryParse(input1, out int numberToList);
                list.Add(numberToList);
            }
            
            foreach (var number in list)
            {
                sum += number;
            }

            average = (decimal)(sum / list.Count);
            Console.WriteLine("Sum: {0}, Average: {1}", sum, Decimal.Round(average, 2));*/

            // DRAW CHESS TABLE
            // Create a program that draws a chess table like this
            //
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %

            /*for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i % 2 == 0)
                    {
                    Console.Write("% ");
                    }                 
                    else
                    {
                        Console.Write(" %");
                    }
                }
                Console.WriteLine();
            }*/

            // FIND THE SUBSTRING
            //  Create a function that takes two strings as a parameter
            //  Returns the starting index where the second one is starting in the first one
            //  Returns `-1` if the second string is not in the first one

            //  Example:

            /*//  should print: `17`
            Console.WriteLine(Substr("this is what I'm searching in", "searching"));

            //  should print: `-1`
            Console.WriteLine(Substr("this is what I'm searching in", "not"));
*/


        }

        static int Substr(string input, string q)
        {
            int index = input.IndexOf(q);
            return index;
        }
    }
}
