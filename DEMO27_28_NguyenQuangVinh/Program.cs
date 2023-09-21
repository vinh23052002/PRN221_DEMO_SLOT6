namespace DEMO27_28_NguyenQuangVinh
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    internal class Program
    {
        static readonly HttpClient client = new HttpClient();
        static async Task Main()
        {
            string uri = "https://www.google.com.vn/?hl=vi";
            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message: {0}", ex.Message);
            }
        }
       
    }
}