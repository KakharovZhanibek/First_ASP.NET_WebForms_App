namespace WebFormsEmpty
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using WebFormsEmpty.Models;

    public class MyDb : DbContext
    {

        public MyDb()
            : base("name=MyDb")
        {
        }
        public DbSet<Country> Country{ get; set; }
     
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}