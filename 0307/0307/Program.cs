using System;

namespace 練習1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //String text = "我只是文字";

            //Console.WriteLine(text);

            //String text2 = Console.ReadLine();

            //Console.WriteLine("你輸入了:"+text2);

            double meal_cost = 100;
            int tip_percent = 15;
            int tax_percent = 8;
            int sum = Convert.ToInt32(meal_cost) + tip_percent + tax_percent;
            int sum2 = (int)(meal_cost + tip_percent + tax_percent);
            Console.WriteLine($"您總共花費:{sum}");

        }
    }
}
