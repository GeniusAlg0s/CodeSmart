using System;
using System.Collections.Generic;
using System.Text;

namespace fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        public  List<Order> Orders = new List<Order>();
        //public readonly List<Order> Orders = new List<Order>();


        public Customer(int id)
        {
            this.Id = id;
        }
        public Customer(int id, string name)
            :this(id)
        {
            this.Name = name;
        }
        public void Promote()
        {
            Orders = new List<Order>();
        }

    }
    
}
