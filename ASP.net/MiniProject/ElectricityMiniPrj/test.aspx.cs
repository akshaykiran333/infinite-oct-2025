using ElectricityMiniPrj.Asp_code;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElectricityMiniPrj
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try

            {

                SqlConnection con = DBHandler.GetConnection();

                con.Open();

                Button1.Text = "✅ Database connection successful";

                Button1.ForeColor = System.Drawing.Color.Green;

                con.Close();

            }

            catch (Exception ex)

            {

                Button1.Text = "❌ Database connection failed<br/>" + ex.Message;

                Button1.ForeColor = System.Drawing.Color.Red;

            }

        }
    }
}