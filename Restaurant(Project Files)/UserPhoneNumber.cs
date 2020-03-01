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
   
    public partial class UserPhoneNumber : Form
    {
       public static String PhoneNumber;

        public UserPhoneNumber()
        {
            InitializeComponent();
         
           
        }

        private void UserPhoneNumber_Load(object sender, EventArgs e)
        {
            
        }
        

        private void btn_add_Click(object sender, EventArgs e)
        {
            PhoneNumber = UserPhoneNom.Text;
            this.Hide();

        }
    }
}
