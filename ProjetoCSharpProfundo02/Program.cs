using ProjetoCSharpProfundo02.Entities;
using ProjetoCSharpProfundo02.Entities.Enums;
using System;

namespace ProjetoCSharpProfundo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 180,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };


            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            //Valor em string e converte para enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
