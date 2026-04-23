using System;

namespace myfirstwebapp
{
    internal class ImplicitTypeConversion
    {
        public void Run()
        {
            sameTypeExample();
            differentTypeExample();
        }

        private void sameTypeExample()
        {
            byte a = 10;

            short b = a;
            int c = a;
            long d = a;

            Console.WriteLine("Same Type Conversion:");
            Console.WriteLine($"byte: {a}");
            Console.WriteLine($"short: {b}");
            Console.WriteLine($"int: {c}");
            Console.WriteLine($"long: {d}");
        }

        private void differentTypeExample()
        {
            long a = 10;
            float b = a; // compatible datatype

            char aa = 'A';
            int bb = aa;

            Console.WriteLine("\nDifferent Type Conversion:");
            Console.WriteLine($"long: {a}");
            Console.WriteLine($"float: {b}");
            Console.WriteLine($"char: {aa}");
            Console.WriteLine($"int (Unicode value): {bb}");
        }
    }
}