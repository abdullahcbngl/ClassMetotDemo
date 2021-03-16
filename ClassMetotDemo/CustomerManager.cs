using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name+" "+customer.Surname+" "+"added");

        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname +" " + "deleted");
        }
    }
}
