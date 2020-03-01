using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WMPLib;

namespace Restaurant_Project_Files_
{
    public partial class Home_user : Form
    {
        public Home_user()
        {
            InitializeComponent();
            homeimage img = new homeimage();
            Fixed_home_panel.Controls.Add(img);
            img.Dock = DockStyle.Fill;

        }
        private bool isCollapased;
       
        private void menu_btn_Click(object sender, EventArgs e)
        {
            if (fixed_pan.Width == 55)
            {

                Animated_panel.Visible = false;
                tap_panel.Visible = true;
                fixed_pan.Visible = false;
                fixed_pan.Width = 212;

                panel_animator.ShowSync(fixed_pan);
            }
            else
            {
                Animated_panel.Visible = true;
                tap_panel.Visible = false;
                fixed_pan.Visible = false;
                fixed_pan.Width = 55;
                panel_animator.ShowSync(fixed_pan);
            }
        }

        private void close_bt_Click(object sender, EventArgs e)
        {
            Application.Exit();
            XmlDocument doc = new XmlDocument();
            doc.Load("CustomersCart.xml");
            XmlElement root = doc.DocumentElement;
            root.RemoveAll();
            doc.Save("CustomersCart.xml");
            
        }

        private void login_imgbtn_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm("Login");
            l.Show();
            this.Hide();
        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            side.Height = bt_home.Height;
            side.Top = bt_home.Top;
            Fixed_home_panel.Controls.Clear();
            homeimage img = new homeimage();
            Fixed_home_panel.Controls.Add(img);
            img.Dock = DockStyle.Fill;
        }

        private void bt_menu_Click(object sender, EventArgs e)
        {
            menu_timer.Start();
            side.Height = 52;
            side.Top = DropDownMenu.Top;
            Fixed_home_panel.Controls.Clear();
            Fixed_home_panel.Visible = true;
            Menu_customer menu = new Menu_customer();
            Fixed_home_panel.Controls.Add(menu);
            menu.Dock = DockStyle.Fill;
        }

        private void fixed_pan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void home_imgbtn_Click(object sender, EventArgs e)
        {
            Home_user home = new Home_user();
            home.Show();
            this.Hide();
        }

        private void Home_user_Load(object sender, EventArgs e)
        {

        }

        private void slide_timer_Tick(object sender, EventArgs e)
        {
            //loadnextimg();
        }

        private void menu_timer_Tick(object sender, EventArgs e)
        {
            if (isCollapased)
            {
                DropDownMenu.Height += 10;
                if (DropDownMenu.Size == DropDownMenu.MaximumSize)
                {
                    menu_timer.Stop();
                    isCollapased = false;
                }
            }
            else
            {
                DropDownMenu.Height -= 10;
                if (DropDownMenu.Size == DropDownMenu.MinimumSize)
                {
                    menu_timer.Stop();
                    isCollapased = true;
                }
            }
        }

        private void Menu_Soup_Click(object sender, EventArgs e)
        {
            side.Height = 52;
            side.Top = DropDownMenu.Top;
            Fixed_home_panel.Controls.Clear();
            Fixed_home_panel.Visible = true;
            Soup menu = new Soup();
            Fixed_home_panel.Controls.Add(menu);
            menu.Dock = DockStyle.Fill;
        }
        //Menu_Salads button
        private void button6_Click(object sender, EventArgs e)
        {
            side.Height = 52;
            side.Top = DropDownMenu.Top;
            Fixed_home_panel.Controls.Clear();
            Fixed_home_panel.Visible = true;
            Salads menu = new Salads();
            Fixed_home_panel.Controls.Add(menu);
            menu.Dock = DockStyle.Fill;
        }
        //Menu_Sandwiches button 
        private void button4_Click(object sender, EventArgs e)
        {
            side.Height = 52;
            side.Top = DropDownMenu.Top;
            Fixed_home_panel.Controls.Clear();
            Fixed_home_panel.Visible = true;
            Sandwiches menu = new Sandwiches();
            Fixed_home_panel.Controls.Add(menu);
            menu.Dock = DockStyle.Fill;
        }
        // Menu_pizza button
        private void button2_Click(object sender, EventArgs e)
        {
            side.Height = 52;
            side.Top = DropDownMenu.Top;
            Fixed_home_panel.Controls.Clear();
            Fixed_home_panel.Visible = true;
            Pizza menu = new Pizza();
            Fixed_home_panel.Controls.Add(menu);
            menu.Dock = DockStyle.Fill;
        }

        private void Menu_meals_Click(object sender, EventArgs e)
        {
            side.Height = 52;
            side.Top = DropDownMenu.Top;
            Fixed_home_panel.Controls.Clear();
            Fixed_home_panel.Visible = true;
            meals menu = new meals();
            Fixed_home_panel.Controls.Add(menu);
            menu.Dock = DockStyle.Fill;
        }

        private void Menu_Dessert_Click(object sender, EventArgs e)
        {
            side.Height = 52;
            side.Top = DropDownMenu.Top;
            Fixed_home_panel.Controls.Clear();
            Fixed_home_panel.Visible = true;
            Dessert menu = new Dessert();
            Fixed_home_panel.Controls.Add(menu);
            menu.Dock = DockStyle.Fill;
        }

        private void Menu_cock_Click(object sender, EventArgs e)
        {
            side.Height = 52;
            side.Top = DropDownMenu.Top;
            Fixed_home_panel.Controls.Clear();
            Fixed_home_panel.Visible = true;
            Cocktails menu = new Cocktails();
            Fixed_home_panel.Controls.Add(menu);
            menu.Dock = DockStyle.Fill;
        }

        private void btn_cart_Click(object sender, EventArgs e)
        {
            side.Height = btn_cart.Height;
            side.Top = btn_cart.Top;
            Fixed_home_panel.Controls.Clear();
            Fixed_home_panel.Visible = true;
            User_cart cart = new User_cart();
            Fixed_home_panel.Controls.Add(cart);
            cart.Dock = DockStyle.Fill;
        }

        private void btn_offers_Click(object sender, EventArgs e)
        {
            side.Height = btn_offers.Height;
            side.Top = btn_offers.Top;
            Fixed_home_panel.Controls.Clear();
            Fixed_home_panel.Visible = true;
            offers offer = new offers();
            Fixed_home_panel.Controls.Add(offer);
            offer.Dock = DockStyle.Fill;
        }
    }
}
