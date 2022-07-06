using System;
namespace Exception_Handling
{//Default Throw and Default Catch
    class try_and_catch_blocks
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 89;
                int b = 0;
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
           
        }
    }
}