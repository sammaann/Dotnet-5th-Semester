using System;

namespace ObjectOriented
{
    internal class StaticExample
    {
        public void Run()
        {
           
            StaticClass.test();

            Laptop1 laptop1 = new Laptop1();
            Laptop1 laptop2 = new Laptop1(10);
        }
    }

    public static class StaticClass
    {
        public static void test()
        {
            Console.WriteLine("Static method called");
        }
    }

    class Laptop1
    {
        public static string Manufacturer = "Unknown";
        public int RamSize;

        public Laptop1()
        {
            Manufacturer = "Dell";
            RamSize = 8;
        }

        public Laptop1(int ramSize)
        {
            RamSize = ramSize;

            Console.WriteLine("Manufacturer: " + Manufacturer);
            Console.WriteLine("RAM: " + RamSize);
        }
    }
}

// Static modifier / Keyword
// - Static members belong to the class itself, not to any specific instance.
// - Static members can be accessed without creating an instance of the class.
// - Static members are shared across all instances of the class.

// Static Class
// - A static class cannot be instantiated and can only contain static members.
// - Static classes are useful for grouping related utility methods or constants that do not require an instance

// Static Member Field
//Accessed using the class name, not through an instance. 
// They are shared across all instances of the class. 
// Static fields are often used for constants or to maintain state that is common to all instances.

// Static Member Method
// - A static method belongs to the class and can be called without creating an instance of the class. 
// - Static methods can only access static members of the class and cannot access instance members.
// - Cannot use this keyword in static methods because they do not belong to any instance.

// Static Constructor
// - A static constructor is a special constructor that is called automatically before the first instance is created or any static members are accessed. 
// - Cannot have access modifiers and cannot take parameters.
// - Used to initialize static fields or perform actions that need to be done once for the class.
