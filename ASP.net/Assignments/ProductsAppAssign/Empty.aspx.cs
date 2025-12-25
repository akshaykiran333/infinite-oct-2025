using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductsAppAssign
{
    public partial class Empty : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Dproducts.Items.Add(new ListItem("Select Product", "0"));
                Dproducts.Items.Add(new ListItem("Mobile", "Mobile"));
                Dproducts.Items.Add(new ListItem("Laptop", "Laptop"));
                Dproducts.Items.Add(new ListItem("Airpods", "Airpods"));
            }

        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Dproducts.SelectedValue == "Mobile")
            {
                Image1.ImageUrl = "https://fdn2.gsmarena.com/vv/pics/apple/apple-iphone-11-2.jpg";
            }
            else if (Dproducts.SelectedValue == "Laptop")
            {
                Image1.ImageUrl = "https://images.unsplash.com/photo-1611186871348-b1ce696e52c9?fm=jpg&q=60&w=3000&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NHx8YXBwbGUlMjBsYXB0b3B8ZW58MHx8MHx8fDA%3D";
            }
            else if (Dproducts.SelectedValue == "Airpods")
            {
                Image1.ImageUrl = "https://png.pngtree.com/thumb_back/fh260/background/20240403/pngtree-airpods-with-a-white-a-background-image_15647397.jpg";
            }
            else
            {
                Image1.ImageUrl = "";
                Label1.Text = "";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Dproducts.SelectedValue == "Mobile")
            {
                Label1.Text = "Price: ₹45,000";
            }
            else if (Dproducts.SelectedValue == "Laptop")
            {
                Label1.Text = "Price: ₹70,000";
            }
            else if (Dproducts.SelectedValue == "Airpods")
            {
                Label1.Text = "Price: ₹8,000";
            }
            else
            {
                Label1.Text = "Please select a product";
            }
        }


        
    }
}