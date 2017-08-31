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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            BusinessLogic.CheckLogin(userName,password);




        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            AfterRegister ar = new AfterRegister();
            ar.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginEntityDataSet.BankDetails' table. You can move, or remove it, as needed.
            this.bankDetailsTableAdapter.Fill(this.loginEntityDataSet.BankDetails);

        }
    }
}
