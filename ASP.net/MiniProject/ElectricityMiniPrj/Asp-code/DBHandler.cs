using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ElectricityMiniPrj.Asp_code
{
    public static class DBHandler
    {
        public static SqlConnection GetConnection()  

        {

            try

            {
                string conStr = ConfigurationManager .ConnectionStrings["EBConnection"].ConnectionString;
                return new SqlConnection(conStr);
            }

            catch (Exception ex)

            {

                throw new Exception("Database connection failed", ex);
            }

        }

    }
}