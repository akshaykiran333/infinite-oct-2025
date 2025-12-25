using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Example1
{
    public partial class CookieDestination : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGet_Click(object sender, EventArgs e)
        {
            lblname.Text = Request.Cookies["un"].Value.ToString();
            lblpass.Text = Request.Cookies["pwd"].Value.ToString();
        }
    }
}