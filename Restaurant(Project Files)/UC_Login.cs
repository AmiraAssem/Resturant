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
    public partial class UC_Login : UserControl
    {
        public UC_Login()
        {
            InitializeComponent();
        }

        private void bt_signup_Click(object sender, EventArgs e)
        {
            Control fixedpanel = this.Parent;
            fixedpanel.Controls.Clear();
            UC_signup signup = new UC_signup();
            fixedpanel.Controls.Add(signup);

        }

        private void bt_signup_Click_1(object sender, EventArgs e)
        {

            Control fixedpanel = this.Parent;
            fixedpanel.Controls.Clear();
            UC_signup signup = new UC_signup();
            fixedpanel.Controls.Add(signup);
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text != "" && txt_password.Text != "")
            {
                if (txt_Username.Text.Equals("admin") || txt_Username.Text.Equals("Admin"))
                {
                    if (txt_password.Text.Equals("admin")) {
                        Home home = new Home();
                        home.Show();
                        Form form = this.FindForm();
                        form.Close();
                    }
                }
                else if (txt_Username.Text.Equals("user") || txt_Username.Text.Equals("User"))
                {
                    
                    Home_user home = new Home_user();
                    home.ShowDialog();
                    Form form = this.FindForm();
                    form.Close();
                }
            }
            else if (txt_Username.Text == "")
            {
                MessageBox.Show("please enter your username");

            }
            else
            {
                MessageBox.Show("please enter your password");
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
