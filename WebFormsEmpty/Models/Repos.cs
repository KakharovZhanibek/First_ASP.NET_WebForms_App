using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsEmpty.Models
{
    public class Repos
    {
        public static List<Country> Repo;
        public Repos()
        {
            Repo = new List<Country>()
             {
                 new Country(){Id=1,Name="Kazakhstan",Capital="Astana"},
                 new Country(){Id=2,Name="USA",Capital="Washington"},
                 new Country(){Id=3,Name="Italy",Capital="Rome"},
                 new Country(){Id=3,Name="Norway",Capital="Oslo"},
                 new Country(){Id=3,Name="Japan",Capital="Tokyo"}
             };
        }
    }
}