using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace Restaurant_Project_Files_
{ 
    public partial class Edit_menu : Form
    {
        List<Food> foodList = new List<Food>();
        public Edit_menu(String type)
        {
            InitializeComponent();
            if (File.Exists("Menu.xml"))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Food>));
                FileStream fs = new FileStream("Menu.xml", FileMode.Open);
                foodList = (List<Food>)ser.Deserialize(fs);
                fs.Close();
            }

            if (type.Equals("order_Burger"))
            {
                order_id.Text = ("Burger_");
                order_price.Text = ("$30");
            }
            if (type.Equals("order_grill"))
            {
                order_id.Text = ("GRILL_1");
                order_price.Text = ("$23");
            }
            if (type.Equals("order_pasta"))
            {
                order_id.Text = ("PASTA_1");
                order_price.Text = ("$29");
            }

            if (type.Equals("order_Garlicpizza"))
            {
                order_id.Text = ("Pizza_Garlic");
                order_price.Text = ("$45");
            }
            if (type.Equals("order_Cheesepizza"))
            {
                order_id.Text = ("Pizza_Cheese");
                order_price.Text = ("$45");
            }
            if (type.Equals("order_Italianpizza"))
            {
                order_id.Text = ("Pizza_Italian");
                order_price.Text = ("$45");
            }
           

            if (type.Equals("order_eggsandwich"))
            {
                order_id.Text = ("EggSandwich_");
                order_price.Text = ("$25");
            }
            if (type.Equals("order_sushi"))
            {
                order_id.Text = ("SUSHI_1");
                order_price.Text = ("$50");
            }
            if (type.Equals("order_HotDog"))
            {
                order_id.Text = ("Hotdog_");
                order_price.Text = ("$20");
            }

            if (type.Equals("order_Tomatosoup"))
            {
                order_id.Text = ("SOUP_Tomato");
                order_price.Text = ("$13");
            }
            if (type.Equals("order_Potatosoup"))
            {
                order_id.Text = ("SOUP_Potato");
                order_price.Text = ("$10");
            }
            if (type.Equals("order_Goulashsoup"))
            {
                order_id.Text = ("SOUP_Gaulash");
                order_price.Text = ("$19");
            }
            if (type.Equals("order_Chickensoup"))
            {
                order_id.Text = ("SOUP_Chicken");
                order_price.Text = ("$15");
            }
            if (type.Equals("order_Vegetablessoup"))
            {
                order_id.Text = ("SOUP_Vegetables");
                order_price.Text = ("$12");
            }
            if (type.Equals("order_Currysoup"))
            {
                order_id.Text = ("SOUP_Curry");
                order_price.Text = ("$13");
            }

            if (type.Equals("order_salad"))
            {
                order_id.Text = ("SALad_");
                order_price.Text = ("$10");
            }
            if (type.Equals("order_Spicysalad"))
            {
                order_id.Text = ("SALad_Spicy");
                order_price.Text = ("$10");
            }
            if (type.Equals("order_Greeksalad"))
            {
                order_id.Text = ("SALad_Greek");
                order_price.Text = ("$10");
            }

            if (type.Equals("order_tarte"))
            {
                order_id.Text = ("TARTE_1");
                order_price.Text = ("$30");
            }
            if (type.Equals("order_cake"))
            {
                order_id.Text = ("CAKE_1");
                order_price.Text = ("$14");
            }
            if (type.Equals("order_Waffels"))
            {
                order_id.Text = ("Waffels_");
                order_price.Text = ("$20");
            }

            if (type.Equals("order_Juice"))
            {
                order_id.Text = ("juice_1");
                order_price.Text = ("$13");
            }
            if (type.Equals("order_smoothie"))
            {
                order_id.Text = ("smoothie_1");
                order_price.Text = ("$13");
            }
            if (type.Equals("order_milkshake"))
            {
                order_id.Text = ("milkshake_1");
                order_price.Text = ("$13");
            }

            if (type.Equals("Grill_Offer"))
            {
                order_id.Text = ("GR_Offer");
                order_price.Text = ("$24");
            }
            if (type.Equals("Burger_Offer"))
            {
                order_id.Text = ("BR_Offer");
                order_price.Text = ("$19.5");

            }
            if (type.Equals("Pizza_Offer"))
            {
                order_id.Text = ("P_Offer");
                order_price.Text = ("$33.75");
            }
            if (type.Equals("Pasta_Offer"))
            {
                order_id.Text = ("PAS_Offer");
                order_price.Text = ("$20.5");

            }
            if (type.Equals("sandwich_Offer"))
            {
                order_id.Text = ("SAND_Offer");
                order_price.Text = ("$22.5");

            }
            if (type.Equals("Sushi_Offer"))
            {
                order_id.Text = ("SUSHI_Offer");
                order_price.Text = ("$27.5");
            }
        }

        private void Edit_menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            String id = order_id.Text;
            String price = order_price.Text;
            String quantity = order_qty.Text;
            XmlDocument doc = new XmlDocument();
            if (!File.Exists("Menu.xml"))
            {
                Food food = new Food(id, price, quantity);
                foodList.Add(food);
                XmlSerializer s = new XmlSerializer(typeof(List<Food>));
                FileStream fs = new FileStream("Menu.xml", FileMode.Create);
                s.Serialize(fs, foodList);
                fs.Close();
            }


           else if (File.Exists("Menu.xml"))
           {
                //load menu file and get id foreach item to edit it’s Quantity 
                doc.Load("Menu.xml");
                XmlNodeList Foodlist_IDs = doc.GetElementsByTagName("ID");
                bool found = false;
                XmlNode parent = null;
                for (int i = 0; i < Foodlist_IDs.Count; i++)
                {
                    String value = Foodlist_IDs[i].InnerText;
                    if (value == order_id.Text)
                    {
                        parent = Foodlist_IDs[i].ParentNode;
                        found = true;
                        break;
                    }
                }
                // if id is found we can edit it’s Quantity  
                if (found)
                {
                    parent.ChildNodes[2].InnerText =quantity ;
                    doc.Save("Menu.xml");
                }
                // if not found add a new item to menu
                else
                {
                    Food food = new Food(id, price, quantity);
                    foodList.Add(food);
                    XmlSerializer s = new XmlSerializer(typeof(List<Food>));
                    FileStream fs = new FileStream("Menu.xml", FileMode.Open);
                    s.Serialize(fs, foodList);
                    fs.Close();
                }

               
               
           }
            MessageBox.Show("Done");
            this.Hide();
        }

        private void order_id_OnValueChanged(object sender, EventArgs e)
            {

            }

        private void order_price_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
