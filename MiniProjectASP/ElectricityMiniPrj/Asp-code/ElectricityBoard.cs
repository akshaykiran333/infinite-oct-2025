using ElectricityMiniPrj.Asp_code;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ElectricityMiniPrj
{
    public class ElectricityBoard
    {
        // Calculate bill based on units consumed
        public void CalculateBill(ElectricityBill ebill)
        {
            int units = ebill.Units;
            double amount = 0;

            if (units <= 100)
                amount = 0;
            else if (units <= 300)
                amount = (units - 100) * 1.5;
            else if (units <= 600)
                amount = 200 * 1.5 + (units - 300) * 3.5;
            else if (units <= 1000)
                amount = 200 * 1.5 + 300 * 3.5 + (units - 600) * 5.5;
            else
                amount = 200 * 1.5 + 300 * 3.5 + 400 * 5.5 + (units - 1000) * 7.5;

            ebill.BillAmount = amount;
        }

        // Add bill to database
        public void AddBill(ElectricityBill ebill)
        {
            using (SqlConnection con = DBHandler.GetConnection())
            {
                con.Open();
                string query = "INSERT INTO ElectricityBill (ConsumerNumber, ConsumerName, Units, BillAmount) " +
                               "VALUES(@cno, @cname, @units, @bill)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@cno", ebill.ConsumerNumber);
                    cmd.Parameters.AddWithValue("@cname", ebill.ConsumerName);
                    cmd.Parameters.AddWithValue("@units", ebill.Units);
                    cmd.Parameters.AddWithValue("@bill", ebill.BillAmount);

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        
        public List<ElectricityBill> Generate_N_BillDetails(int num)
        {
            List<ElectricityBill> bills = new List<ElectricityBill>();

            using (SqlConnection con = DBHandler.GetConnection())
            {
                con.Open();
                // ORDER BY ConsumerNumber DESC 
                string query = $"SELECT TOP {num} ConsumerNumber, ConsumerName, Units, BillAmount " +
               "FROM ElectricityBill ORDER BY ConsumerNumber DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    try
                    {
                        while (reader.Read())
                        {
                            ElectricityBill ebill = new ElectricityBill
                            {
                                ConsumerNumber = reader["ConsumerNumber"].ToString(),
                                ConsumerName = reader["ConsumerName"].ToString(),
                                Units = Convert.ToInt32(reader["Units"]),
                                BillAmount = Convert.ToDouble(reader["BillAmount"])
                            };
                            bills.Add(ebill);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            return bills;
        }
    }
}
