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
    public partial class meals : UserControl
    {
        public meals()
        {
            InitializeComponent();
        }

        private void order_pasta_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_pasta.Name);
            add.Show();
        }

        private void order_grill_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_grill.Name);
            add.Show();
        }

        private void order_sushi_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_sushi.Name);
            add.Show();
        }
    }
}
