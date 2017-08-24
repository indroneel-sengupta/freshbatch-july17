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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDemoDataSet.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.loginDemoDataSet.Login);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text;
            
            Login l = new Login();
            bool checkLogin = l._Login(userName,password);
            if (checkLogin)
            {
                Main mw = new WindowsFormDemo.Main(userName);
                mw.ShowDialog();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
