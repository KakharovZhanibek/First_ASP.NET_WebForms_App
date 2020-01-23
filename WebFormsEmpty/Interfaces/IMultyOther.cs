using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFormsEmpty.Interfaces
{
    interface IMultyOther<T> where T:class
    {
        IQueryable<T> GetAllByAll(int Id);
    }
}
