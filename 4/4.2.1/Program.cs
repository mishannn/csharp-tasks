using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<String>();

            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            queue.Enqueue("Fourth");

            while (queue.Count > 0)
            {
                object obj = queue.Dequeue();
                Console.WriteLine("From Queue: {0}", obj);

            }
        }
    }
}
