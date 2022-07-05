using System;
namespace Exception_Handling
{//Write a program using Multiple Catch blocks
    class try_and_catch_blocks
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 78;
                int b = 5;
                int result = a / b;
                Console.WriteLine(result);

                int[] arr = new int[3];
                arr[0] = 1;
                arr[1] = 2;
                arr[2] = 3;
                arr[3] = 4;
                //Only this IndexOutOfRangeException will be executed in this programme
                string s = null;
                Console.WriteLine(s.Length);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);   
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
