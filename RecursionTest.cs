using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class RecursionTest
    {
        public int Factorial(int number)
        {
            if(number<=1) return 1;

            return number*Factorial(number-1);
        }
        public int Fibonacci(int number)
        {
            if (number <= 1) // Base condition
            {
                return number;
            }

            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }

        public  RecursionTest()
        {
            Console.WriteLine(Factorial(5));
            Console.WriteLine(Fibonacci(6));
        }
    }
}
