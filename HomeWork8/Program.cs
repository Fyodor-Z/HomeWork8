using System;

namespace HomeWork8
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Group { get; set; }

    }
    class Order
    {
        public enum CoffeeDrinks
        {
            Espresso,
            Americano,
            Cappuccino
        }

        public Student Orderer { get; set; }
        public CoffeeDrinks Drink { get; set; }


    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
