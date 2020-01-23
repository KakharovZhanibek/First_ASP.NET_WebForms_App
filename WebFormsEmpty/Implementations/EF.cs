using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using WebFormsEmpty.Interfaces;

namespace WebFormsEmpty.Models
{
    public class CountryServiceEF : IMultiService<Country>
    {
        MyDb myDb;

        public CountryServiceEF()
        {
            myDb = new MyDb();
        }
        public void Add(Country country)
        {
            myDb.Country.Add(country);
            myDb.SaveChanges();
        }

        public void Delete(int Id)
        {
            if (myDb.Country.FirstOrDefault(f => f.Id == Id)!=null)
            {
                myDb.Country.Remove(myDb.Country.FirstOrDefault(f => f.Id == Id));
            }
            myDb.SaveChanges();
        }

        public List<Country> GetAll()
        {
            return myDb.Country.ToList();
        }

        public IEnumerable<Country> GetAll2()
        {
            return myDb.Country.AsEnumerable();
        }

        public Country GetById(int Id)
        {
            return myDb.Country.FirstOrDefault(f => f.Id == Id);
        }

        public IEnumerable<Country> GetByName(string Name)
        {
            return myDb.Country.Where(w => w.Name == Name).AsEnumerable();
        }

        public void Update_1(Country country)
        {
            var sourceCountry =myDb.Country.FirstOrDefault(f => f.Id == country.Id);
            if (sourceCountry != null)
            {
                sourceCountry.Name = country.Name;
                sourceCountry.Capital = country.Name;
            }
            myDb.SaveChanges();
        }

        public void Update_2(Country country, int Id)
        {
            var c = GetById(Id);
            if (c != null)
            {
                c.Name = country.Name;
                c.Capital = country.Capital;
            }
            myDb.SaveChanges();
        }
        public void Update_3(Country country)
        {
            var c = (from p in myDb.Country
                     where p.Id == country.Id
                     select p).SingleOrDefault();
            if (c != null)
            {
                c.Name = country.Name;
                c.Capital = country.Capital;
            }
            myDb.SaveChanges();
        }
    }
}