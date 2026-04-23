using System;

namespace FirstConsoleApp
{
    internal class StringExample
    {
        public void Run()
        {
            FindLongestWord();
        }

        private void FindLongestWord()
        {
            Console.WriteLine("Enter a sentence:");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');
            string longestWord = "";

            foreach (var word in words)
            {
                if (word.Length > longestWord.Length)
                    longestWord = word;
            }

            Console.WriteLine($"Longest word: {longestWord}");

            string fname = "Samman";
            string lname = "Thapa";

            string fullName = fname + " " + lname;
            // Console.WriteLine(fullName);

            string fullNameMessage = $"Full Name: {fullName}";
            // Console.WriteLine(fullNameMessage);

            string substringExample = fname.Substring(2, 2);
            // Console.WriteLine(substringExample);

            string substringExample2 = lname.Substring(2, 2);
            // Console.WriteLine(substringExample2);

            foreach (string s in words)
            {
                // Console.WriteLine(s);
            }
        }
    }
}
