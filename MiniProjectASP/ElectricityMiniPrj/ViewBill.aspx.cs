using ElectricityMiniPrj.Asp_code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElectricityMiniPrj
{
    public partial class ViewBill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnRetrieve_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    int numberOfBills = int.Parse(txtNumberOfBills.Text.Trim());

                    ElectricityBoard board = new ElectricityBoard();
                    List<ElectricityBill> bills = board.Generate_N_BillDetails(numberOfBills);
                    

                    if (bills != null && bills.Count > 0)
                    {
                        gvBills.DataSource = bills;
                        gvBills.DataBind();         //Grid view Id
                        gvBills.Visible = true;
                        lblMsg.Text = $"{bills.Count} bills retrieved successfully.";
                        lblMsg.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        gvBills.Visible = false;
                        lblMsg.Text = "No bills found.";
                    }
                }
                catch (Exception ex)
                {
                    lblMsg.Text = "Error: " + ex.Message;
                    gvBills.Visible = false;
                }
            }
        }

        protected void gvBills_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}