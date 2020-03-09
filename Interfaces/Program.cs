using System;

namespace Testability
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);
            Console.WriteLine("Hello World!");
        }
    }
}
