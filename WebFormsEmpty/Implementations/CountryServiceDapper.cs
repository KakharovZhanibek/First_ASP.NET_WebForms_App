using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebFormsEmpty.Interfaces;
using WebFormsEmpty.Models;

namespace WebFormsEmpty.Implementations
{
    public class CountryServiceDapper :GetConnection,IMultiService<Country>
    {
        public void Add(Country country)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDb"].ConnectionString))
            {
                //db.Execute($"insert into (Name,Capital)values({country.Name},{country.Capital})", commandType: CommandType.Text);
                db.Execute($"insert into Country(Name,Capital)values(@Name,@Capital)", new { Name = country.Name, Capital = country.Capital }, commandType: CommandType.Text);
                //db.Execute("pCountryAdd", new { Name = country.Name, Capital = country.Capital }, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(int Id)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDb"].ConnectionString))
            {
                db.Execute($"delete from Country where id=@Id", Id, commandType: CommandType.Text);   
            }
        }

        public List<Country> GetAll()
        {
            return dbCon.Query<Country>("select * from Country", commandType: CommandType.Text).ToList();
        }

        public IEnumerable<Country> GetAll2()
        {
            return dbCon.Query<Country>("select * from Country", commandType: CommandType.Text).AsEnumerable();
        }

        public Country GetById(int Id)
        {
            List<Country> temp = dbCon.Query<Country>("select * from Country where Id= @Name", Id, commandType: CommandType.Text).ToList();
            return temp[0];
        }

        public IEnumerable<Country> GetByName(string Name)
        {
            return dbCon.Query<Country>("select * from Country where Name=@Name",
                Name, commandType: CommandType.Text).AsEnumerable();
        }

        public void Update_1(Country country)
        {
            //return dbCon.Query<Country>("Update * from Country where Name=@Name", Name, commandType: CommandType.Text).AsEnumerable();
        }

        public void Update_2(Country country, int Id)
        {
            throw new NotImplementedException();
        }
    }
}