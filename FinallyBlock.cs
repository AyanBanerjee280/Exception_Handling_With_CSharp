using System;
namespace Exception_Handling
{//Write a program using Multiple Catch blocks
    class try_and_catch_blocks
    {
        static void Main(string[] args)
        {
            int a = 90;
            int b = 10;
            int result = 90 / 10;

            try
            {
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally Block will always be executed.");
            }
            Console.ReadLine();
        }
    }
}
