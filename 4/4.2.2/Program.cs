using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<String>();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            stack.Push("Fourth");
            while (stack.Count > 0)
            {
                object obj = stack.Pop();
                Console.WriteLine("'From Stack: {0}", obj);
            }

        }
    }
}
