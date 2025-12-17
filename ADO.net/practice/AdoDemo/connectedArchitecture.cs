using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdoDemo
{
    public class connectedArchitecture
    {
        public void getTranscations(DateTime d1, DateTime d2) 
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=Ado_net;server=(localdb)\\MSSQLLocalDB");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_GetEmployeesByDOJ", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@d1", d1);
                cmd.Parameters.AddWithValue("@d2", d2);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine($"ID: {dr["EmpID"]} , Name: {dr["EmpName"]}  ,  Salary: {dr["Salary"]}  ,  DOJ: {dr["DateOfJoin"]}");
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);

            }
            finally
            {
                con.Close();
            }



        }
    }
}
