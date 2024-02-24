using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        void ICustomerDal.Add()
        {
            Console.WriteLine("Sql added");
        }

        void ICustomerDal.Delete()
        {
            Console.WriteLine("Sql deleted");
        }

        void ICustomerDal.Update()
        {
            Console.WriteLine("Sql updated");
        }
    }
    class MySqlCustomerDal : ICustomerDal
    {
        void ICustomerDal.Add()
        {
            Console.WriteLine("MySql added");
        }

        void ICustomerDal.Delete()
        {
            Console.WriteLine("MySql deleted");
        }

        void ICustomerDal.Update()
        {
            Console.WriteLine("MySql updated");
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)//böylece sistem bir veri tabanına bağlı kalmamış oldu interface'e bağlı
        {
            customerDal.Add();
        }
    }

}
