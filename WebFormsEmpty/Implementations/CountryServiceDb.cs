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
    public class CountryServiceDb : IMultiService<Country>
    {
        public void Add(Country country)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager
               .ConnectionStrings["MyDb"]
               .ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"insert into Country(Name,Capital)Values('{country.Name}','{country.Capital}')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        public void Delete(int Id)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager
               .ConnectionStrings["MyDb"]
               .ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"delete from Country where id = {Id}", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }


        #region SqlDataReader
        //public List<Country> GetAll()
        //{
        //    List<Country> result = new List<Country>();
        //    using (SqlConnection conn = new SqlConnection(ConfigurationManager
        //      .ConnectionStrings["MyDb"]
        //      .ConnectionString))
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand($"select * from Country", conn);
        //        SqlDataReader sdr = cmd.ExecuteReader();
        //        while (sdr.Read())
        //        {
        //            result.Add(new Country()
        //            {
        //                Id = Convert.ToInt32(sdr["Id"].ToString()),
        //                Name = sdr["Name"].ToString(),
        //                Capital = sdr["Capital"].ToString()
        //            });
        //        }
        //        conn.Close();

        //    }
        //    return result;
        //}
        #endregion

        #region SqlDataAdapter
        //public List<Country> GetAll()
        //{
        //    DataTable dt = new DataTable();
        //    List<Country> result = new List<Country>();
        //    using (SqlConnection conn = new SqlConnection(ConfigurationManager
        //      .ConnectionStrings["MyDb"]
        //      .ConnectionString))
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand($"select * from Country", conn);
        //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //        adapter.Fill(dt);

        //        foreach (DataRow item in dt.Rows)
        //        {
        //            result.Add(new Country()
        //            {
        //                Id = Convert.ToInt32(item["Id"].ToString()),
        //                Name = item["Name"].ToString(),
        //                Capital= item["Capital"].ToString()
        //            });
        //        }
        //        conn.Close();
        //        cmd.Dispose();
        //    }
        //    return result;
        //}
        #endregion

        public List<Country> GetAll()
        {
            List<Country> result = new List<Country>();
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager
              .ConnectionStrings["MyDb"]
              .ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"select * from Country", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);

                result = ds.Tables[0].AsEnumerable()
                    .Select(s => new Country
                    {
                        Id = s.Field<int>("Id"),
                        Name = s.Field<string>("Name"),
                        Capital = s.Field<string>("Capital")
                    }).ToList();
                conn.Close();
                cmd.Dispose();
            }
            return result;
        }
        public IEnumerable<Country> GetAll2()
        {
            IEnumerable<Country> result;
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager
              .ConnectionStrings["MyDb"]
              .ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"select * from Country", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);

                result = ds.Tables[0].AsEnumerable()
                    .Select(s => new Country
                    {
                        Id = s.Field<int>("Id"),
                        Name = s.Field<string>("Name"),
                        Capital = s.Field<string>("Capital")
                    }).ToList();
                conn.Close();
                cmd.Dispose();
            }
            return result;
        }

        public Country GetById(int Id)
        {
            Country country = new Country();
            
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager
              .ConnectionStrings["MyDb"]
              .ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"select * from Country where Id={Id}", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
              
                foreach (DataRow item in dt.Rows)
                {
                    country.Id = Convert.ToInt32(item["Id"].ToString());
                    country.Name = item["Name"].ToString();
                    country.Capital = item["Capital"].ToString();
                    break;
                }

                conn.Close();
                cmd.Dispose();
            }
            return country;
        }

        public IEnumerable<Country> GetByName(string Name)
        {
            throw new NotImplementedException();
        }

        public void Update_1(Country country)
        {
            throw new NotImplementedException();
        }

        public void Update_2(Country country, int Id)
        {
            throw new NotImplementedException();
        }
    }
}