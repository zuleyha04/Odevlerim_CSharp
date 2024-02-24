using System;
namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Uppdate();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Uppdate();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Züleyha";
            customer.LastName = "Akbaş";

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "Ankara",
                FirstName="Aslı",
                LastName="Akbaş"
            };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }

    }
}

