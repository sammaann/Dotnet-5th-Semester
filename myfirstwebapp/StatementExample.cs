using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace myfirstwebapp
{
    internal class StatementExample
    {
        public void Run() {
            ConditionalStatement();
                }
        private void ConditionalStatement()
        {
            //Console.WriteLine("Enter the first, second and third number ");
            //int input1 = Convert.ToInt32(Console.ReadLine());
            //int input2 = Convert.ToInt32(Console.ReadLine());
            //int input3 = Convert.ToInt32(Console.ReadLine());



            //if (input1 >= input2 && input1 >= input3)
            //{
            //    Console.WriteLine($"Largest number is {input1}");

            //}
            //else if (input2 >= input1 && input2 >= input3)
            //{
            //    Console.WriteLine($"Largest number is {input2}");
            //}
            //else
            //{
            //    Console.WriteLine($"Largest number is {input3}");

            //}  ;




            //switch case 
            Console.WriteLine("Enter your exam marks ");

            int data = Convert.ToInt32(Console.ReadLine());

            switch (data)
            {
                case int n when n >= 90 && n <= 100:
                    Console.WriteLine("Excellent");
                    break;

                    case int n when n >= 80 && n < 90:
                        Console.WriteLine("Very Good");
                        break;

            default: Console.WriteLine("Failed");
                        break; 


            }
 

        }
    }
}