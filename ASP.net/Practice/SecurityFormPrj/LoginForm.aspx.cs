using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SecurityFormPrj
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnlogin_Click(object sender, EventArgs e)
        {
            if (FormsAuthentication.Authenticate(Txtlogin.Text, Txtpass.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(Txtlogin.Text, false);
            }
            else
            {

                Lblmsg.Text = "invalid user name or password";
            }
        }
    }
}