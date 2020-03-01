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
    public partial class Menu_customer : UserControl
    {
        public Menu_customer()
        {
            InitializeComponent();
        }

        private void home_imgbtn_Click(object sender, EventArgs e)
        {
            Control fixed_panel = this.Parent;
            fixed_panel.Visible = false;
        }
        private int imgnum = 1;
       
        private void order_burger_Click(object sender, EventArgs e)
        {
        }

        private void order_pizza_Click(object sender, EventArgs e)
        {
           
        }

        private void order_san_Click(object sender, EventArgs e)
        {
           
        }

        private void order_soup_Click(object sender, EventArgs e)
        {
            
        }

        private void order_snacks_Click(object sender, EventArgs e)
        {
           
        }

        private void order_baked_Click(object sender, EventArgs e)
        {
           
        }

        private void order_cock_Click(object sender, EventArgs e)
        {
        }

        private void order_coffee_Click(object sender, EventArgs e)
        {
           
        }

        private void order_dessert_Click(object sender, EventArgs e)
        {
          
        }

        private void order_Rice_Click(object sender, EventArgs e)
        {
         
        }

        private void Fixed_home_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer_Home_Tick(object sender, EventArgs e)
        {
           
        }

        private void Menu_customer_Load(object sender, EventArgs e)
        {

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

        private void order_Waffels_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_Waffels.Name);
            add.Show();
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

        private void order_Currysoup_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_Currysoup.Name);
            add.Show();
        }

        private void order_Vegetablessoup_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_Vegetablessoup.Name);
            add.Show();
        }

        private void order_Chickensoup_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_Chickensoup.Name);
            add.Show();
        }

        private void order_Goulashsoup_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_Goulashsoup.Name);
            add.Show();
        }

        private void order_Potatosoup_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_Potatosoup.Name);
            add.Show();
        }

        private void order_Tomatosoup_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_Tomatosoup.Name);
            add.Show();
        }

        private void order_HotDog_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_HotDog.Name);
            add.Show();
        }

        private void order_Burger_Click_1(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_Burger.Name);
            add.Show();
        }

        private void order_eggsandwich_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_eggsandwich.Name);
            add.Show();
        }

        private void order_Cheesepizza_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_Cheesepizza.Name);
            add.Show();
        }

        private void order_Italianpizza_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_Italianpizza.Name);
            add.Show();
        }

        private void order_Garlicpizza_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_Garlicpizza.Name);
            add.Show();
        }

        private void order_sushi_Click(object sender, EventArgs e)
        {
            add_orderToCart add = new add_orderToCart(this.order_sushi.Name);
            add.Show();
        }

        private void order_grill_Click(object sender, EventArgs e)
        {

            add_orderToCart add = new add_orderToCart(this.order_grill.Name);
            add.Show();
        }

        private void order_pasta_Click(object sender, EventArgs e)
        {

            add_orderToCart add = new add_orderToCart(this.order_pasta.Name);
            add.Show();
        }
    }
}
