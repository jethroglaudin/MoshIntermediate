using System.Collections.Generic;

namespace Mosh_Intermediate
{
    public class CustomerF
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();

        public CustomerF(int id)
        {
            this.Id = id;
        }

        public CustomerF(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            
            //...
        }
    }
}
