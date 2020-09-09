using System;

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

            Console.WriteLine("Please write number 1: ");
            string inputNumber = Console.ReadLine();
            bool isInputCorrect = Int32.TryParse(inputNumber, out int number);

            Console.WriteLine(Dividing(number));

        }
        public static int Dividing(int num01)
        {
            var result = 0;
            result = 10 / num01;
            return result;
        }
    }
}
