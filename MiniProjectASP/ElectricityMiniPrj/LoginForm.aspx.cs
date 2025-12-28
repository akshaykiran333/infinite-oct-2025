using System;

namespace ElectricityMiniPrj
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "akshay" && txtPass.Text == "akshay333")
            {
                Session["Admin"] = "true";
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                lblMsg.Text = "Invalid Login Credentials";
            }
        }
    }
}
