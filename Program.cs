using System;
using System.Threading.Tasks;
using com.test.delegates;
using com.test.implementations;

namespace com.test.header
{
    class Program
    {
        static async Task Main(string[] args) {
            Console.WriteLine("Hello World!");

            // Instantiate the delegate.
            GetData dataDelegate = Data.AddDelegateMethod;

            // Call the delegate.
            Console.WriteLine(dataDelegate(1, 2));

            dataDelegate = Data.MultiplyDelegateMethod;

            // Call the delegate.
            Console.WriteLine(dataDelegate(1, 2));

            //HttpGet httpGet = new HttpGet();
            //await httpGet.Get();
        }
    }
}
