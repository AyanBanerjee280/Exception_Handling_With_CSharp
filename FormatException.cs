using System;
namespace Exception_Handling
{//Write a program that shows FormatException
    class try_and_catch_blocks
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number here: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("Number = " + num);
            }
            catch (Exception ex)
            {
                Console.WriteLine("String Format is invalid. Please enter a number.");
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
