using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Restaurant_Project_Files_
{
    public partial class Customers : UserControl
    {
        List<CustomerDetails> customers = new List<CustomerDetails>();
        public Customers()
        {
            InitializeComponent();
            if (File.Exists("Customers.xml"))
            {
                XmlSerializer ser = new XmlSerializer(customers.GetType());
                FileStream fs = new FileStream("Customers.xml", FileMode.Open);
                customers = (List<CustomerDetails>)ser.Deserialize(fs);
                fs.Close();
                DVG_customers.DataSource = customers;
            }

        }

        private void Customers_Load(object sender, EventArgs e)
        {

        }
    }
}
