using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDI.Cases
{
    public interface IGenericRepository<T> where T : class
    {
        void Adcionar(T obj);
        //void Adcionar();
    }

    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        //public void Adcionar()
        //{
        //}

        public void Adcionar(T obj)
        {
        }
    }
}
