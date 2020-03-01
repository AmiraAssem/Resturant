using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Project_Files_
{
    public partial class Pizza : UserControl
    {
        public Pizza()
        {
            InitializeComponent();
        }

        private void order_Garlicpizza_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_Garlicpizza.Name);
            add.Show();
        }

        private void order_Italianpizza_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_Italianpizza.Name);
            add.Show();
        }

        private void order_Cheesepizza_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_Cheesepizza.Name);
            add.Show();
        }
    }
}
