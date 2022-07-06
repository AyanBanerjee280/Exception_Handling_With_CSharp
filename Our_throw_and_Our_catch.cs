using System;
namespace Exception_Handling
{//Our Throw and Our Catch
    class try_and_catch_blocks
    {
        static void Main(string[] args)
        {
            try
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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadLine();
        }
    }
}