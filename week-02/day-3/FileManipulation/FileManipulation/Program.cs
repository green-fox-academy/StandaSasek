using System;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace FileManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // DIVIDE BY ZERO
            // Create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // It should print "fail" if the parameter is 0

            /*Console.WriteLine("Please write a number: ");
            string inputNumber = Console.ReadLine();
            bool isInputCorrect = Int32.TryParse(inputNumber, out int number);

            Console.WriteLine(Dividing(number));
            Console.ReadLine();*/

            // PRINT EACH LINE
            // Write a program that opens a file called "my-file.txt", then prints
            // each line from the file.
            // If the program is unable to read the file (for example it does not exist),
            // then it should print the following error message: "Unable to read file: my-file.txt"

            /*string[] fileContent = new string[3] { "first", "second", "third" };
            File.WriteAllLines("my-file.txt", fileContent);

            MyReadWrite("my-file.txt");*/

            // COUNT LINES
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.

            Console.WriteLine("Please write name of file: ");
            string fileName = Console.ReadLine();




        }
        


        public static void MyReadWrite(string pathFile)
        {
            if (File.Exists(pathFile))
            {
                string[] line = File.ReadAllLines(pathFile);
                foreach (var ln in line)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("Unable to read file: my-file.txt");
            }
        }

        public static int Dividing(int num01)
        {
            var result = 0;
            result = 10 / num01;
            return result;
        }
    }
}


