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
    public partial class homeimage : UserControl
    {
        public homeimage()
        {
            InitializeComponent();

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
        private void slideimg_Click(object sender, EventArgs e)
        {

        }

        private void timer_Home_Tick(object sender, EventArgs e)
        {
            loadnextimg();
        }
    }
}
