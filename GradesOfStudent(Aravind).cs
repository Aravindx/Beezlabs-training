using System;


namespace grades_of_students
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = 0;
            do
            {
                string input;
                
                Console.WriteLine("GRADE OF A STUDENT");
                Console.WriteLine("__________________\n");
                Console.WriteLine("Input the grade:");
                input = Console.ReadLine();

                if (input == "E" || input == "e")
                {
                    Console.WriteLine("Excellent");
                }
                else if (input == "V" || input == "v")
                {
                    Console.WriteLine("Very Good");
                }
                else if (input == "G" || input == "g")
                {
                    Console.WriteLine("Good");
                }
                else if (input == "A" || input == "a")
                {
                    Console.WriteLine("Average");
                }
                else if (input == "F" || input == "f")
                {
                    Console.WriteLine("Fail");
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
                Console.WriteLine("Press 1 to continue");
                loop = Convert.ToInt32(Console.ReadLine());

            } while (loop==1);
        }
    }
}