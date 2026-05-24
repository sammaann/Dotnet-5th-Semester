using System;

namespace ObjectOriented
{
    // Common Interface
    interface IVehicle
    {
        void Insurance();
        void Maintenance();
    }

    // Electric Car Class
    class ElectricCar : IVehicle
    {
        public string Name;

        public ElectricCar(string name)
        {
            Name = name;
        }

        public void Start()
        {
            Console.WriteLine(Name + " is starting.");
        }

        public void Charge()
        {
            Console.WriteLine(Name + " is charging.");
        }

        public void Drive()
        {
            Console.WriteLine(Name + " is driving.");
        }

        public void Insurance()
        {
            Console.WriteLine(Name + " insurance checked.");
        }

        public void Maintenance()
        {
            Console.WriteLine(Name + " maintenance completed.");
        }
    }

    // Petrol Car Class
    class PetrolCar : IVehicle
    {
        public string Name;

        public PetrolCar(string name)
        {
            Name = name;
        }

        public void Start()
        {
            Console.WriteLine(Name + " is starting.");
        }

        public void FillPetrol()
        {
            Console.WriteLine(Name + " petrol filled.");
        }

        public void Drive()
        {
            Console.WriteLine(Name + " is driving.");
        }

        public void Insurance()
        {
            Console.WriteLine(Name + " insurance checked.");
        }

        public void Maintenance()
        {
            Console.WriteLine(Name + " maintenance completed.");
        }
    }

    // Bike Class
    class Bike : IVehicle
    {
        public string Name;

        public Bike(string name)
        {
            Name = name;
        }

        public void Start()
        {
            Console.WriteLine(Name + " is starting.");
        }

        public void Ride()
        {
            Console.WriteLine(Name + " is riding.");
        }

        public void Insurance()
        {
            Console.WriteLine(Name + " insurance checked.");
        }

        public void Maintenance()
        {
            Console.WriteLine(Name + " maintenance completed.");
        }
    }

    // Truck Class
    class Truck : IVehicle
    {
        public string Name;

        public Truck(string name)
        {
            Name = name;
        }

        public void Start()
        {
            Console.WriteLine(Name + " is starting.");
        }

        public void LoadGoods()
        {
            Console.WriteLine(Name + " is loading goods.");
        }

        public void Insurance()
        {
            Console.WriteLine(Name + " insurance checked.");
        }

        public void Maintenance()
        {
            Console.WriteLine(Name + " maintenance completed.");
        }
    }
}

