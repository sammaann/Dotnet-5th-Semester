using System;

namespace StaticStudentExample
{
    class Student
    {
        
        public static string SchoolName;
        public static int TotalStudents;

        // Static Constructor
        static Student()
        {
            SchoolName = "Nepathya College";
            TotalStudents = 0;

            Console.WriteLine("Welcome! Student system initialized.");
        }

        // Instance Fields
        public string Name;
        public int StudentId;
        public double GPA;

        // Parameterized Constructor
        public Student(string name, int studentId, double gpa)
        {
            Name = name;
            StudentId = studentId;
            GPA = gpa;

            TotalStudents++;
        }

        // Instance Method
        public void DisplayInfo()
        {
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Student ID: " + StudentId);
            Console.WriteLine("GPA: " + GPA);
            Console.WriteLine();
        }


        // Static Method
        public static void DisplaySchoolInfo()
        {
            Console.WriteLine("School Name: " + SchoolName);
            Console.WriteLine("Total Students: " + TotalStudents);
        }
    }


    public class Program
    {
        public void Run()
        {
           
            Student s1 = new Student("Samman", 101, 3.8);
            Student s2 = new Student("Suman", 102, 3.5);
            Student s3 = new Student("Rameyy", 103, 3.9);
            Student s4 = new Student("Niruuu", 104, 3.6);

            
            s1.DisplayInfo();
            s2.DisplayInfo();
            s3.DisplayInfo();
            s4.DisplayInfo();

            
            Student.DisplaySchoolInfo();
        }
    }
}