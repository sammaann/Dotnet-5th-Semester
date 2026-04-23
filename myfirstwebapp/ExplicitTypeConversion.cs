using System;

namespace myfirstwebapp
{
    internal class ExplicitTypeConversion
    {
        public void Run()
        {
            //example();
            ArithmeticOperation();
        }

        private void Example()
        {
            double a = 10.5;
            int b = (int)a;

            Console.WriteLine(b);

            long c = 345246535475;  // overflow example
            byte d = (byte)c;
            Console.WriteLine(d);

            char e = 'A';
            byte f = (byte)e;
            Console.WriteLine(f);

            int g = Convert.ToInt32("123");
            Console.WriteLine(g);
        }

        // Ask two numbers and perform arithmetic operations
        private void ArithmeticOperation()
        {
            Console.Write("Enter first number: ");
            string a = Console.ReadLine() ?? "0";

            Console.Write("Enter second number: ");
            string b = Console.ReadLine() ?? "0";

            int c = Convert.ToInt32(a);
            int d = Convert.ToInt32(b);

            int sum = c + d;
            int sub = c - d;
            int mul = c * d;

            Console.WriteLine("\nResults:");
            Console.WriteLine("Addition: " + sum);
            Console.WriteLine("Subtraction: " + sub);
            Console.WriteLine("Multiplication: " + mul);

            if (d != 0)
                Console.WriteLine("Division: " + (c / d));
            else
                Console.WriteLine("Division: Cannot divide by zero");

            // Ask floating number and convert to double then byte
            Console.Write("\nEnter a floating number: ");
            string e = Console.ReadLine() ?? "0";

            double f = Convert.ToDouble(e);
            Console.WriteLine("Double value: " + f);

            byte g = (byte)f;
            Console.WriteLine("Byte value: " + g);
        }
    }
}