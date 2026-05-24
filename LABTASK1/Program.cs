using System;
using ObjectOriented;
class Program
{
    static void Main()
    {
        

    // {
    //     int id = 0, stock = 0;
    //     double price = 0, rating = 0, discount = 0;

    //     Console.Write("Enter Id: ");
    //     int.TryParse(Console.ReadLine(), out id);

    //     Console.Write("Enter Name: ");
    //     string name = Capitalize(Console.ReadLine());

    //     Console.Write("Enter Category: ");
    //     string category = Capitalize(Console.ReadLine());

    //     Console.Write("Enter Price: ");
    //     double.TryParse(Console.ReadLine(), out price);

    //     Console.Write("Enter Stock Quantity: ");
    //     int.TryParse(Console.ReadLine(), out stock);

    //     Console.Write("Enter Supplier Email: ");
    //     string email = Console.ReadLine();

    //     Console.Write("Enter Rating (1-5): ");
    //     double.TryParse(Console.ReadLine(), out rating);

    //     Console.Write("Enter Discount Percentage: ");
    //     double.TryParse(Console.ReadLine(), out discount);

    //     Product p = new Product(id, name, category, price, stock, email, rating, discount);

    //     Console.WriteLine("\n--- Product Info ---");
    //     Console.WriteLine(p.FullProductInfo());
    //     Console.WriteLine("Price After Discount: " + p.PriceAfterDiscount());
    //     Console.WriteLine("Rating Status: " + p.RatingStatus());
    // }

    // static string Capitalize(string text)
    // {
    //     if (string.IsNullOrEmpty(text))
    //         return "Unknown";

    //     return char.ToUpper(text[0]) + text.Substring(1).ToLower();
    
    //  var task2 = new Task2();
    //  task2.Run();


         Task3 task3 = new Task3();
        task3.run();


    }
}
