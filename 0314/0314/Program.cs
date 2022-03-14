using System;

namespace _0314
{
    class Program
    {
        static private void TestFunc()
        {
            try
            {
                Console.WriteLine("hi");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);//錯誤顯示
            }
        }
        static void Main(string[] args)
        {
            TestFunc();
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

            //Console.WriteLine("練習1");
            //int n;
            //Console.WriteLine("請輸入N:");
            //n = Convert.ToInt32(Console.ReadLine());
            //for(int i = 0; i < n; i++)
            //{
            //    for(int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //}
            //Console.WriteLine("練習2");
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine(n+"*"+i+"="+n * i);
            //}
            //Console.WriteLine("練習3");
            //for(int i = 1; i < 10; i++)
            //{
            //    for(int j = 1; j < 10; j++)
            //    {
            //        Console.Write(i + "*" + j + "=" + i * j+" ");
            //    }
            //    Console.Write("\n");
            //}
            Console.WriteLine("請輸入座號(1-5)");
            int num = Convert.ToInt32(Console.ReadLine());
            string[,] student = new string[6, 5] { { "座號", "姓名", "電腦概論", "程式設計", "動畫製作" },{ "1", "Jack", "80", "75","60" },{ "2", "Mary", "65", "67", "62" },{ "3", "Tom", "100", "93", "91" },{ "4", "Grace", "98", "25", "50" },{ "5", "Alice", "83", "82", "87" } };
            //放共6列5欄資料
            for(int i = 0; i < 5; i++)
            {
                Console.Write(student[0, i]+":");
                Console.WriteLine(student[num, i]);
            }
            
        }
    }
}
