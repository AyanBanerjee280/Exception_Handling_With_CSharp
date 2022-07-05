using System;
namespace Exception_Handling
{//Write a program that catches DIVIDEBYZERO Exception
    class try_and_catch_blocks
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];
            try
            {
                array[0] = 1;
                array[1] = 78;
                array[2] = 56;
                array[3] = 45;
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Remaining statements will be executed
            Console.WriteLine("Remaining Statement1.");
            Console.WriteLine("Remaining Statement2.");
            Console.WriteLine("Remaining Statement3.");
            Console.ReadLine();
        }
    }
}
