using System;

namespace ConsoleApplication1
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.Title = "number table";
            Console.WriteLine("     ^2      ^3      ^4      sqrt");
            Console.WriteLine("---- -------- -------- --------");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(" {0,2}   {1,5}   {2,5}   {3,5}   {4:F4}", i, i * i, i * i * i,i*i*i*i, Math.Sqrt(i));
            }
            Console.Read();
            return 0;
        }
    }
}
