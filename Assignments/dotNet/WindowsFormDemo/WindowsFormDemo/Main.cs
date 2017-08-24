using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormDemo
{
    public partial class Main : Form
    {
        private string _userName;

        public Main()
        {
            InitializeComponent();
        }

        public Main(string username) : this()
        {
            _userName = username;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblUserName.Text = "Welcome " + _userName;
        }

        private void Main_Move(object sender, EventArgs e)
        {

        }

        private void Main_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void Main_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login l = new WindowsFormDemo.Login();
            l.SaveData(txtUsername.Text,txtPassword.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Login l = new WindowsFormDemo.Login();
            l.Update(txtUsername.Text, txtPassword.Text,Convert.ToDecimal(txtAmount.Text));
        }
    }
}
