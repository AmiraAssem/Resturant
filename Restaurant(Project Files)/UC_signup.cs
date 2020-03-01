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
    public partial class UC_signup : UserControl
    {
        public UC_signup()
        {
            InitializeComponent();
        }

        private void cancel_bt_Click(object sender, EventArgs e)
        {
            Control fixedpanel = this.Parent;
            this.Hide();
            //fixedpanel.Controls.Clear();
            UC_Login login = new UC_Login();
            fixedpanel.Controls.Add(login);
        }

        private void UC_signup_Load(object sender, EventArgs e)
        {

        }

        private void bt_Register_Click(object sender, EventArgs e)
        {
            if (tx_name.Text != "" && tx_username.Text != "" && tx_password.Text != "" && confirm_tx.Text != "" && tx_email.Text != "" && tx_phone.Text != "")
            {
                if (tx_password.Text == confirm_tx.Text)
                {
                    if (tx_email.Text.Contains("@"))
                    {

                        Home home = new Home();
                        home.ShowDialog();
                        Form form = this.FindForm();
                        form.Close();
                    }
                    else
                    {
                        MessageBox.Show("please enter your email");
                    }

                }
                else if (tx_password.Text != confirm_tx.Text)
                {

                    MessageBox.Show("confirm password does't match password");
                }
            }

            else
            {
                MessageBox.Show("All data must be filled");
            }
            
                

            
        }
    }
}
