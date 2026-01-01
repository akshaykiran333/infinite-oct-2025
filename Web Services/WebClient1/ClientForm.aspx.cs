using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient1
{
    public partial class ClientForm : System.Web.UI.Page
    {
        Infinite_Reference.WebInfiniteServiceSoapClient client=new Infinite_Reference.WebInfiniteServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Butnhello_Click(object sender, EventArgs e)
        {
            Lbl.Text = client.HelloWorld();

        }

        protected void Btnsayhello_Click(object sender, EventArgs e)
        {
            Lbl.Text = client.SayHello(txtname.Text);
        }

        protected void Btnsqu_Click(object sender, EventArgs e)
        {
            Lbl.Text=client.Squareroot(Convert.ToSingle(txtfnum.Text)).ToString();
        }
    }
}