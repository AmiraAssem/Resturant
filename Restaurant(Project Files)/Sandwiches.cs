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
    public partial class Sandwiches : UserControl
    {
        public Sandwiches()
        {
            InitializeComponent();
        }

        private void order_eggsandwich_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_eggsandwich.Name);
            add.Show();
        }

        private void order_Burger_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_Burger.Name);
            add.Show();
        }

        private void order_HotDog_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_HotDog.Name);
            add.Show();
        }
    }
}
