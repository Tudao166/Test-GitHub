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
    public partial class FormAdmin : Form
    {
        FormEmployees employees;
        public FormAdmin()
        {
            InitializeComponent();
        }
        bool checkMenu = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(checkEmploye == true)
            {
                employe.Start();
            }
            if(!checkMenu)
            {
                pnmenu.Width += 10;
                if(pnmenu.Width >= 130)
                {
                    menu.Stop();
                    checkMenu = true;
                }
            }
            else
            {
                pnmenu.Width -= 10;
                if (pnmenu.Width <= 48)
                {
                    menu.Stop();
                    checkMenu = false;
                }
            }
            
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
           checkMenu = (pnmenu.Width >= 130) ? true : false;
            menu.Start();
        }
        bool checkEmploye = false;
        private void timeep_Tick(object sender, EventArgs e)
        {
            if(!checkEmploye)
            {
                pnsubmenu.Height += 10;
                if( pnsubmenu.Height >= 90)
                {
                    employe.Stop();
                    checkEmploye = true;
                }
            }
            else
            {
                pnsubmenu.Height -= 10;
                if (pnsubmenu.Height <= 46)
                {
                    employe.Stop();
                    checkEmploye = false;
                }
            }
        }

        private void btnemploye_Click(object sender, EventArgs e)
        {
    
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            checkEmploye = (pnsubmenu.Height >= 90) ? true : false;
            if(pnmenu.Width >= 130)
            {
                employe.Start();
            }
        }
    }
}
