using System;

namespace Modul5HW1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var start = new Starter();
            start.Run().GetAwaiter().GetResult();
        }
    }
}
