using System;

namespace Interfaces
{
    class Program
    { static void Main(string[] arg)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot(),
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }
    }

    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }

    interface ISalery
    {
        void GetSalery();
    }


    class Manager : IWorker, IEat, ISalery//bir class birden fazla interface implement edebilir
    {
        public void Work()
        {
            throw new NotImplementedException();
        }

        void IEat.Eat()
        {
            throw new NotImplementedException();
        }

        void ISalery.GetSalery()
        {
            throw new NotImplementedException();
        }
    }

    class Worker : IWorker,IEat
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}