using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



namespace async
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(() => PrintNumber());
            Console.WriteLine("[1]");
            Thread.Sleep(5);
        }
        static async Task PrintNumber()
        {
            await Task.Run(() =>
            {
                for (int i = 1; i <= 500; i++)
                {
                    Console.WriteLine(i);
                }
            });
        }
    }
}
