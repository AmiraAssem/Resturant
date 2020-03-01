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
using System.Xml;

namespace Restaurant_Project_Files_
{
    public partial class Delivery : UserControl
    {
        List<DeliveryBoy> deliveryBoys = new List<DeliveryBoy>();
        List<Deliivery> delivery = new List<Deliivery>();
        public Delivery()
        {
            InitializeComponent();
            int count = 0;
            DGV_delivery.Rows.Clear();
            DGV_delivery.Refresh();
            if (File.Exists("Delivery.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Delivery.xml");
                XmlNodeList list = doc.GetElementsByTagName("Deliivery");
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList childerns = list[i].ChildNodes;
                    String Area_Code = childerns[0].InnerText;
                    XmlNodeList DeliverBoysID = childerns[1].ChildNodes[0].ChildNodes;
                    DGV_delivery.Rows.Add(new string[] { Area_Code });
                    DataGridViewCell DGV = new DataGridViewComboBoxCell();
                    for (int j = 0; j < DeliverBoysID.Count; j++)
                    {
                        ((DataGridViewComboBoxCell)DGV).Items.Add(DeliverBoysID[j].InnerText);
                    }
                    DGV_delivery.Rows[count].Cells[1] = DGV;
                    count++;

                }
            }
        }

        private void Delivery_Load(object sender, EventArgs e)
        {

        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            DGV_delivery.Rows.Clear();
            DGV_delivery.Refresh();
            int count = 0;
            XmlDocument doc = new XmlDocument();
            if (File.Exists("Delivery.xml"))
            {
                doc.Load("Delivery.xml");
                XmlNodeList area = null;
                XmlNodeList list = doc.GetElementsByTagName("Area_Code");
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].InnerText.Equals(txt_Area.Text))
                    {
                        area = list[i].ParentNode.ChildNodes;
                    }
                }
                String Area_Code = area[0].InnerText;
                DGV_delivery.Rows.Add(new string[] { Area_Code });
                DataGridViewCell dgv = new DataGridViewComboBoxCell();
                for (int i = 0; i < area[1].ChildNodes[0].ChildNodes.Count; i++)
                {
                    ((DataGridViewComboBoxCell)dgv).Items.Add(area[1].ChildNodes[0].ChildNodes[i].InnerText);
                }
                DGV_delivery.Rows[count].Cells[1] = dgv;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
