using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebFormsEmpty.Interfaces;
using WebFormsEmpty.Models;

namespace WebFormsEmpty.Implementations
{
    public class CountryService : IMultiService<Country>
    {
        private Repos repos;

        public CountryService()
        {
            repos = new Repos();
        }
        public void Add(Country country)
        {
            Repos.Repo.Add(country);
        }
        

        public void Delete(int Id)
        {
            if (Repos.Repo.Exists(e => e.Id == Id))
            {
                Repos.Repo.Remove(Repos.Repo.FirstOrDefault(f => f.Id == Id));
            }
        }

        public List<Country> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Country> GetAll2()
        {
            throw new NotImplementedException();
        }

        public Country GetById(int Id)
        {
            return Repos.Repo.FirstOrDefault(f => f.Id==Id); 
        }

        public IEnumerable<Country> GetByName(string Name)
        {
            return Repos.Repo.Where(w => w.Name == Name);
        }

        public void Update_1(Country country)
        {
            var sourceCountry = Repos.Repo.FirstOrDefault(f => f.Id == country.Id);
            if (sourceCountry != null)
            {
                sourceCountry.Name = country.Name;
                sourceCountry.Capital = country.Name;
            }
        }

        public void Update_2(Country country, int Id)
        {
            var c = GetById(Id);
            if (c != null)
            {
                c.Name = country.Name;
                c.Capital = country.Capital;
            }
        }

      

        public void Update_3(Country country)
        {
            var c = (from p in Repos.Repo
                     where p.Id == country.Id
                     select p).SingleOrDefault();
            if (c != null)
            {
                c.Name = country.Name;
                c.Capital = country.Capital;
            }
        }
    }
}