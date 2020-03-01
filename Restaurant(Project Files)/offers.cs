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
    public partial class offers : UserControl
    {
        public offers()
        {
            InitializeComponent();
        }

        private void offers_Load(object sender, EventArgs e)
        {

        }

        private void order_burger_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.Burger_Offer.Name);
            add.Show();

        }

        private void order_grill_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.Grill_Offer.Name);
            add.Show();
        }

        private void order_pizza_Click(object sender, EventArgs e)
        {
             add_orderToCart add = new add_orderToCart(this.Pizza_Offer.Name);
            add.Show();
        }

        private void order_sushi_Click(object sender, EventArgs e)
        {

            add_orderToCart add = new add_orderToCart(this.Sushi_Offer.Name);
            add.Show();
        }

        private void order_san_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.sandwich_Offer.Name);
            add.Show();
        }

        private void order_pasta_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.Pasta_Offer.Name);
            add.Show();
        }
    }
}
