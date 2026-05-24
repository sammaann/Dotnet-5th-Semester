// using System;

// namespace ObjectOriented
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
            // Using Constructor 1
            // Student s1 = new Student("Samman", "A");
            // Console.WriteLine("Student 1:");
            // s1.DisplayInfo();

            // Console.WriteLine();

            // Using Constructor 2
            // Student s2 = new Student("Rameyy");
            // Console.WriteLine("Student 2:");
            // s2.DisplayInfo();


            // var IndexerExample = new IndexerExample();
            // IndexerExample.run();

            // var StaticExample = new StaticExample();
            // StaticExample.Run();

             // Student Example
            // var staticStudentExample = new StaticStudentExample.Program();
            // staticStudentExample.Run();

            // ElectricCar eCar = new ElectricCar("Tesla");
            // eCar.Start();
            // eCar.Charge();
            // eCar.Drive();
            // eCar.Insurance();
            // eCar.Maintenance();

            // Console.WriteLine();

            // PetrolCar pCar = new PetrolCar("Toyota");
            // pCar.Start();
            // pCar.FillPetrol();
            // pCar.Drive();
            // pCar.Insurance();
            // pCar.Maintenance();

            // Console.WriteLine();

            // Bike bike = new Bike("Yamaha");
            // bike.Start();
            // bike.Ride();
            // bike.Insurance();
            // bike.Maintenance();

            // Console.WriteLine();

            // Truck truck = new Truck("Volvo Truck");
            // truck.Start();
            // truck.LoadGoods();
            // truck.Insurance();
            // truck.Maintenance();

        //    var InterfaceExample = new InterfaceExample();
        //       InterfaceExample.Run();

//         OperatorOverLoadingExample example = new OperatorOverLoadingExample();
//         example.Run();
//     }
// }
// }





// using System;
// using System.Collections.Generic;
// using GenericExample;


// class Program
// {
//     static void Main(string[] args)
//     {
        // Create Generic DataStore for Product
        // DataStore<Product> store = new DataStore<Product>();

        // Add Products
        // store.Add(new Product("Laptop", 85000));
        // store.Add(new Product("Mobile", 30000));
        // store.Add(new Product("Mouse", 1200));
        // store.Add(new Product("Keyboard", 2500));
        // store.Add(new Product("Monitor", 22000));

        // Display All Products
        // Console.WriteLine("===== Product List =====\n");

        // List<Product> products = store.GetAll();

        // foreach (Product p in products)
        // {
        //     Console.WriteLine("Name  : " + p.Name);
        //     Console.WriteLine("Price : Rs. " + p.Price);
        //     Console.WriteLine();
        // }

        // Get Single Product
        // Product item = store.Get(2);

        // Console.WriteLine("===== Single Product =====");
        // Console.WriteLine(item.Name + " - Rs. " + item.Price);

        // var DelegateExample = new ObjectOriented.DelegateExample();
        // DelegateExample.run();

        // var MulticastDelegateExample = new ObjectOriented.MulticastDelegateExample();
        // MulticastDelegateExample.run();

       



//     }
// }


using System;

namespace ObjectOriented
{
    class Program
    {
        static void Main(string[] args)
        {
            YoutubeTask task = new YoutubeTask();
            task.Run();
        }
    }
}