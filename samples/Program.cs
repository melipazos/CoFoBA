using System;
using NetCoFoBA;

namespace samples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var client=new NetCoFoBAClient();
            var result=client.GetData().Result;
            Console.WriteLine(result);
        }
    }
}
