using System;
namespace Exception_Handling
{//Write a program that shows FormatException
    class try_and_catch_blocks
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 5, 6,};
            try
            {
                arr[0] = 1;
                arr[1] = 2;
                arr[2] = 3;
                arr[3] = 4;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);   
            }
            Console.ReadLine();
        }
    }
}
