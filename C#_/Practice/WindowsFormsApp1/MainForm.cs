using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form1
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender,EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.LoginSuccess += OnLoginSuccess;
            login.ShowDialog();
        }   
        private void OnLoginSuccess(object sender, LoginEventArgs e)
        {
            MessageBox.Show($"welcome, {e.Username}!","Event Triggerd", MesssageBoxButtons.OK, MessageBoxIcon.Information);
            lblUserWelcome.Text = $"Welcome,{e.Username}!";
        }
    }
}
