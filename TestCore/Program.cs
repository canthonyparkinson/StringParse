using SharedSource;
using System;

namespace TestCore
{
    class Program
    {
        static void Main(string[] args)
        {
            if (new Tests().Run())
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
    }
}
