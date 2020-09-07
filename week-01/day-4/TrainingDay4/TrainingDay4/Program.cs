using System;
using System.Data;

namespace TrainingDay4
{
    class Program
    {
        static void Main(string[] args)
        {
            // INTRODUCE YOURSELF
            // Write a program that prints a few details to the terminal window about you
            // It should print each detail to a new line.
            //  - Your name
            //  - Your age
            //  - Your height in meters (as a decimal fraction)
            //
            //  Example output:
            //  John Doe
            //  31
            //  1.87

            /*   string name = "Standa";
               int age = 43;
               double height = 1.77;

               Console.WriteLine("My name is " + name);
               Console.WriteLine("My age is " + age);
               Console.WriteLine("I'm " + height + "m tall");
            */

            // TWO NUMBERS
            // Create a program that prints a few operations on two numbers: 22 and 13

            // Print the result of 13 added to 22

            // Print the result of 13 substracted from 22

            // Print the result of 22 multiplied by 13

            // Print the result of 22 divided by 13 (as a decimal fraction)

            // Print the integer part of 22 divided by 13

            // Print the remainder of 22 divided by 13

            /* int num1 = 22;
int num2 = 13;
Console.WriteLine(num1 + num2); // counts as int
Console.WriteLine(num1 - num2);
Console.WriteLine(num1 * num2);
Console.WriteLine(num1 / num2);
Console.WriteLine((float)num1 / num2); //hardly selected type of var
Console.WriteLine(num1 % num2);
Console.WriteLine(2 + 2); // counts as int
Console.WriteLine(7 - 2);
Console.WriteLine(3 * 2);
Console.WriteLine(7 / 2);
Console.WriteLine(7 % 2);
Console.WriteLine(7 / 2.0); //counts as float thanks to a 2.0 > is hardly selected type of var
            */
            // CODING HOURS
            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long
            //
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            //
            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52
            /*
                        int dailyHours = 6;
                        int semesterWeeks = 17;
                        int weekWorkingDays = 5;
                        int averageCodingHours = 52;

                        Console.WriteLine("An average Green Fox attendee spents with coding in a semester " + dailyHours * semesterWeeks * weekWorkingDays + " hours.");
                        Console.WriteLine("This is " + (float)dailyHours * weekWorkingDays / averageCodingHours * 100 + " percent of the average semester hours.");
            */

            // FAVORITE NUMBER
            // Store your favorite number in a variable (as a number)
            // And print it like this: "My favorite number is: 8"

            /* int favoriteNumber = 13;
             Console.WriteLine("My favorite number is: " + favoriteNumber);*/

            // Swap the values of the variables
            /*  int a = 123;
              int b = 526;
              int c = 0;


              Console.WriteLine("Test: a = " + a + " and b = " + b);

              c = a;
              a = b;
              b = c;

              Console.WriteLine("Result of swapping: a = " + a + " and b = " + b);*/

            // BODY MASS INDEX
            // Print the Body mass index (BMI) based on these values
            /*double massInKg = 81.2;
            double heightInM = 1.78;

            Console.WriteLine("BMI is " + Math.Round(massInKg / (heightInM * heightInM)));*/

            // DEFINE BASIC INFO
            // Define several things as a variable then print their values
            // Your name as a string
            // Your age as an integer
            // Your height in meters as a double
            // Whether you are married or not as a boolean

            /*string name = "Standa";
            int age = 43;
            double height = 1.77;
            bool married = true;

            Console.WriteLine("My name is " + name);
            Console.WriteLine("My age is " + age);
            Console.WriteLine("I'm " + height + "m tall");
            Console.WriteLine("Am I married? Answer is: " + married);*/

            // VARIABLE MUTATION
            /* int a = 3;
             // make it bigger by 10

             Console.WriteLine(a + 10);

             int b = 100;
             // make it smaller by 7

             Console.WriteLine(b - 7);

             int c = 44;
             // please double c's value

             Console.WriteLine(c * 2);

             int d = 125;
             // please divide by 5 d's value

             Console.WriteLine(d / 5);

             int e = 8;
             // please cube of e's value

             Console.WriteLine(e * e * e);

             int f1 = 123;
             int f2 = 345;
             // tell if f1 is bigger than f2 (print as a boolean)

             if (f1 > f2)
             {
                 Console.WriteLine(f1 + " is bigger than " + f2 + " : " + true);
             } else
             {
                 Console.WriteLine(f1 + " is bigger than " + f2 + " : " + false);
             }


             int g1 = 350;
             int g2 = 200;
             // tell if the double of g2 is bigger than g1 (print as a boolean)

             if ((g2 * 2) > g1)
             {
                 Console.WriteLine("Double " + g2 + " is bigger than " + g1 + " : " + true);
             }
             else
             {
                 Console.WriteLine("Double " + g2 + " is bigger than " + g1 + " : " + false);
             }

             double h = 1357988018575474;
             // tell if 11 is a divisor of h (print as a boolean)

             if (h % 11 == 0)
             {
                 Console.WriteLine("11 is divisor of " + h + " : " + true);
             }
             else
             {
                 Console.WriteLine("11 is divisor of " + h + " : " + false);
             }
            
             int i1 = 8;
             int i2 = 3;
             // tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)
            
             if (i1 > Math.Pow(i2, 2) && i1 < Math.Pow(i2, 3))
             {
                 Console.WriteLine($"{i1} is bigger than {i2} squared ({i2 * i2}) and smaller than {i2} cubed ({i2 * i2 * i2}): {true}");
             }
             else
             {
                 Console.WriteLine($"{i1} is bigger than {i2} squared ({i2 * i2}) and smaller than {i2} cubed ({i2 * i2 * i2}): {false}");
             }
             
             int j = 1521;
             // tell if j is divisible by 3 or 5 (print as a boolean)

             if (j % 3 == 0)
             {
                 Console.WriteLine("3 is divider of " + j + " " + true);
             } else if (j % 5 == 0)
             { Console.WriteLine("5 is divider of " + j + " " + true);
             }*/

            // CUBOID
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            /*int side1 = 0;
            int side2 = 0;
            int side3 = 0;

            Console.WriteLine("Please enter size of first side of Cuboid:");
            string input1 = Console.ReadLine();
            bool isInputCorrect1 = Int32.TryParse(input1, out int result1);
            if (isInputCorrect1)
            {
                Console.WriteLine("Success!");
                side1 = result1;
            } // else
            // {
            //     Console.WriteLine("Please insert only numers without floating point.");
            // }


            Console.WriteLine("Please enter size of second side of Cuboid:");
            string input2 = Console.ReadLine();
            bool isInputCorrect2 = Int32.TryParse(input1, out int result2);
            if (isInputCorrect2)
            {
                Console.WriteLine("Success!");
                side2 = result2;

            }
            Console.WriteLine("Please enter size of third side of Cuboid:");
            string input3 = Console.ReadLine();
            bool isInputCorrect3 = Int32.TryParse(input1, out int result3);
            if (isInputCorrect3)
            {
                Console.WriteLine("Success!");
                side3 = result3;
            }

            Console.WriteLine("Surface Area: " + (2 * (side1 * side2 + side2 * side3 + side1 * side3)));
            Console.WriteLine("Volume: " + (side1 * side2 * side3));*/

            // SECONDS IN A DAY
            /*int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables

            int remainingSecondsInADay = (60 * 60 * 24) - (currentHours * 3600 + currentMinutes * 60 + currentSeconds);
            Console.WriteLine("Remaining seconds from a day are " + remainingSecondsInADay + " if the current time is " + currentHours + ":" + currentMinutes + ":" + currentSeconds);*/

            // HELLO USER
            // Modify this program to greet user instead of the World!
            // The program should ask for the name of the user
            // Console.WriteLine("Hello, World!");

            /*Console.WriteLine("Hello user what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name + "!");*/

            // MILE TO KM CONVERTER
            // Write a program that asks for a double that is a distance in miles,
            // then it converts that value to kilometers and prints it

            /*double distance = 0;
            
            Console.WriteLine("Insert distance in km:");
            string input = Console.ReadLine();
            bool isInputCorrect = Double.TryParse(input, out double result);
            if (isInputCorrect)
            {
              //  Console.WriteLine("Success!");
                distance = result;
            }
            Console.WriteLine("Distance in km: " + distance + " is equal to " + (distance / 1.6) + " in miles.");*/

            // ANIMALS AND LEGS
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have

            /*int chickenLegs = 0;
            int pigLegs = 0;

            Console.WriteLine("Insert number of chickens the farmer have:");
            string input = Console.ReadLine();
            bool isInputCorrect = Int32.TryParse(input, out int result);
            if (isInputCorrect)
            {
                //  Console.WriteLine("Success!");
                chickenLegs = result * 2;
            }
            Console.WriteLine("Insert number of pigs the farmer have:");
            string input2 = Console.ReadLine();
            bool isInputCorrect2 = Int32.TryParse(input2, out int result2);
            if (isInputCorrect2)
            {
                //  Console.WriteLine("Success!");
                pigLegs = result2 * 4;
            }
            Console.WriteLine("There is " + (chickenLegs + pigLegs) + " legs of animals on the farm.");*/

            // AVERAGE OF INPUT
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4

            /*int numberOne = 0;
            int numberTwo = 0;
            int numberThree = 0;
            int numberFour = 0;
            int numberFive = 0;

            Console.WriteLine("Insert first number of five:");
            string input1 = Console.ReadLine();
            bool isInputCorrect1 = Int32.TryParse(input1, out int result1);
            if (isInputCorrect1)
            {
                //  Console.WriteLine("Success!");
                numberOne = result1;
            }
            Console.WriteLine("Insert second number of five:");
            string input2 = Console.ReadLine();
            bool isInputCorrect2 = Int32.TryParse(input2, out int result2);
            if (isInputCorrect2)
            {
                //  Console.WriteLine("Success!");
                numberTwo = result2;
            }
            Console.WriteLine("Insert third number of five:");
            string input3 = Console.ReadLine();
            bool isInputCorrect3 = Int32.TryParse(input3, out int result3);
            if (isInputCorrect3)
            {
                //  Console.WriteLine("Success!");
                numberThree = result3;
            }
            Console.WriteLine("Insert fourth number of five:");
            string input4 = Console.ReadLine();
            bool isInputCorrect4 = Int32.TryParse(input4, out int result4);
            if (isInputCorrect4)
            {
                //  Console.WriteLine("Success!");
                numberFour = result4;
            }
            Console.WriteLine("Insert fifth number of five:");
            string input5 = Console.ReadLine();
            bool isInputCorrect5 = Int32.TryParse(input5, out int result5);
            if (isInputCorrect5)
            {
                //  Console.WriteLine("Success!");
                numberFive = result5;
            }

            int sum = numberOne + numberTwo + numberThree + numberFour + numberFive;
            float average = sum / 5;

            Console.WriteLine("Sum: " + sum + ", Average: " + average);*/

            // ODD EVEN
            // Write a program that reads a number from the standard input,
            // Then prints "Odd" if the number is odd, or "Even" if it is even.


            /*Console.WriteLine("Insert a number:");
            string input = Console.ReadLine();
            bool isInputCorrect = Int32.TryParse(input, out int result);
            if (isInputCorrect)
            {
                if (result % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
            }*/

            // ONE TWO A LOT
            // Write a program that reads a number form the standard input,
            // If the number is zero or smaller it should print: Not enough
            // If the number is one it should print: One
            // If the number is two it should print: Two
            // If the number is more than two it should print: A lot

            /*Console.WriteLine("Insert a number:");
            string input = Console.ReadLine();
            bool isInputCorrect = Int32.TryParse(input, out int number);
            if (isInputCorrect)
            {
                if (number <= 0)
                {
                    Console.WriteLine("Not enough");
                }
                else if (number == 1)
                {
                    Console.WriteLine("One");
                }
                else if (number == 2)
                {
                    Console.WriteLine("Two");
                }
                else if (number > 2)
                {
                    Console.WriteLine("A lot");
                }

            }*/


        }
    }
}
