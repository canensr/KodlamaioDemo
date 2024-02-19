using KodlamaioDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.Business.Abstracts
{
    public interface IGenericService<T>
    {
        List<T> GetAll();
        void Add(T t);
        void Update(T t);
        void Delete(T t);
    }
}
