using ElectricityMiniPrj.Asp_code;
using System;
using System.Web.UI;

namespace ElectricityMiniPrj
{
    public partial class AddBill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    
                    ElectricityBill bill = new ElectricityBill
                    {
                        ConsumerNumber = txtConsumerNo.Text.Trim(),  //trim-to remove space in txtbox content 
                        ConsumerName = txtConsumerName.Text.Trim(),
                        Units = int.Parse(txtUnits.Text.Trim())  
                    };

                    
                    ElectricityBoard board = new ElectricityBoard();
                    board.CalculateBill(bill);  
                    board.AddBill(bill);        

                    //BillValidator
                   
                    lblMsg.ForeColor = System.Drawing.Color.Green;
                    lblMsg.Text = $"Bill added successfully! Bill Amount: {bill.BillAmount}";

                    //clear form for next entry
                    txtConsumerNo.Text = "";
                    txtConsumerName.Text = "";
                    txtUnits.Text = "";
                }
                catch (FormatException fe)
                {
                    lblMsg.ForeColor = System.Drawing.Color.Red;
                    lblMsg.Text = fe.Message;  // Invalid Consumer Number
                }
                //catch (ArgumentException ae)
                //{
                //    lblMsg.ForeColor = System.Drawing.Color.Red;
                //    lblMsg.Text = ae.Message;  // Invalid Units
                //}
                catch (Exception ex)
                {
                    lblMsg.ForeColor = System.Drawing.Color.Red;
                    lblMsg.Text = "Error: " + ex.Message;
                }
            }
        }
    }
}
