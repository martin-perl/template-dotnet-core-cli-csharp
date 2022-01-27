using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace com.test.header
{
    public class HttpGet
    {
        public HttpGet() {

        }
        public async Task Get()
        {
            HttpClient client = new HttpClient();

            string html = string.Empty;
            string url = @"https://www.google.de";

            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                html = response.Content.ReadAsStringAsync().Result;
            }
            Console.WriteLine($"HTML: {html}");  
        }
    }
}