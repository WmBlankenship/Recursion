using System;
using System.Linq;
using Recursion.BLL;

namespace Recursion.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(GetFibonacciFromServiceInstance(15));
            Console.WriteLine(GetFibonacciFromStaticService(15));
            Console.ReadKey();
        }

        private static int GetFibonacciFromServiceInstance(int sequenceIndex)
        {
            var fibService = new FibonacciSevice();
            return fibService.GetFibonacciNumber(sequenceIndex);
        }

        private static int GetFibonacciFromStaticService(int sequenceIndex)
        {
            return FibonacciSevice.GetFibonacciNumberStatic(sequenceIndex);
        }
    }
}
