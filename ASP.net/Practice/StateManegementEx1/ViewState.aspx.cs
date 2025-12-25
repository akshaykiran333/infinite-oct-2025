using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Example1
{
    public partial class ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnStore_Click(object sender, EventArgs e)
        {
        ViewState["uname"]=txtusername.Text;
            ViewState["pass"]=txtpass.Text;
            txtusername.Text = "";
            txtpass.Text = string.Empty;
        }

        protected void BtnLoad_Click(object sender, EventArgs e)
        {
            lblmessage.Text = "Your Name is : " + ViewState["uname"].ToString() +
                "and your password is:" + ViewState["pass"].ToString();
        }

        protected void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}