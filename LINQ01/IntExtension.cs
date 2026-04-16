using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ01
{
    internal static class IntExtension
    {
        public static int Reverse (this int Number)
        {
            int Result = 0;
            while (Number > 0)
            {
                Result = Number % 10 + Result * 10;
                Number /= 10;
            }
            return Result;
        }
    }
}
