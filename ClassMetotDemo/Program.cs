using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();

            customer1.CustomerId = 1;
            customer1.CustomerName = "Elif";
            customer1.CustomerSurname = "Göçük";
            customer1.CustomerAge = 25;
            customer1.CustomerCity = "İstanbul";

            Customer customer2 = new Customer();

            customer2.CustomerId = 2;
            customer2.CustomerName = "Ömer";
            customer2.CustomerSurname = "Öncel";
            customer2.CustomerAge = 34;
            customer2.CustomerCity = "Ankara";

            Customer customer3 = new Customer();

            customer3.CustomerId = 3;
            customer3.CustomerName = "Ahsen";
            customer3.CustomerSurname = "Barış";
            customer3.CustomerAge = 18;
            customer3.CustomerCity = "İstanbul";

            Customer customer4 = new Customer();

            customer4.CustomerId = 4;
            customer4.CustomerName = "Zeynep";
            customer4.CustomerSurname = "Bilir";
            customer4.CustomerAge = 45;
            customer4.CustomerCity = "Kayseri";

            Customer customer5 = new Customer();

            customer5.CustomerId = 5;
            customer5.CustomerName = "Mehmet";
            customer5.CustomerSurname = "Kaçan";
            customer5.CustomerAge = 62;
            customer5.CustomerCity = "Şanlıurfa";

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4, customer5};


            foreach (Customer customer in customers)

            {
                Console.WriteLine(customer.CustomerId);
                Console.WriteLine(customer.CustomerName);
                Console.WriteLine(customer.CustomerSurname);
                Console.WriteLine(customer.CustomerAge);
                Console.WriteLine(customer.CustomerCity);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("-------Metotlar--------------");

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer2);
            customerManager.Delete(customer5);
            customerManager.Update(customer3);
            customerManager.ListAll(customer4);


            Console.ReadLine();

        }
        



    }
}
