using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsEmpty.Models;

namespace WebFormsEmpty.Interfaces
{
    interface ICountryService
    {
        List<Country> GetAll();
        IEnumerable<Country> GetAll2();
        void Add(Country country);
        Country GetById(int Id);
        IEnumerable<Country> GetByName(string Name);

        void Update_1(Country country);
        void Update_2(Country country,int Id);
        void Delete(int Id);
    }
}
