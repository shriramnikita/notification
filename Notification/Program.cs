
using Json.Net;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Notification
{
    class Program
    {
        // static readonly HttpClient client = new HttpClient();
        static async Task CallWebAPIAsync()
        {
            //using (var response = request.GetResponse() as HttpWebResponse)
            //{
            // var request = WebRequest.Create("http://localhost:12698/token") as HttpWebRequest;
            // request.CookieContainer = new CookieContainer();
            // authCookie = response.Cookies["access_token"];
            //}
            using (var client = new HttpClient())
            {
                string userId = "7212c15b-3921-4104-a078-fa2a1409844a";
                var response = await client.GetAsync("https://localhost:44377/api/Notes/alarm/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                response.EnsureSuccessStatusCode();
                var responseAsString = await response.Content.ReadAsStringAsync();
             //   var responseAsConcreteType = JsonConverter.DeserializeObject<NotesModel>(responseAsString);
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);
                Console.WriteLine(responseBody);
            }
            //catch (HttpRequestException e)
            //{
            // Console.WriteLine("\nException Caught!");
            Console.WriteLine("Message :{0} ", e.Message);
            //}
        }
        static void Main(string[] args)
        {
            CallWebAPIAsync()
            .Wait();
            Console.WriteLine("Hello I am trying to calling push notification web api........!");
            System.Threading.Thread.Sleep(1000 * 60 * 5);
        }
    }
}
