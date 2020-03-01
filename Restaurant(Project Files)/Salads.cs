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
    public partial class Salads : UserControl
    {
        public Salads()
        {
            InitializeComponent();
        }

        private void order_salad_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_salad.Name);
            add.Show();
        }

        private void order_Greeksalad_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_Greeksalad.Name);
            add.Show();
        }

        private void order_Spicysalad_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_Spicysalad.Name);
            add.Show();
        }
    }
}
