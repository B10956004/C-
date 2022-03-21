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
            */

            await MyHttpClientAsync();//非同步await 等待request 否則一傳送完就結束主執行緒

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
