using System;
using System.Runtime.CompilerServices;

namespace Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to see if it's divisible by 5");
            var number = Convert.ToInt32(Console.ReadLine());
            if (number % 5 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.WriteLine("Value of X");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value of Y");
            var y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x + y);
            if (x >= y)
            {
                Console.WriteLine(x - y);
            }
            else
            {
                Console.WriteLine(y - x);
            }
            Console.WriteLine(x * y);
            if (x == 0 || y == 0)
            {
                Console.WriteLine("Not allowed to divide by zero");
            }
            else
            {
                if (x >= y)
                {
                    Console.WriteLine(x / y);
                }
                else
                {
                    Console.WriteLine(y / x);
                }
            }
            Console.WriteLine("Enter value of X");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of Y");
            var b = Convert.ToInt32(Console.ReadLine());
            var c = a;
            Console.WriteLine(a = b);
            Console.WriteLine(b = c);
            Console.WriteLine("Enter a number");
            var num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(num * i);
            }
            Console.WriteLine("Please, enter a number");
            var numb = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < numb; i += 2)
            {
                Console.WriteLine(i * i);
            }
        }
    }
}
