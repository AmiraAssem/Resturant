using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Project_Files_
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            homeimage img = new homeimage();
            Fixed_home_panel.Controls.Add(img);
            img.Dock = DockStyle.Fill;

        }
        
       
        private void close_bt_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

       
        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void timer_Home_Tick(object sender, EventArgs e)
        {
           // loadnextimg();
        }

        private void timer_home_fixedpic_Tick(object sender, EventArgs e)
        {
            
        }

        private void menu_btn_Click_1(object sender, EventArgs e)
        {
            if (fixed_pan.Width == 50)
            {
                Animated_panel.Visible = false;
             //   Animated_pan.Visible = false;
                tap_panel.Visible = true;
                fixed_pan.Visible = false;
                fixed_pan.Width = 200;
                panel_animator.ShowSync(fixed_pan);
               

               
            }
            else
            {
              //  Animated_pan.Visible = true;
                Animated_panel.Visible = true;
                tap_panel.Visible = false;
                fixed_pan.Visible = false;
               
                fixed_pan.Width = 50;
                panel_animator.ShowSync(fixed_pan);
               

            }
        }

        private void bt_home_Click_1(object sender, EventArgs e)
        {
            side.Height = bt_home.Height;
            side.Top = bt_home.Top;
            Fixed_home_panel.Visible = true;
            Fixed_home_panel.Controls.Clear();
            homeimage img = new homeimage();
            Fixed_home_panel.Controls.Add(img);
            img.Dock = DockStyle.Fill;

        }
       
        private void login_imgbtn_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm("Login");
            l.Show();
            this.Hide();
           
        }

        private void home_imgbtn_Click(object sender, EventArgs e)
        {
            Home_user home = new Home_user();
            home.Show();
            this.Hide();
        }
       
        bool isCollapased;
        private void menu_timer_Tick(object sender, EventArgs e)
        {
            
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            side.Height = btn_menu.Height;
            side.Top = btn_menu.Top;
            Fixed_home_panel.Controls.Clear();
            Fixed_home_panel.Visible = true;
            Menu_Admin menu = new Menu_Admin();
            Fixed_home_panel.Controls.Add(menu);
            menu.Dock = DockStyle.Fill;
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            side.Height = btn_order.Height;
            side.Top = btn_order.Top;
            Fixed_home_panel.Controls.Clear();
            Fixed_home_panel.Visible = true;
            Delivery_boy deliver = new Delivery_boy();
            Fixed_home_panel.Controls.Add(deliver);
            deliver.Dock = DockStyle.Fill;
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            side.Height = btn_customers.Height;
            side.Top = btn_customers.Top;
            Fixed_home_panel.Controls.Clear();
            Fixed_home_panel.Visible = true;
            Customers customer = new Customers();
            Fixed_home_panel.Controls.Add(customer);
            customer.Dock = DockStyle.Fill;
        }

        private void btn_offers_Click(object sender, EventArgs e)
        {
            side.Height = btn_menu.Height;
            side.Top = btn_offers.Top;
            Fixed_home_panel.Controls.Clear();
            Fixed_home_panel.Visible = true;
            Offers_Admin menu = new Offers_Admin();
            Fixed_home_panel.Controls.Add(menu);
            menu.Dock = DockStyle.Fill;
        }

        private void btn_delivery_Click(object sender, EventArgs e)
        {
            side.Height = btn_delivery.Height;
            side.Top = btn_delivery.Top;
            Fixed_home_panel.Controls.Clear();
            Fixed_home_panel.Visible = true;
            Delivery delivery = new Delivery();
            Fixed_home_panel.Controls.Add(delivery);
            delivery.Dock = DockStyle.Fill;
        }

        private void Chart_btn_Click(object sender, EventArgs e)
        {
            side.Height = btn_delivery.Height;
            side.Top = Chart_btn.Top;
            Fixed_home_panel.Controls.Clear();
            Fixed_home_panel.Visible = true;
            Chart chart = new Chart();
            Fixed_home_panel.Controls.Add(chart);
            chart.Dock = DockStyle.Fill;
        }
    }
}
