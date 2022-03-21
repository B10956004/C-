using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace _0321
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //int result = add(5, 8);
            //Console.WriteLine(result);
            //int num = 5;
            //int num2 = 8;
            //refAdd(ref num, ref num2);
            //Console.WriteLine(num+"\t"+num2);


            //Car myCar = new Car();
            ////myCar.StartEngine();
            //myCar.ShowInfo();
            //myCar.changeColor("blue");
            //Console.WriteLine("顏色轉換");
            //myCar.ShowInfo();
            //Console.WriteLine("\n");
            //myCar.OpenDoor();
            //Car myCar2 = new CarA();
            //myCar2.changeColor("yellow");
            //myCar2.ShowInfo();
            //myCar2.OpenDoor();
            //myCar2.StartEngine();
            /*
             * 父類別
              abstract => 抽象方法。=>"一定"要用override覆蓋;只宣告方法不實作
              virtual => 虛擬方法。推薦使用 =>"可以"用override覆蓋;宣告方法且實作，預期子類別會覆寫
             * 子類別
              override => 覆蓋基礎類別方法。
              new => 隱藏基礎類別方法。
            http://softrei.blogspot.com/2016/07/override.html

            https://ad57475747.medium.com/c-%E9%9B%9C%E8%A8%98-%E4%BB%8B%E9%9D%A2-interface-%E6%8A%BD%E8%B1%A1-abstract-%E8%99%9B%E6%93%AC-virtual-%E4%B9%8B%E6%88%91%E8%A6%8B-dc3c5878bb80

            */

            //await MyHttpClientAsync();//非同步await 等待request 否則一傳送完就結束主執行緒

            bool play = true;
            while (play)
            {
                int ans = MyRandom(1, 100);
                int max = 100;
                int min = 1;
                int count = 5;
                while (true)
                {
                    if (count == 5)
                    {
                        Console.WriteLine("數字介於" + min + "~" + max + "之間，有" + count + "次機會");
                    }
                    else
                    {
                        Console.WriteLine("數字介於" + min + "~" + max + "之間，剩下" + count + "次機會");
                    }
                    int user = Convert.ToInt32(Console.ReadLine());
                    count--;
                    if (user > max)
                    {
                        Console.WriteLine("請勿輸入大於最大數字");
                        continue;
                    }
                    if (user < min)
                    {
                        Console.WriteLine("請勿輸入小於最小數字");
                        continue;
                    }
                    if (ans > user)
                    {
                        min = user;
                    }
                    else
                    {
                        max = user;
                    }
                    if (user == ans)
                    {
                        Console.WriteLine("你贏了!正確數字為:" + ans);
                        play=PlayAgain();
                        break;

                    }
                    if (user!=ans&&count == 0)
                    {
                        Console.WriteLine("你輸了!正確數字為:" + ans);
                        play=PlayAgain();
                        break;
                    }
                    
                }
            }
            
        }
        static private bool PlayAgain()
        {
            Console.WriteLine("是否繼續遊玩?(輸入1為繼續，0為結束)");
            int playAgain = Convert.ToInt32(Console.ReadLine());
            if (playAgain == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        static private int MyRandom(int min,int max)
        {
            Random random1 = new Random();
            return random1.Next(min, max + 1);
        }



        // HttpClient is intended to be instantiated once per application, rather than per-use. See Remarks.
        static readonly HttpClient client = new HttpClient();

        static async Task MyHttpClientAsync()
        {
            string url = "https://data.coa.gov.tw/api/v1/AgriProductsTransType/?Start_time=110.03.01&End_time=110.03.21";
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }

        //static private int add(int a,int b)//傳值呼叫
        //{
        //    return a + b;
        //}

        //static private void refAdd(ref int a,ref int b)//傳址呼叫
        //{
        //    a *= a;
        //    b *= b;
        //}


    }
}
