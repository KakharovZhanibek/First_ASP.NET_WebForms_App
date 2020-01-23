using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsEmpty.Models;

namespace WebFormsEmpty.Interfaces
{
    interface IMultiService<T>
    {
        List<T> GetAll();
        IEnumerable<T> GetAll2();
        void Add(T item);
        T GetById(int Id);
        IEnumerable<T> GetByName(string Name);

        void Update_1(T item);
        void Update_2(T item,int Id);
        void Delete(int Id);
    }
}
