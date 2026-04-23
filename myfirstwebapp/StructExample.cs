using System;

namespace FirstConsoleApp
{
    struct User
    {
        public int Id;
        public string Firstname;
        public string Lastname;

        public string getFullName()
        {
            return Firstname + " " + Lastname;
        }
    }

    struct Point1
    {
        public int X;
        public char Label;
    }

    struct Point2
    {
        public int X;
        public string Name;
    }

    struct point3
    {
        public int X;
        public NameInfo Name;
    }

    class NameInfo
    {
        public string Value = ""; 
    }

    internal class StructExample
    {
        public void Run()
        {
            Userexample();
            point1Example();
            point2Example();
            point3Example();
        }

        private void point1Example()
        {
            Point1 p1 = new Point1();
            p1.X = 10;
            p1.Label = 'A';

            Point1 p2 = p1;

            Console.WriteLine($"P1 x={p1.X} Label={p1.Label}");
            Console.WriteLine($"P2 x={p2.X} Label={p2.Label}");
        }

        private void point2Example()
        {
            Point2 p1 = new Point2();
            p1.X = 10;
            p1.Name = "Niraj";

            Point2 p2 = p1;
            
            Console.WriteLine($"P1 x={p1.X} Name={p1.Name}");
          
        }

        private void point3Example()
        {
            point3 p = new point3();
            p.X = 30;
            p.Name = new NameInfo();
            p.Name.Value = "Point C";

            Console.WriteLine($"P3 x={p.X} Name={p.Name.Value}");
        }

        private void Userexample()
        {
            User user2 = new User();
            user2.Id = 1;
            user2.Firstname = "Ramey";
            user2.Lastname = "Smith";

            var fullName = user2.getFullName();

            Console.WriteLine(fullName);
        }
    }
}