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

            // Console.WriteLine(NumbOfLines("TextFile1.txt"));

            //WRITE A SINGLE LINE
            // Write a function that is able to manipulate a file
            // By writing your name into it as a single line
            // The file should be named "my-file.txt"
            // In case the program is unable to write the file,
            // It should print the following error message: "Unable to write file: my-file.txt"

            /*var name = "Standa Sasek";
            WriteMyLine("my-file.txt", name);*/

            // WRITE MULTIPLE LINES
            // Create a function that takes 3 parameters: a path, a word and a number
            // and is able to write into a file.
            // The path parameter should be a string that describes the location of the file you wish to modify
            // The word parameter should also be a string that will be written to the file as individual lines
            // The number parameter should describe how many lines the file should have.
            // If the word is 'apple' and the number is 5, it should write 5 lines
            // into the file and each line should read 'apple'
            // The function should not raise any errors if it could not write the file.

            /*var name = "Standa Sasek";
            WriteMyLines("my-file.txt", name, 6);*/

            // COPY FILE
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful

            // CopyMyFile("my-file.txt", "my-new-file.txt");

            // DOUBLED
            // Create a method that decrypts the duplicated-chars.txt 

            // RemoveDoubled("duplicated-chars.txt");

            // REVERSED LINES
            // Create a method that decrypts reversed-lines.txt

            // Reverse("reversed-lines.txt");

            // REVERSED ORDER
            // Create a method that decrypts reversed-order.txt

            // ReverseLines("reversed-order.txt");

        }
        public static void ReverseLines(string pathFile)
        {
            if (File.Exists(pathFile))
            {
                var copied = File.ReadAllLines(pathFile);
                var copiedToList = new List<string>(copied);
                var temp = new List<string>();
                for (int i = 0; i < copiedToList.Count; i++)
                {
                    temp.Add(copiedToList[copiedToList.Count - 1 - i]);
                }
                copiedToList = temp;
                copied = copiedToList.ToArray();
                File.WriteAllLines(pathFile, copied);
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
                Console.WriteLine($"Unable to read file: {pathFile}");
            }
        }
        public static void Reverse(string pathFile)
        {
            if (File.Exists(pathFile))
            {
                var copied = File.ReadAllLines(pathFile);
                for (int line = 0; line < copied.Length; line++)
                {
                    var temp = "";
                    for (int i = copied[line].Length - 1; i >= 0; i--)
                    {
                        temp = temp + copied[line].Substring(i, 1);
                    }
                    copied[line] = temp;
                }
                File.WriteAllLines(pathFile, copied);
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
                Console.WriteLine($"Unable to read file: {pathFile}");
            }
        }
        public static void RemoveDoubled(string pathFile)
        {
            if (File.Exists(pathFile))
            {
                var copied = File.ReadAllLines(pathFile);
                for (int line = 0; line < copied.Length; line++)
                {
                    var temp = "";
                    for (int i = 0; i < copied[line].Length; i += 2)
                    {
                        temp = temp + copied[line].Substring(i, 1);
                    }
                    copied[line] = temp;
                }
                File.WriteAllLines(pathFile, copied);
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
                Console.WriteLine($"Unable to read file: {pathFile}");
            }
        }
        public static void CopyMyFile(string pathOldFile, string pathNewFile)
        {
            if (File.Exists(pathOldFile))
            {
                var copied = File.ReadAllLines(pathOldFile);
                File.WriteAllLines(pathNewFile, copied);
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
                Console.WriteLine($"Unable to read file: {pathOldFile}");
            }
        }
        public static void WriteMyLines(string pathFile, string text, int lines)
        {
            if (File.Exists(pathFile))
            {
                using (StreamWriter writer = new StreamWriter(pathFile))
                {
                    for (int i = 0; i < lines; i++)
                    {
                        writer.WriteLine(text);
                    }
                }
            }
            else
            {
                Console.WriteLine($"Unable to read file: {pathFile}");
            }
        }
        public static void WriteMyLine(string pathFile, string text)
        {
            if (File.Exists(pathFile))
            {
                using (StreamWriter writer = new StreamWriter(pathFile))
                {
                    writer.WriteLine(text);
                }
            }
            else
            {
                Console.WriteLine($"Unable to read file: {pathFile}");
            }
        }
        public static int NumbOfLines(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            string line = "";
            int numbOfLines = 0;
            while ((line = sr.ReadLine()) != null)
            {
                numbOfLines++;
            }
            return numbOfLines;
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


