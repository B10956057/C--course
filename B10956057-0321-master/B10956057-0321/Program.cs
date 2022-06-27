using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace B10956057_0321
{
    class Program
    {
        static async  Task Main(string[] args)
        {
            /*練習一
            //Car Car123 = new Car();
            //Car123.showInfo();
            */

            /*練習三
            int guess;
            int minRange = 0, maxRange = 100;
            Random ans = new Random();
            int answer = ans.Next(minRange,maxRange);
            Console.WriteLine("請輸入" + minRange + "到" + maxRange + "之間的數:");
            int round = 6;
            while (round > 0)
            {
                round -= 1;
                Console.WriteLine("剩餘次數" + round);

                guess = int.Parse(Console.ReadLine());
                if (guess == answer)
                {
                    Console.WriteLine("答對了!!!");
                    

                }
                else if(guess < answer)
                {
                    minRange = guess;
                    Console.WriteLine("介在" + minRange + "和" + maxRange + "之間");
                    Console.WriteLine("請重新輸入:");
                    continue;
                }
                else if(guess > answer)
                {
                    maxRange = guess;
                    Console.WriteLine("介在" + minRange + "和" + maxRange + "之間");
                    Console.WriteLine("請重新輸入:");
                    continue;
                }

            }
            */








            /*練習二
            await MyHttpClientAsync();
            HttpClient is intended to be instantiated once per application, rather than per-use. See Remarks.
            */
        }


        /*練習二
        static private async Task MyHttpClientAsync()
        {
            HttpClient Client = new HttpClient(); 
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                HttpResponseMessage response = await Client.GetAsync("http://www.contoso.com/");
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
        */

    }
}
