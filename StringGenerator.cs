using System;
using System.Timers;

namespace StringGeneratorNS {
    
    class StringGenerator {
      private static Random random = new Random();
      private string randomString:
      
      private static string RandomString() {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        const int length = 20;
        return new string(Enumerable
          .Repeat(chars, length)
          .Select(s => s[random.Next(s.Length)])
          .toArray())
        );
      }

      private static void PrintRandomString(Object source, ElapsedEventArgs e) {
        Console.WriteLine(randomString)
      }
      
      public static void Main(string[] args) {
        randomString = RandomString();
        
        aTimer = new Timer();
        aTimer.Interval = 5000;
        aTimer.Elapsed += PrintRandomString;
        aTimer.AutoReset = true;
        aTimer.Enabled = true;
      }
    }
}