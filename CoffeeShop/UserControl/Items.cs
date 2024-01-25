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
    public partial class Items : UserControl
    {
        public Items()
        {
            InitializeComponent();
        }

        private void Items_Click(object sender, EventArgs e)
        {
            if(!checkchoose.Visible)
            {
                checkchoose.Visible = true;
                btncheck.Visible = true;
            }
            else
            {
                checkchoose.Visible = false;
                btncheck.Visible = false;
            }
        }

        private void checkchoose_Click(object sender, EventArgs e)
        {
            if (!checkchoose.Visible)
            {
                checkchoose.Visible = true;
                btncheck.Visible = true;
            }
            else
            {
                checkchoose.Visible = false;
                btncheck.Visible = false;
            }
        }
    }
}
