using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("New customer is Added :  " + customer.CustomerName + " " + customer.CustomerSurname + " / " + customer.CustomerAge);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("New customer is Deleted : " + customer.CustomerName + " " + customer.CustomerSurname + " / " + customer.CustomerAge);
        
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("New customer is Updated : " + customer.CustomerName + " " + customer.CustomerSurname + " / " + customer.CustomerAge);
        }
        public void ListAll(Customer customer)
        { 
            Console.WriteLine("New customers is ListAlled : " + customer.CustomerName + " " + customer.CustomerSurname + " / " + customer.CustomerAge);
            
            Console.ReadLine();
        }
       

    }
}
