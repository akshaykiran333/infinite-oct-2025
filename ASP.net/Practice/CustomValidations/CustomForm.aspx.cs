using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomValidations
{
    public partial class CustomForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Welcome to the Page");
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value=="")
            {
                args.IsValid = false;
            }
            else
            {
                if ((Convert.ToInt32(args.Value)>=18) && (Convert.ToInt32(args.Value)<=30))
                {
                    args.IsValid = true;
                }
                else
                    args.IsValid = false;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblmsg.Text = "Success Age is validated...";
                lblmsg.ForeColor = System.Drawing.Color.DarkGreen;
            }
            else
            {
                lblmsg.Text = "Validation Failed...";
                lblmsg.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}