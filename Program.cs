using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace nauka
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            GetData();

            Console.ReadLine();
            
        }

        static async void GetData()
        {
            string b = "\"order_id\"";
            var client = new HttpClient();

            var data = new FormUrlEncodedContent(new List<KeyValuePair<string,string>>{
                new KeyValuePair<string, string>("token", Settings.Token),
                new KeyValuePair<string, string>("method", "getOrders"),
                new KeyValuePair<string, string>("parameters", "{" + $"{b}: 34090396"+"}"),
            } );

            HttpResponseMessage a = await client.PostAsync("https://api.baselinker.com/connector.php",data);
            Console.WriteLine(a.Content.ReadAsStringAsync().Result);
            Console.WriteLine($"{b}: 34090396 ");
            

        }
    }
}
