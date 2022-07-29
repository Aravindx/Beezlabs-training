using System;

namespace ReversingString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Sentence that need to be Reversed");
            string sentence = Console.ReadLine();
            string[] word = sentence.Split(" ");
            Console.WriteLine("--------------------");
            Console.WriteLine("The reversed sentence is:");
            for (int i = word.Length - 1; i >= 0; i--)
            {
               
                Console.Write("\t{0}",word[i]);

            }
        }
    }
}
