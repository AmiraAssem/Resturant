using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Restaurant_Project_Files_
{
   
    public partial class Delivery_boy : UserControl
    {
        List<DeliveryBoy> deliveryBoys = new List<DeliveryBoy>();
        public Delivery_boy()
        {
            InitializeComponent();
            DVG_deliveryboy.Rows.Clear();
            DVG_deliveryboy.Refresh();
            if (File.Exists("DeliveryBoys.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("DeliveryBoys.xml");
                XmlNodeList listOfDeliveryBoys = doc.GetElementsByTagName("DeliveryBoy");
                for (int i = 0; i < listOfDeliveryBoys.Count; i++)
                {
                    XmlNodeList childerns = listOfDeliveryBoys[i].ChildNodes;
                    String name = childerns[0].InnerText;
                    String ID = childerns[1].InnerText;
                    String Phone = childerns[2].InnerText;
                    String Assigned_Area = childerns[3].InnerText;
                    String NumOfOrders = childerns[4].InnerText;
                    DVG_deliveryboy.Rows.Add(new string[] {name,ID,Phone,Assigned_Area,NumOfOrders});

                }
                XmlNodeList Area_list = doc.GetElementsByTagName("Assigned_Area");
                for (int c = 0; c < Area_list.Count; c++)
                {
                    int count = 0;
                    if (txt_Area.Items.Count == 0)
                    {
                        txt_Area.Items.Add(Area_list[c].InnerText);
                    }
                    else
                    {
                        for (int j = 0; j < txt_Area.Items.Count; j++)
                        {
                            if (!Area_list[c].InnerText.Equals(txt_Area.Items[j]))
                            {
                                count++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (count == txt_Area.Items.Count)
                        {
                            txt_Area.Items.Add(Area_list[c].InnerText);
                        }
                    }

                }

            }
           
        }

        private void btn_add_deliboy_Click(object sender, EventArgs e)
        {
            Add_DeliveryBoy add = new Add_DeliveryBoy();
            add.Show();
        }

        private void DVG_deliveryboy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Delivery_boy_Load(object sender, EventArgs e)
        {

        }

        private void display_Click(object sender, EventArgs e)
        {
            DVG_deliveryboy.Rows.Clear();
            DVG_deliveryboy.Refresh();
            int best = 0;       
            XmlDocument xmldoc = new XmlDocument();
            XmlNode Best_DeliverBoy = null;
            if (File.Exists("DeliveryBoys.xml"))
            {
                xmldoc.Load("DeliveryBoys.xml");
                XmlNodeList area = null;               
                XmlNodeList NomOfOrders = xmldoc.GetElementsByTagName("NumOfOrders");
                for (int i = 0; i < NomOfOrders.Count; i++)
                {
                    if (NomOfOrders[i].ParentNode.ChildNodes[3].InnerText.Equals(txt_Area.Text))
                    {
                        int orders = Convert.ToInt32(NomOfOrders[i].InnerText);
                        if (best < orders )
                        {
                            best = orders;
                            Best_DeliverBoy = NomOfOrders[i].ParentNode;
                        }
                    }
                }
               
            }
            if (Best_DeliverBoy != null)
            {

                String name = Best_DeliverBoy.ChildNodes[0].InnerText;
                String ID = Best_DeliverBoy.ChildNodes[1].InnerText;
                String Phone = Best_DeliverBoy.ChildNodes[2].InnerText;
                String Assigned_Area = Best_DeliverBoy.ChildNodes[3].InnerText;
                String NumOfOrders = Best_DeliverBoy.ChildNodes[4].InnerText;
                DVG_deliveryboy.Rows.Add(new string[] { name, ID, Phone, Assigned_Area, NumOfOrders });
            }

        }
    }
}
