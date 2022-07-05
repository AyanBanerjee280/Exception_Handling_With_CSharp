using System;
namespace Exception_Handling
{//Write a program that catches DIVIDEBYZERO Exception
    class try_and_catch_blocks
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number here: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number here: ");
            int b = int.Parse(Console.ReadLine());
            try
            {
                int result = a / b;
                Console.WriteLine(result);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero.");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Remaining Statement1.");
            Console.WriteLine("Remaining Statement2.");
            Console.WriteLine("Remaining Statement3.");
            Console.ReadLine();
        }
    }
}
