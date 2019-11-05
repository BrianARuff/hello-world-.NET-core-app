using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var str = Console.ReadLine() + "\n";
            Console.WriteLine(str);
            Console.WriteLine(FibonacciNumber(15));

            var generator = new FiboGenerator();
            foreach (var digit in generator.Generate(15)) {
            Console.WriteLine(digit);
        }
        }
        
        static int FibonacciNumber(int n) {
            n = n < 46 ? n : 46; // ensure n is always less than 1000 to avoid too much fibonacci sequence.
            int a = 0; 
            int b = 1;
            int tmp; // undeclared type int
            for (int i = 0; i < n; i++) {
                tmp = a; // 0 1 2 3 5 8 13
                a = b; // 1 2 3 5 8 13 21
                b += tmp; // 2 3 5 8 13 21 34  fibonacci numbers
            }
            return a;
        }
    }
}
