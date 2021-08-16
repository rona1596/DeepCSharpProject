﻿using ProjetoCSharpProfundo02.Entities;
using System;

namespace ProjetoCSharpProfundo02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region[]

            #endregion

            #region[Exercise 03 Enumeration and Composition - 16082021 ]

            //Console.WriteLine("Enter client data: ");
            //Console.Write("Name: ");
            //string clientName = Console.ReadLine();
            //Console.Write("Email: ");
            //string email = Console.ReadLine();
            //Console.Write("Birth date (DD/MM/YYYY): ");
            //DateTime birthDate = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("Enter order data: ");
            //Console.Write("Status: ");
            //OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            //Client client = new Client(clientName, email, birthDate);
            //Order02 order = new Order02(DateTime.Now, status, client);

            //Console.Write("How many items to this order? ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"Enter #{i} item data:");
            //    Console.Write("Product name: ");
            //    string productName = Console.ReadLine();
            //    Console.Write("Product price: ");
            //    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //    Product product = new Product(productName, price);

            //    Console.Write("Quantity: ");
            //    int quantity = int.Parse(Console.ReadLine());

            //    OrderItem orderItem = new OrderItem(quantity, price, product);

            //    order.AddItem(orderItem);
            //}

            //Console.WriteLine();
            //Console.WriteLine("ORDER SUMMARY:");
            //Console.WriteLine(order);

            #endregion

            #region[Exercise 02 StringBuilder - 12082021 ]

            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");
            Post p1 = new Post(
                    DateTime.Parse("21/06/2018 13:05:44"),
                    "Traveling to New Zealand",
                    "I'm going to visit this wonderful country!",
                    12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");
            Post p2 = new Post(
                    DateTime.Parse("28/07/2018 23:14:19"),
                    "Good night guys",
                    "See you tomorrow",
                    5);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            #endregion
            
            #region[Exercise 01 - 12082021 ]

            //Console.Write("Enter department's name: ");
            //string deptName = Console.ReadLine();
            //Console.WriteLine("Enter worker data:");
            //Console.Write("Name: ");
            //string name = Console.ReadLine();
            //Console.Write("Level: (Junior/MidLevel/Senior): ");
            ////Convert in Object WorkerLevel
            //WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            //Console.Write("Base salary: ");
            //double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Department dept = new Department(deptName);
            //Worker worker = new Worker(name, level, baseSalary, dept);

            //Console.Write("How many contracts to this worker? ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"Enter #{i} contract data:");
            //    Console.Write("Date (DD/MM/YYYY): ");
            //    DateTime date = DateTime.Parse(Console.ReadLine());
            //    Console.Write("Value per hour: ");
            //    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    Console.Write("Duration (hours): ");
            //    int hours = int.Parse(Console.ReadLine());

            //    HourContract contract = new HourContract(date, valuePerHour, hours);
            //    worker.AddContract(contract);
            //}

            //Console.WriteLine();
            //Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            //string monthAndYear = Console.ReadLine();
            //int month = int.Parse(monthAndYear.Substring(0, 2));
            //int year = int.Parse(monthAndYear.Substring(3));
            //Console.WriteLine("Name : " + worker.Name);
            //Console.WriteLine("Department: " + worker.Department.Name);
            //Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

            #endregion

            #region[Initial - Enum]

            //Order order = new Order
            //{
            //    Id = 180,
            //    Moment = DateTime.Now,
            //    Status = OrderStatus.PendingPayment
            //};


            //Console.WriteLine(order);

            //string txt = OrderStatus.PendingPayment.ToString();

            ////Valor em string e converte para enum
            //OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            //Console.WriteLine(txt);
            //Console.WriteLine(os);

            #endregion
        }
    }
}
