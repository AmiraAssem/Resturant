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
    public partial class Dessert : UserControl
    {
        public Dessert()
        {
            InitializeComponent();
        }

        private void order_cake_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_cake.Name);
            add.Show();
        }

        private void order_tarte_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_tarte.Name);
            add.Show();
        }

        private void order_Waffels_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_Waffels.Name);
            add.Show();
        }
    }
}
