using System.Collections.Generic;

namespace Mosh_Intermediate
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;
            
        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
            : this() // specify the other constructors to pass control too
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
    }
}
