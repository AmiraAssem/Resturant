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
    public partial class Soup : UserControl
    {
        public Soup()
        {
            InitializeComponent();
        }

        private void order_Tomatosoup_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_Tomatosoup.Name);
            add.Show();
        }

        private void order_Potatosoup_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_Potatosoup.Name);
            add.Show();
        }

        private void order_Goulashsoup_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_Goulashsoup.Name);
            add.Show();
        }

        private void order_Chickensoup_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_Chickensoup.Name);
            add.Show();
        }

        private void order_Vegetablessoup_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_Vegetablessoup.Name);
            add.Show();
        }

        private void order_Currysoup_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_Currysoup.Name);
            add.Show();
        }
    }
}
