using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 0011234;
            customer1.Name = "Barış";
            customer1.Surname = "GÜL";
            customer1.Birthday = "22.02.1998";



            Customer customer2 = new Customer();
            customer2.Id = 4532156;
            customer2.Name = "Merdan";
            customer2.Surname = "YILMAZ";
            customer2.Birthday = " 16.10.2000";


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            Console.WriteLine("------------------------------------");

            CustomerManager customerManager1 = new CustomerManager();
            customerManager1.Delete(customer1);
            customerManager1.Delete(customer2);

            
        }
    }
}
