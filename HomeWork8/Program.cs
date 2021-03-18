using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace HomeWork8
{
    public enum CoffeeDrinks
    {
        Espresso,
        Americano,
        Cappuccino
    }

    public enum DrinkSize
    {
        small,
        standart,
        large
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Group { get; set; }

    }
    class Order
    {


        public Student Orderer { get; set; }
        public CoffeeDrinks Drink { get; set; }

        public DrinkSize Size { get; set; }



    }


    class Program
    {
        static public void AddOrder //adding order object both to stack and to queue
            (Queue<Order> ordersQueue, Stack<Order> ordersStack, Student orderer, CoffeeDrinks drink, DrinkSize cupsize)
        {
            Order order = new Order
            {
                Orderer = orderer,
                Drink = drink,
                Size = cupsize
            };

            Console.WriteLine($"{order.Orderer.FirstName} {order.Orderer.LastName} ordered a {order.Size} cup of {order.Drink}");
            ordersQueue.Enqueue(order);
            ordersStack.Push(order);
        }

        static public void CompleteOrderQueue  //extracting order from queue and some info
          (Queue<Order> ordersQueue)
        {
            Console.WriteLine();
            Order order = ordersQueue.Dequeue();
            Animate(order);
            Console.WriteLine($"{order.Orderer.FirstName} {order.Orderer.LastName} received {order.Drink}");
           

        }

        static public void CompleteOrderStack  //extracting order from stack and some info
         (Queue<Order> ordersQueue)
        {
            Console.WriteLine();
            Order order = ordersQueue.Dequeue();
            Animate(order);
            Console.WriteLine($"{order.Orderer.FirstName} {order.Orderer.LastName} received {order.Drink}");


        }

        static public void CompleteOrderStack
          (Stack<Order> ordersStack)
        {
            Console.WriteLine();
            Order order = ordersStack.Pop();
            Animate(order);
            Console.WriteLine($"{order.Orderer.FirstName} {order.Orderer.LastName} received {order.Drink}");


        }

        static public void Animate(Order order)
        {
            Console.WriteLine($"{order.Drink} in process");
            Console.WriteLine("0%____________________100%");
            Console.CursorTop -= 1;
            Console.CursorLeft = 2;
            Console.BackgroundColor = ConsoleColor.White;
            for (int i = 0; i < 20; i++)
            {
                Console.Write(" ");
                Thread.Sleep(50);
            }
            Console.ResetColor();
            Console.CursorTop += 1;
            Console.CursorLeft = 0;

        }




        static void Main(string[] args)



        {
            Student student1 = new Student() { FirstName = "Анастасия", LastName = "Береснева", Group = "21c1" };
            Student student2 = new Student() { FirstName = "Леонид", LastName = "Галайдин", Group = "21c1" };
            Student student3 = new Student() { FirstName = "Алина", LastName = "Галожина", Group = "21c1" };
            Student student4 = new Student() { FirstName = "Захар", LastName = "Титовец", Group = "21e1" };
            Student student5 = new Student() { FirstName = "Иван", LastName = "Горецкий", Group = "21e1" };
            Student student6 = new Student() { FirstName = "Андрей", LastName = "Романовский", Group = "21e1" };
            Student student7 = new Student() { FirstName = "Егор", LastName = "Бабаков", Group = "21e1" };

            Queue<Order> ordersQ = new Queue<Order>();
            Stack<Order> ordersS = new Stack<Order>();

            AddOrder(ordersQ, ordersS, student1, CoffeeDrinks.Espresso, DrinkSize.small);
            AddOrder(ordersQ, ordersS, student2, CoffeeDrinks.Cappuccino, DrinkSize.large);
            AddOrder(ordersQ, ordersS, student3, CoffeeDrinks.Americano, DrinkSize.standart);
            AddOrder(ordersQ, ordersS, student4, CoffeeDrinks.Americano, DrinkSize.standart);
            AddOrder(ordersQ, ordersS, student5, CoffeeDrinks.Americano, DrinkSize.standart);
            AddOrder(ordersQ, ordersS, student6, CoffeeDrinks.Espresso, DrinkSize.small);
            AddOrder(ordersQ, ordersS, student7, CoffeeDrinks.Cappuccino, DrinkSize.standart);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Order processing using Queue class");
            Console.WriteLine();
            Console.ResetColor();

            while (ordersQ.Count>0)
            {
            CompleteOrderQueue(ordersQ);
           
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("Order processing using Stack class");
            Console.WriteLine();
            Console.ResetColor();

            while (ordersS.Count > 0)
            {
                CompleteOrderStack(ordersS);

            }


            Console.ReadKey();





        }
    }
}
