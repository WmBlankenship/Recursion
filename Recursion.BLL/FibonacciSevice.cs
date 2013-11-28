using System;
using System.Linq;

namespace Recursion.BLL
{
    public class FibonacciSevice
    {
        public int GetFibonacciNumber(int sequenceIndex)
        {
            if (sequenceIndex == 1 || sequenceIndex == 2) return 1;
            else return GetFibonacciNumber(sequenceIndex - 1) + GetFibonacciNumber(sequenceIndex - 2);
        }
        public static int GetFibonacciNumberStatic(int sequenceIndex)
        {
            if (sequenceIndex == 1 || sequenceIndex == 2) return 1;
            else return GetFibonacciNumberStatic(sequenceIndex - 1) + GetFibonacciNumberStatic(sequenceIndex - 2);
        }
    }
}
