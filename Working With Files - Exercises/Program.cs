using System;
using System.Collections.Generic;
using System.IO;

namespace Working_With_Files___Exercises
{
    internal class Program
    {
        // 1- Write a program that reads a text file and displays the number of words.       

        // 2- Write a program that reads a text file and displays the longest word in the file.

        static void Main(string[] args)
        {
            string filePath = @"C:\Users\pablo\source\repos\Working With Files - Text Sheet.txt";
            Console.WriteLine($"Full path = {Path.GetFullPath(filePath)}");
            string fileName = Path.GetFileName(filePath);
            string fileNameExclExtenstion = Path.GetFileNameWithoutExtension(filePath);
            string fileExtenstion = Path.GetExtension(filePath);
            
            string readText = File.ReadAllText(filePath);
            Console.WriteLine(string.Empty);
            Console.WriteLine(readText);
            Console.WriteLine(string.Empty);
            string[] stringArray = readText.Split(',');
            int wordCount = 0;
            int charCountOfWord = 0;
            string longestWord = "LONGEST WORD DEFAULT";
            List<string> trimmedWordList = new List<string>();

            foreach (string word in stringArray)
            {
                string removeFullStop = word.Replace('.', ' ');
                string trimmedWord = removeFullStop.Trim(' ');
                wordCount =+ wordCount + 1;
                Console.WriteLine(trimmedWord);
                trimmedWordList.Add(trimmedWord);
            }
            Console.WriteLine(string.Empty);
            Console.WriteLine($"Total amount of words in document \"{fileName}\" is {wordCount}.");

            foreach (string newWord in trimmedWordList)
            {
                if (newWord.Length > charCountOfWord)
                {
                    charCountOfWord = newWord.Length;
                    longestWord = newWord;
                }
            }
            Console.WriteLine(string.Empty);
            Console.WriteLine($"The longest word in document \"{fileName}\" is {longestWord.ToUpper()} and is {charCountOfWord} characters long.");
        }
    }
}
