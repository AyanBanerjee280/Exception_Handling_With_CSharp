using System;
namespace Exception_Handling
{//Our Throw and Default Catch
    class try_and_catch_blocks
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Elligible for voting");
            }
            else
            {
                throw new Exception("Not elligible for voting");
            }
            Console.ReadLine();
        }
    }
}