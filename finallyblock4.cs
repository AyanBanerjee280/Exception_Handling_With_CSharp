using System;
namespace Exception_Handling
{//No catch block but Finally block will still be executed. 
    class try_catch_and_finally_blocks
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 9;
                int b = 3;
                int result = a / b;
                Console.WriteLine(result);

                int[] arr = new int[2];
                {
                    arr[0] = 1;
                    arr[1] = 2;
                    arr[2] = 3;
                }
                
            }
            finally
            {
                Console.WriteLine("Finally Block will always be executed.");
            }
            Console.ReadLine();
        }
    }
}
