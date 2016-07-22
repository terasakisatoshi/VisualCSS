using System;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static int Main(string[] args)
        {
            String output;
            StreamWriter swriter1 = new StreamWriter("NumberTable.txt");

            Console.Title = "number table";
            String head;
            String hifuns;
            head = "     ^2      ^3      ^4     sqrt";
            hifuns = "---- -------- -------- --------";
            Console.WriteLine(head);
            Console.WriteLine(hifuns);
            swriter1.WriteLine(head);
            swriter1.WriteLine(hifuns);
            for (int i = 0; i <= 10; i++)
            {
                output=String.Format(" {0,2}   {1,5}   {2,5}   {3,5}   {4:F4}", i, i * i, i * i * i, i * i * i * i, Math.Sqrt(i));
                Console.WriteLine(output);
                swriter1.WriteLine(output);
            }
            Console.Read();
            swriter1.Close();
            return 0;
        }
    }
}
