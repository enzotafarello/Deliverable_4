/* Author: Enzo Tafarello Negrao
Date:2/9/23
Description: C# console application that computes the first 25 numbers of the Fibonacci sequence */

using System;

namespace Deliverable_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibonacci_n1 = 0;
            int fibonacci_n2 = 1;
            int fibonacci_n3;
            int i;

            int[] series = new int[25];

            series[0] = fibonacci_n1;
            series[1] = fibonacci_n2;

            for(i=2; i<25;++i)
            {
                fibonacci_n3 = fibonacci_n1 + fibonacci_n2;
                series[i] = fibonacci_n3;
                fibonacci_n1 = fibonacci_n2;
                fibonacci_n2 = fibonacci_n3;
            }
            for (i < 25; i++)
            {
                Console.WriteLine("Fibonacci number (" + i + ") = " + series[i]);
            }
            

        }
    }
}
