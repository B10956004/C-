using System;

namespace _0314
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 0;
            //Console.WriteLine("請輸入數字");
            //num = Convert.ToInt32(Console.ReadLine());
            //if (num % 2 == 1)
            //{
            //    Console.WriteLine("Weird");
            //}
            //else if (num / 2 >= 2 && num / 2 <= 5)
            //{
            //    Console.WriteLine("Not Weird");
            //}
            //else if (num / 2 >= 6 && num / 2 <= 20)
            //{
            //    Console.WriteLine("Weird");
            //}
            //else
            //{
            //    Console.WriteLine("Not Weird");
            //}

            int n = 0;
            Console.WriteLine("請輸入N:");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.WriteLine("*");
                }
            }

        }
    }
}
