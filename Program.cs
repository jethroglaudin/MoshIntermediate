using System;

namespace Mosh_Intermediate
{

    class MainClass
    {
        static void Main(string[] args)
        {

            var customer = new Customer(1, "John"); // customer is of type Customer

            var order = new Order();
            customer.Orders.Add(order);
            
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

        }
    }
}
