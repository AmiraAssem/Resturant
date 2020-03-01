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
    public partial class Cocktails : UserControl
    {
        public Cocktails()
        {
            InitializeComponent();
        }

        private void order_Juice_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_Juice.Name);
            add.Show();
        }

        private void order_smoothie_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_smoothie.Name);
            add.Show();
        }

        private void order_milkshake_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_milkshake.Name);
            add.Show();
        }
    }
}
