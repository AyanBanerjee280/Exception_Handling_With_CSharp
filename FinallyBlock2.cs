using System;
namespace Exception_Handling
{//Write a program using Finally block. 
    class try_and_catch_blocks
    {
        static void Main(string[] args)
        {
            

            try
            {
                int a = 90;
                int b = 0;
                int result = a / b;
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
