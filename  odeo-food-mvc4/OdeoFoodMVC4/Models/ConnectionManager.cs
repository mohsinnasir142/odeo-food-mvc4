using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace OdeoFoodMVC4.Models
{
    public class ConnectionManager
    {
        public static SqlConnection getConnection()
        {
            return new SqlConnection(GetConnectionString());
        }

        private static string GetConnectionString()
        {

            //Where MYDBConnection is the connetion string that was set up in the web config file
            //return System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            return @"Data Source=GT026\SQLEXPRESS;Initial Catalog=aspnet-OdeoFoodMVC4-20140127141943;Persist Security Info=True;User ID=sa;Password=sasa";
        }

    }
}