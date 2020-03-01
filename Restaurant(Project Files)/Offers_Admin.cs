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
    public partial class Offers_Admin : UserControl
    {
        public Offers_Admin()
        {
            InitializeComponent();
        }

        private void Burger_Offer_Click(object sender, EventArgs e)
        {
            Edit_menu add = new Edit_menu(this.Burger_Offer.Name);
            add.Show();
        }

        private void Grill_Offer_Click(object sender, EventArgs e)
        {
            Edit_menu add = new Edit_menu(this.Grill_Offer.Name);
            add.Show();
        }

        private void Pizza_Offer_Click(object sender, EventArgs e)
        {
            Edit_menu add = new Edit_menu(this.Pizza_Offer.Name);
            add.Show();
        }

        private void Pasta_Offer_Click(object sender, EventArgs e)
        {
            Edit_menu add = new Edit_menu(this.Pasta_Offer.Name);
            add.Show();
        }

        private void sandwich_Offer_Click(object sender, EventArgs e)
        {
            Edit_menu add = new Edit_menu(this.sandwich_Offer.Name);
            add.Show();
        }

        private void Sushi_Offer_Click(object sender, EventArgs e)
        {
            Edit_menu add = new Edit_menu(this.Sushi_Offer.Name);
            add.Show();
        }
    }
}
