using System;
using System.Linq;
using System.Threading.Tasks;

namespace myApp
{
    class Program
    {    
        private static string randomString;
        private static Random random = new Random();

        static async Task Main(string[] args)
        {
            randomString = RandomString();

            while (true)
            {
                Console.WriteLine(randomString);
                await Task.Delay(5000);
            }
        }

        public static string RandomString()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789-";
            const int length = 30;
            return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}