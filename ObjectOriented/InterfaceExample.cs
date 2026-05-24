using System;
namespace ObjectOriented
{
    internal class InterfaceExample
    {
        // public void Run()
        // {
        //     Cat cat = new Cat();
        //     cat.Name = "Lucifer";
        //     cat.Eat();
        //     cat.HaveMilk();
        // }

        // public interface IAnimal
        // {
        //     string Name { get; set; }
        //     void Eat();

        // }
        // public interface IMammal
        // {
        //     void HaveMilk();

        // }

        // public class Cat : IAnimal, IMammal
        // {
        //     public string Name { get; set; }

        //     public void Eat()
        //     {
        //         Console.WriteLine(Name + " is eating.");
        //     }

        //     public void HaveMilk()
        //     {
        //         Console.WriteLine(Name + " is having milk.");
        //     }
        // }



        public void Run()
        {
            Student student = new Student();
            student.Name = "Samman";
            student.age = 22;
            student.DisplayInfo();
            student.Study();

        }

        public interface IStudent
        {
            string Name { get; set; }
            int age { get; set; }
            void DisplayInfo();
            void Study();
        }

        public class Student : IStudent
        {
            public string Name { get; set; }

            public int age { get; set; }

            public void DisplayInfo()
            {

                Console.WriteLine($"Student Name: {Name}, Age: {age}");

            }

            public void Study()
            {
                Console.WriteLine($"{Name} is studying. Age: {age}");
            }
        }
    }
}
