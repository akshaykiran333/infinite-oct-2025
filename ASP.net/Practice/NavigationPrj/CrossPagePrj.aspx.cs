using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NavigationPrj
{
    public partial class CrossPagePrj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null && PreviousPage.IsCrossPagePostBack)
            {
                TextBox txtname = (TextBox)PreviousPage.FindControl("txtName");
                LblName.Text = "Welcome" + txtname.Text;
            }
            else
            {
                Response.Redirect("CrossPageIndex.aspx");
            }


        }
    }
}