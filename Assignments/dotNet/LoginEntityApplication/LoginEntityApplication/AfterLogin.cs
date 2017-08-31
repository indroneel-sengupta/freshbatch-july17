using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginEntityApplication
{
    public partial class AfterLogin : Form
    {
        public string userName { get; set; }
        public string password { get; set; }
        public AfterLogin()
        {
            InitializeComponent();
        }
        public AfterLogin(string userName,string password):this()
        {
            this.userName = userName;
            this.password = password;
        }

        private void AfterLogin_Load(object sender, EventArgs e)
        {
            lblUserName.Text = "Welcome  " + this.userName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal amount= Convert.ToDecimal(txtAmount.Text);
            decimal? bal=  BusinessLogic.ClickDeposit(this.userName, this.password, amount);
            lblShowBalance.Text = "Your New Balance is" + bal;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(txtAmount.Text);
            decimal? bal = BusinessLogic.ClickWithdraw(this.userName, this.password, amount);
            lblShowBalance.Text = "Your New Balance is" + bal;
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void lblShowBalance_Click(object sender, EventArgs e)
        {

        }
    }
}
