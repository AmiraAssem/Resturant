using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Restaurant_Project_Files_
{
    public partial class Add_DeliveryBoy : Form
    {
        List<DeliveryBoy> deliveryBoys = new List<DeliveryBoy>();
        List<Deliivery> delivery = new List<Deliivery>();
        public Add_DeliveryBoy()
        {
            InitializeComponent();
            if (File.Exists("DeliveryBoys.xml"))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<DeliveryBoy>));
                FileStream fs = new FileStream("DeliveryBoys.xml", FileMode.Open);
                deliveryBoys = (List<DeliveryBoy>)ser.Deserialize(fs);
                fs.Close();
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            int Orders = 0;

            DeliveryBoy boy = new DeliveryBoy(delBoy_name.Text, Txt_ID.Text, delBoy_phone.Text, delBoy_Area.Text, Orders);
            deliveryBoys.Add(boy);
            XmlSerializer s = new XmlSerializer(typeof(List<DeliveryBoy>));
            FileStream fs = new FileStream("DeliveryBoys.xml", FileMode.OpenOrCreate);
            s.Serialize(fs, deliveryBoys);
            fs.Close();
            MessageBox.Show("Added");
            this.Hide();
        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
