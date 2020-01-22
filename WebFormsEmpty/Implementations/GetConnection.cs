using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebFormsEmpty.Implementations
{
    public class GetConnection
    {
        protected IDbConnection dbCon
        {
            get
            {
                return new SqlConnection(ConfigurationManager.ConnectionStrings["MyDb"].ConnectionString);
            }
        }
    }
}