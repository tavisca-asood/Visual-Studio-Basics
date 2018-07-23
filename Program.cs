using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class Program
    {

        static void printPattern()
        {
            Console.WriteLine("Enter the value of n");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= n - i; k++)
                    Console.Write(' ');
                for (int j = 1; j <= i + (i - 1); j++)
                    Console.Write('*');
                Console.WriteLine();
            }
        }

        static void swap()
        {
            Console.WriteLine("Enter the first number");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("The First Number is {0}\nThe second number is {1}", a, b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter '1' to swap 2 numbers. Enter '2' to print the pattern.");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
                swap();
            else if (choice == 2)
                printPattern();
            Console.ReadKey();
        }
    }
}
