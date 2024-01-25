using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class FromLogin : Form
    {
        public FromLogin()
        {
            InitializeComponent();
        }

        private void FromLogin_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toNV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormEmployees employees = new FormEmployees();
            this.Hide();
            employees.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormEmployees formEmployees = new FormEmployees();
            this.Hide();
            formEmployees.ShowDialog();
            this.Show();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            FormAdmin admin = new FormAdmin();
            this.Hide();
            admin.ShowDialog();
            this.Show();
        }
    }
}
