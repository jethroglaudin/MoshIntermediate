using System;

namespace Mosh_Intermediate
{


    class MainClass
    {
        static void Main(string[] args)
        {
            var customer = new CustomerF(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote();

            Console.WriteLine(customer.Orders.Count);
            
        }

    }
}
