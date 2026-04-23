using System;

namespace FirstConsoleApp
{
    internal class ReferenceTypeExample
    {
        public void run()
        {
            objectExample();
            dynamicExample();
        }

        private void objectExample()
        {
            object x = "Hello";


            Console.WriteLine(((string)x).Length);

            x = 10;


            Console.WriteLine((int)x + 20);

            x = 'A';


            Console.WriteLine((char)x);
        }

        private void dynamicExample()
        {
            dynamic x = "Ramey";
            Console.WriteLine(x.Length);
            x = 10;
            Console.WriteLine(x + 20);
            x = 'A';
            Console.WriteLine(++x);
        }
    }
}