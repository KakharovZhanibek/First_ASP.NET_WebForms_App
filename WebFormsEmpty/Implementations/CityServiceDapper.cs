using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebFormsEmpty.Models;
using WebFormsEmpty.Interfaces;
using Dapper;
using System.Data;

namespace WebFormsEmpty.Implementations
{
    public class CityServiceDapper : GetConnection, IMultiService<City>,IMultyOther<City>
    {
        public void Add(City item)
        {
            dbCon.Execute("insert into City(CountryId,Name,Population)values(@CountryId,@Name,@Population)", new { CountryId = 1, Name = "SpainCity", Populaion = 200000 }, commandType: CommandType.Text);
        }

        public void Delete(int Id)
        {
            dbCon.Execute("delete from City where Id=@Id",Id,commandType:CommandType.Text);
        }

        public List<City> GetAll()
        {
            return dbCon.Query<City>("select * from City").ToList();
        }

        public IEnumerable<City> GetAll2()
        {
            return dbCon.Query<City>("select * from City").AsEnumerable();
        }

        public IQueryable<City> GetAllByAll(int Id)
        {
            return dbCon.Query<City>("select * from City where Id=@Id",new { Id=Id},commandType:CommandType.Text).ToList().AsQueryable();
        }

        public City GetById(int Id)
        {
            List<City> temp = dbCon.Query<City>("select * from City where Id= @Id", Id, commandType: CommandType.Text).ToList();
            return temp[0];
        }

        public IEnumerable<City> GetByName(string Name)
        {
            return dbCon.Query<City>("select * from City where Name=@Name",Name,commandType:CommandType.Text).AsEnumerable();
        }

        public void Update_1(City item)
        {
            dbCon.Query<City>("Update City set CountryId=@CountryId, Name=@Name Population=@Population where Id=@Id", new { CountryId=item.Id,Name=item.Name,Population=item.Population}, commandType: CommandType.Text).AsEnumerable();
        }

        public void Update_2(City item, int Id)
        {
            Console.WriteLine("tired");
        }
        
    }
}