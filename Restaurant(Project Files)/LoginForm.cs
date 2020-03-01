using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Project_Files_
{
    public partial class LoginForm : Form
    {
        public LoginForm(String Type)
        {
            
            InitializeComponent();

            UC_Login Login = new UC_Login();
            UC_signup Register = new UC_signup();

            fixedpanel.Controls.Clear();
            if (Type.Equals("Login"))
                fixedpanel.Controls.Add(Login);
            else
                fixedpanel.Controls.Add(Register);



        }

        private int imgnum = 1;
        private void loadnextimg()
        {
            if (imgnum == 11)
            {
                imgnum = 1;
            }
            slideimg.ImageLocation = string.Format(@"images\{0}.jpg", imgnum);
            imgnum++;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void slide_timer_Tick(object sender, EventArgs e)
        {
            loadnextimg();
        }

        private void slideimg_Click(object sender, EventArgs e)
        {

        }
    }
}
