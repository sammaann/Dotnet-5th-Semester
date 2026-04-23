using System;

namespace myfirstwebapp
{
    internal class ConditionalExample
    {
        public void Run()
        {
            ConditionalStatement();
        }

        private void ConditionalStatement()
        {
            // -------- Normal Multiplication Table --------
            // Console.WriteLine("Enter the number you want multiplication of:");
            // int input = Convert.ToInt32(Console.ReadLine());

            // for (int i = 1; i <= 10; i++)
            // {
            //     Console.WriteLine($"{input} x {i} = {input * i}");
            // }


            // -------- Continue & Break Example --------
            Console.WriteLine("Enter the number you want multiplication of:");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                if (i == 3)
                {
                    continue; // skip when i = 3
                }

                if (i == 6)
                {
                    break; // stop loop when i = 6
                }

                Console.WriteLine($"{input} x {i} = {input * i}");
            }
        }
    }
}