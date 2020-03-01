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
    public partial class add_orderToCart : Form
    {
        List<CustomerCart> customers = new List<CustomerCart>();
        List<food> foods = new List<food>();
        List<Food> menu = new List<Food>();
        public add_orderToCart(String type)
        {
            if (File.Exists("Menu.xml"))
            {
                XmlSerializer s = new XmlSerializer(typeof(List<Food>));
                FileStream f = new FileStream("Menu.xml", FileMode.Open);
                menu = (List<Food>)s.Deserialize(f);
                f.Close();
            }
            if (File.Exists("CustomersCart.xml"))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<CustomerCart>));
                FileStream fs = new FileStream("CustomersCart.xml", FileMode.Open);
                customers = (List<CustomerCart>)ser.Deserialize(fs);
                fs.Close();
            }     

            InitializeComponent();
            if (type.Equals("order_Burger"))
            {
                order_id.Text = ("Burger_");


            }
            if (type.Equals("order_eggsandwich"))
            {
                order_id.Text = ("EggSandwich_");


            }
            if (type.Equals("order_HotDog"))
            {
                order_id.Text = ("Hotdog_");


            }

           
            if (type.Equals("order_Garlicpizza"))
            {
                order_id.Text = ("Pizza_Garlic");

            }
            if (type.Equals("order_Cheesepizza"))
            {
                order_id.Text = ("Pizza_Cheese");

            }
            if (type.Equals("order_Italianpizza"))
            {
                order_id.Text = ("Pizza_Italian");

            }

            if (type.Equals("order_pasta"))
            {
                order_id.Text = ("PASTA_1");

            }
            if (type.Equals("order_grill"))
            {
                order_id.Text = ("GRILL_1");

            }
            if (type.Equals("order_sushi"))
            {
                order_id.Text = ("SUSHI_1");
            }

            if (type.Equals("order_Tomatosoup"))
            {
                order_id.Text = ("SOUP_Tomato");

            }
            if (type.Equals("order_Potatosoup"))
            {
                order_id.Text = ("SOUP_Potato");

            }
            if (type.Equals("order_Goulashsoup"))
            {
                order_id.Text = ("SOUP_Gaulash");

            }
            if (type.Equals("order_Chickensoup"))
            {
                order_id.Text = ("SOUP_Chicken");

            }
            if (type.Equals("order_Vegetablessoup"))
            {
                order_id.Text = ("SOUP_Vegetables");

            }
            if (type.Equals("order_Currysoup"))
            {
                order_id.Text = ("SOUP_Curry");

            }

            if (type.Equals("order_salad"))
            {
                order_id.Text = ("SALad_");

            }
            if (type.Equals("order_Spicysalad"))
            {
                order_id.Text = ("SALad_Spicy");

            }
            if (type.Equals("order_Greeksalad"))
            {
                order_id.Text = ("SALad_Greek");

            }

            if (type.Equals("order_tarte"))
            {
                order_id.Text = ("TARTE_1");

            }
            if (type.Equals("order_cake"))
            {
                order_id.Text = ("CAKE_1");

            }
            if (type.Equals("order_Waffels"))
            {
                order_id.Text = ("Waffels_");

            }

            if (type.Equals("order_Juice"))
            {
                order_id.Text = ("juice_1");

            }
            if (type.Equals("order_smoothie"))
            {
                order_id.Text = ("smoothie_1");

            }
            if (type.Equals("order_milkshake"))
            {
                order_id.Text = ("milkshake_1");

            }
          
           
            if (type.Equals("Grill_Offer"))
            {
                order_id.Text = ("GR_Offer");
            }
            if (type.Equals("Burger_Offer"))
            {
                order_id.Text = ("BR_Offer");


            }
            if (type.Equals("Pizza_Offer"))
            {
                order_id.Text = ("P_Offer");
            }
            if (type.Equals("Pasta_Offer"))
            {
                order_id.Text = ("PAS_Offer");

            }
            if (type.Equals("sandwich_Offer"))
            {
                order_id.Text = ("SAND_Offer");

            }
            if (type.Equals("Sushi_Offer"))
            {
                order_id.Text = ("SUSHI_Offer");
            }
        }

        private void add_order_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            
            Double TotalPurchased = 0 ;
            String ID = order_id.Text;
            String Total_Price = order_price.Text;
            Double total_Price = Convert.ToDouble(Total_Price);
            String Quantity = qt_txt.Text;
            int quantity = Convert.ToInt32(qt_txt.Text);
            food order = new food(ID, total_Price, quantity);
            foods.Add(order);
            TotalPurchased = order.price;
            XmlDocument doc = new XmlDocument();
            doc.Load("Menu.xml");
            XmlNodeList check = doc.GetElementsByTagName("ID");
            for (int i = 0; i < check.Count; i++)
            {
                String food_id = check[i].InnerText;
                if (food_id == order_id.Text)
                {
                    int qty = Convert.ToInt32(check[i].ParentNode.ChildNodes[2].InnerText);
                    if (qty < quantity)
                    {
                        MessageBox.Show("sorry there are not enough quantity");
                        this.Hide();
                    }
                    else
                    {
                        if (!File.Exists("CustomersCart.xml"))
                        {                            
                            CustomerCart customer = new CustomerCart(TotalPurchased);  
                            customer.listofFood = new List<food>(foods);
                            customers.Add(customer);
                            XmlSerializer s = new XmlSerializer(customers.GetType());
                            FileStream fs = new FileStream("CustomersCart.xml", FileMode.Create);
                            s.Serialize(fs, customers);
                            fs.Close();
                        }
                        else
                        {
                            doc.Load("CustomersCart.xml");
                            XmlNodeList Cart = doc.GetElementsByTagName("CustomerCart");
                            if (Cart[0] != null)
                            {
                                XmlElement parent = doc.CreateElement("food");
                                XmlElement child = doc.CreateElement("id");
                                child.InnerText = ID;
                                parent.AppendChild(child);
                                child = doc.CreateElement("price");
                                child.InnerText = Total_Price;
                                parent.AppendChild(child);
                                child = doc.CreateElement("Quantity");
                                child.InnerText = Quantity;
                                parent.AppendChild(child);
                                XmlNode root = Cart[0].ChildNodes[0];
                                root.AppendChild(parent);
                                TotalPurchased = Convert.ToDouble(Cart[0].ChildNodes[1].InnerText);
                                Double purchase = total_Price;
                                TotalPurchased += purchase;
                                Cart[0].ChildNodes[1].InnerText = TotalPurchased.ToString();
                                doc.Save("CustomersCart.xml");
                            }
                            
                            else
                            {
                                CustomerCart customer = new CustomerCart(TotalPurchased);
                                customer.listofFood = new List<food>(foods);
                                customers.Add(customer);
                                XmlSerializer s = new XmlSerializer(customers.GetType());
                                FileStream fs = new FileStream("CustomersCart.xml", FileMode.Open);
                                s.Serialize(fs, customers);
                                fs.Close();
                            }

                        }
                        MessageBox.Show("Done");
                        this.Hide();
                      
                    }
                }
            }

        }

        private void order_id_TextChanged(object sender, EventArgs e)
        {
            order_id.ReadOnly = true;
        }

        private void order_price_TextChanged(object sender, EventArgs e)
        {
            order_price.ReadOnly = true;
            if (qt_txt.Value == 0)
            {
                order_price.Text = "0";
            }

        }
        private void qt_txt_ValueChanged(object sender, EventArgs e)
        {
            if (order_id.Text == ("Burger_"))
            {
                if (qt_txt.Value==0)
                {

                    order_price.Text = ("0");
                }
                else
                {
                    int totalprice = 30;
                    totalprice *=Convert.ToInt32(qt_txt.Value);
                    order_price.Text = (totalprice.ToString());


                }
            }
            if (order_id.Text == ("EggSandwich_"))
            {              
                if (qt_txt.Value == 0)
                {

                    order_price.Text = ("0");
                }
                else
                {
                    int totalprice = 25;
                    totalprice *= Convert.ToInt32(qt_txt.Value);                 
                    order_price.Text = (totalprice.ToString());


                }
            }
            if (order_id.Text == ("Hotdog_"))
            {
                if (qt_txt.Value == 0)
                {

                    order_price.Text = ("0");
                }
                else
                {
                    int totalprice = 20;
                    totalprice *= Convert.ToInt32(qt_txt.Value);
                    order_price.Text = (totalprice.ToString());


                }
            }
            else if (order_id.Text == ("GRILL_1"))
            {
                if (qt_txt.Value == 0)
                {
                    order_price.Text = ("0");
                }
                else
                {
                    int totalprice = 23;
                    totalprice *= Convert.ToInt32(qt_txt.Value);
                    order_price.Text = (totalprice.ToString());

                }
            }
            else if (order_id.Text == ("Pizza_Italian") || order_id.Text == ("Pizza_Cheese") || order_id.Text == ("Pizza_Garlic"))
            {
                if (qt_txt.Value == 0)
                {
                    order_price.Text = ("0");
                }
                else
                {
                    int totalprice = 45;
                    totalprice *= Convert.ToInt32(qt_txt.Value);
                    order_price.Text = (totalprice.ToString());

                }
            }
            else if (order_id.Text == ("PASTA_1"))
            {
                if (qt_txt.Value == 0)
                {
                    order_price.Text = ("0");
                }
                else
                {
                    int totalprice = 29;
                    totalprice *= Convert.ToInt32(qt_txt.Value);
                    order_price.Text = (totalprice.ToString());

                }

            }

            else if (order_id.Text == ("SUSHI_1"))
            {
                if (qt_txt.Value == 0)
                {
                    order_price.Text = ("0");
                }
                else
                {
                    int totalprice = 50;
                    totalprice *= Convert.ToInt32(qt_txt.Value);
                    order_price.Text = (totalprice.ToString());

                }

            }

            else if (order_id.Text == ("SOUP_Tomato"))
            {
                if (qt_txt.Value == 0)
                {
                    order_price.Text = ("0");
                }
                else
                {
                    int totalprice = 13;
                    totalprice *= Convert.ToInt32(qt_txt.Value);
                    order_price.Text = (totalprice.ToString());

                }

            }
            else if (order_id.Text == ("SOUP_Potato"))
            {
                if (qt_txt.Value == 0)
                {
                    order_price.Text = ("0");
                }
                else
                {
                    int totalprice = 10;
                    totalprice *= Convert.ToInt32(qt_txt.Value);
                    order_price.Text = (totalprice.ToString());

                }

            }
            else if (order_id.Text == ("SOUP_Gaulash"))
            {
                if (qt_txt.Value == 0)
                {
                    order_price.Text = ("0");
                }
                else
                {
                    int totalprice = 19;
                    totalprice *= Convert.ToInt32(qt_txt.Value);
                    order_price.Text = (totalprice.ToString());

                }

            }
            else if (order_id.Text == ("SOUP_Chicken"))
            {
                if (qt_txt.Value == 0)
                {
                    order_price.Text = ("0");
                }
                else
                {
                    int totalprice = 15;
                    totalprice *= Convert.ToInt32(qt_txt.Value);
                    order_price.Text = (totalprice.ToString());

                }

            }
            else if (order_id.Text == ("SOUP_Vegetables"))
            {
                if (qt_txt.Value == 0)
                {
                    order_price.Text = ("0");
                }
                else
                {
                    int totalprice = 12;
                    totalprice *= Convert.ToInt32(qt_txt.Value);
                    order_price.Text = (totalprice.ToString());

                }

            }
            else if (order_id.Text == ("SOUP_Curry"))
            {
                if (qt_txt.Value == 0)
                {
                    order_price.Text = ("0");
                }
                else
                {
                    int totalprice = 13;
                    totalprice *= Convert.ToInt32(qt_txt.Value);
                    order_price.Text = (totalprice.ToString());

                }

            }

            else if (order_id.Text == ("SALad_") || order_id.Text == ("SALad_Greek") || order_id.Text == ("SALad_Spicy"))
            {
                if (qt_txt.Value == 0)
                {
                    order_price.Text = ("0");
                }
                else
                {
                    int totalprice = 10;
                    totalprice *= Convert.ToInt32(qt_txt.Value);
                    order_price.Text = (totalprice.ToString());

                }

            }
            else if (order_id.Text == ("TARTE_1"))
            {
                if (qt_txt.Value == 0)
                {
                    order_price.Text = ("0");
                }
                else
                {
                    int totalprice = 30;
                    totalprice *= Convert.ToInt32(qt_txt.Value);
                    order_price.Text = (totalprice.ToString());
                }
            }
            else if (order_id.Text == ("CAKE_1"))
            {
                if (qt_txt.Value == 0)
                {
                    order_price.Text = ("0");
                }
                else
                {
                    int totalprice = 14;
                    totalprice *= Convert.ToInt32(qt_txt.Value);
                    order_price.Text = (totalprice.ToString());

                }
            }

            else if (order_id.Text == ("smoothie_1") || order_id.Text == ("juice_1") || order_id.Text == ("milkshake_1"))
            {
                if (qt_txt.Value == 0)
                {
                    order_price.Text = ("0");
                }
                else
                {
                    int totalprice = 13;
                    totalprice *= Convert.ToInt32(qt_txt.Value);
                    order_price.Text = (totalprice.ToString());

                }
            }

            else if (order_id.Text == ("Waffels_"))
            {
                if (qt_txt.Value == 0)
                {
                    order_price.Text = ("0");
                }
                else
                {
                    int totalprice = 20;
                    totalprice *= Convert.ToInt32(qt_txt.Value);
                    order_price.Text = (totalprice.ToString());

                }
            }

            else if (order_id.Text == ("BR_Offer"))
            {
                if (qt_txt.Value == 0)
                {
                    order_price.Text = ("0");
                }
                else
                {
                    Double totalprice = 30 - (30 * 0.2);
                    totalprice *= Convert.ToDouble(qt_txt.Value);
                    order_price.Text = (totalprice.ToString());

                }
            }
            else if (order_id.Text == ("GR_Offer"))
            {
                if (qt_txt.Value == 0)
                {
                    order_price.Text = ("0");
                }
                else
                {
                    Double totalprice = 23 - (23 * 0.15);
                    totalprice *= Convert.ToDouble(qt_txt.Value);
                    order_price.Text = (totalprice.ToString());
                }
            }
            else if (order_id.Text == ("P_Offer"))
            {
                if (qt_txt.Value == 0)
                {
                    order_price.Text = ("0");
                }
                else
                {
                    Double totalprice = 45 - (45 * 0.25);
                    totalprice *= Convert.ToDouble(qt_txt.Value);
                    order_price.Text = (totalprice.ToString());

                }
            }
            else if (order_id.Text == ("PAS_Offer"))
            {
                if (qt_txt.Value == 0)
                {
                    order_price.Text = ("0");
                }
                else
                {
                    Double totalprice = 29 - (29 * 0.3);
                    totalprice *= Convert.ToDouble(qt_txt.Value);
                    order_price.Text = (totalprice.ToString());
                }

            }
            else if (order_id.Text == ("SAND_Offer"))
            {
                if (qt_txt.Value == 0)
                {
                    order_price.Text = ("0");
                }
                else
                {
                    Double totalprice = 25 - (25 * 0.1);
                    totalprice *= Convert.ToDouble(qt_txt.Value);
                    order_price.Text = (totalprice.ToString());

                }
            }
            else if (order_id.Text == ("SUSHI_Offer"))
            {
                if (qt_txt.Value == 0)
                {
                    order_price.Text = ("0");
                }
                else
                {
                    Double totalprice = 50 - (50 * 0.45);
                    totalprice *= Convert.ToDouble(qt_txt.Value);
                    order_price.Text = (totalprice.ToString());
                }

            }
        }
    }

}
