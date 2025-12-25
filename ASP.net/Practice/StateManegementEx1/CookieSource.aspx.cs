using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Example1
{
    public partial class CookieSource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnStore_Click(object sender, EventArgs e)
        {
            Response.Cookies["un"].Value = txtusername.Text;
            Response.Cookies["pwd"].Value = txtpass.Text;

            Response.Redirect("CookieDestination.aspx");
        }

        protected void BtnRedirect_Click(object sender, EventArgs e)
        {

        }
    }
}