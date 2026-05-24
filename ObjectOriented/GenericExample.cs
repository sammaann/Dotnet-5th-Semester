using System;
using System.Collections.Generic;

namespace GenericExample
{
    // Generic Class
    public class DataStore<T>
    {
        // List to store items
        private List<T> items = new List<T>();

        // Add Item
        public void Add(T item)
        {
            items.Add(item);
        }

        // Get Item by Index
        public T Get(int index)
        {
            return items[index];
        }

        // Get All Items
        public List<T> GetAll()
        {
            return items;
        }
    }

    // Product Class
    public class Product
    {
        // Properties
        public string Name { get; set; } = "";
        public double Price { get; set; }

        // Constructor
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}