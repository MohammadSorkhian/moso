using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;

namespace Temp
{
    class Program
    {

        static async Task Main(string[] args)
        {
            await ReadFileAsync();
            await ReadFileAsync();
            ReadFileAsync();
            ReadFileAsync();
            ReadFileAsync();
            ReadFileAsync();

            Console.Read();
        }

        static async Task<int> ReadFileAsync()
        {
            await Task.Delay(1000);
            Console.WriteLine("Reading File has been completed");
            return 1;
        }

 
    }

}

    

