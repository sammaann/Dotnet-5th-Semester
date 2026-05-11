using System;

public struct Product
{
    public int Id;
    public string Name;
    public string Category;
    public double Price;
    public int StockQuantity;
    public string SupplierEmail;
    public double Rating;
    public double DiscountPercentage;

    public Product(int id, string name, string category, double price,
                   int stockQuantity, string supplierEmail,
                   double rating, double discountPercentage)
    {
        Id = id > 0 ? id : 0;
        Name = name;
        Category = category;
        Price = price;
        StockQuantity = stockQuantity;
        SupplierEmail = supplierEmail;
        Rating = rating;
        DiscountPercentage = discountPercentage;
    }

    public string FullProductInfo()
    {
        return Name + " | " + Category + " | Price: " + Price;
    }

    public double PriceAfterDiscount()
    {
        return Price - (DiscountPercentage / 100 * Price);
    }

    public string RatingStatus()
    {
        if (Rating >= 4.5) return "Excellent";
        else if (Rating >= 3.0) return "Good";
        else if (Rating >= 1.0) return "Average";
        else return "Poor";
    }
}