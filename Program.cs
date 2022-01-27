using System;
using System.Threading.Tasks;

namespace com.test.header
{
    class Program
    {
        static async Task Main(string[] args) {
            Console.WriteLine("Hello World!");
            HttpGet httpGet = new HttpGet();
            await httpGet.Get();
        }
    }
}
