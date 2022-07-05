using System;
namespace Exception_Handling
{//Write a program that catches IndexOutOfRange Exception
    class try_and_catch_blocks
    {
        static void Main(string[] args)
        {
            string s = null;
            if (s == null)
            {
                Console.WriteLine("String is null. ##NullReferenceException");
            }
            else
            {
                Console.WriteLine(s.Length);
            }
            Console.ReadLine();
        }
    }
}
