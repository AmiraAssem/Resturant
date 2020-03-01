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
using System.IO;

namespace Restaurant_Project_Files_
{
    public partial class Chart : UserControl
    {
        public Chart()
        {
            InitializeComponent();
            XmlDocument doc = new XmlDocument();
            doc.Load("DeliveryBoys.xml");
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

        private void Chart_Load(object sender, EventArgs e)
        {

        }

        private void display_Click(object sender, EventArgs e)
        {
            this.Area_Chart.Series["NomOfOrders"].Points.Clear();
            if (File.Exists("DeliveryBoys.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("DeliveryBoys.xml");
                XmlNodeList delivery_boys = doc.GetElementsByTagName("Assigned_Area");
                for (int i = 0; i < delivery_boys.Count; i++)
                {
                    if (delivery_boys[i].InnerText.Equals(txt_Area.Text))
                    {
                        String DeliveryBoyID = delivery_boys[i].ParentNode.ChildNodes[1].InnerText;
                        int NomOfOrders = Convert.ToInt32(delivery_boys[i].ParentNode.ChildNodes[4].InnerText);
                        this.Area_Chart.Series["NomOfOrders"].Points.AddXY(DeliveryBoyID , NomOfOrders);

                    }
                }

            }
        }
    }
}
