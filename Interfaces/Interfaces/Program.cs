using System;
namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //interface new'lenemez!

            IPersonManager customerManager = new CustomerManager();
           
            IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager);
            projectManager.Add(new CustomerManager());
            projectManager.Add(new EmployeeManager());
            projectManager.Add(new InternManager());



        }
    }

    interface IPersonManager
    {
        //unimplemented operation
        void Add();
        void Update();
    }


    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri eklendi !");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi !");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel eklendi !");
        }

        void IPersonManager.Update()
        {
            Console.WriteLine("Personel güncellendi !");
        }
    }

    class InternManager : IPersonManager
    {
        void IPersonManager.Add()
        {
            Console.WriteLine("Stajyer eklendi !");
        }

        void IPersonManager.Update()
        {
            Console.WriteLine("Stajyer güncellendi !");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }

}