using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            short i16 = 1;
            int i32 = 1;
            double db = 1;

            i16 = (short)i32;
            i16 = (short)db;
            i32 = i16;
            i32 = (int)db;
            db = 116;
            db = i32;
        }
    }
}
