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
    public partial class User_cart : UserControl
    {
        List<CustomerCart> customers = new List<CustomerCart>();
        List<CustomerDetails> customer = new List<CustomerDetails>();
        List<Deliivery> delivery = new List<Deliivery>();
        List<DeliverBoysID> DeliverBoys_ID = new List<DeliverBoysID>();
        Deliivery del = new Deliivery();

        public User_cart()
        {
            InitializeComponent();
            if (File.Exists("CustomersCart.xml"))
            {
                Double total = 0;
                DGV_customerCart.Rows.Clear();
                DGV_customerCart.Refresh();
                XmlSerializer ser = new XmlSerializer(typeof(List<CustomerCart>));
                FileStream fs = new FileStream("CustomersCart.xml", FileMode.Open);
                customers = (List<CustomerCart>)ser.Deserialize(fs);
                fs.Close();
                XmlDocument doc = new XmlDocument();
                doc.Load("CustomersCart.xml");
                XmlNodeList cart = doc.GetElementsByTagName("food");
                for (int i = 0; i < cart.Count; i++)
                {

                    String Order_ID = cart[i].ChildNodes[0].InnerText;
                    String Quantity = cart[i].ChildNodes[2].InnerText;
                    String Total_Price = cart[i].ChildNodes[1].InnerText;
                    DGV_customerCart.Rows.Add(Order_ID, Quantity, Total_Price);
                    total += Convert.ToDouble(Total_Price);
                   
                }
                Total_purchase.Text = total.ToString();
                XmlDocument xml = new XmlDocument();
                xml.Load("DeliveryBoys.xml");
                XmlNodeList Area_list = xml.GetElementsByTagName("Assigned_Area");
                for (int c = 0; c < Area_list.Count; c++) {
                    int count = 0;
                    if (address_txt.Items.Count == 0)
                    {
                        address_txt.Items.Add(Area_list[c].InnerText);
                    }
                    else
                    {
                        for (int j = 0; j < address_txt.Items.Count; j++)
                        {
                            if (!Area_list[c].InnerText.Equals(address_txt.Items[j]))
                            {
                                count++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (count== address_txt.Items.Count)
                        {
                            address_txt.Items.Add(Area_list[c].InnerText);
                        }
                    }

                }
            }
            if (File.Exists("Customers.xml"))
            {
                XmlSerializer ser = new XmlSerializer(customer.GetType());
                FileStream fs = new FileStream("Customers.xml", FileMode.Open);
                customer = (List<CustomerDetails>)ser.Deserialize(fs);
                fs.Close();
            }
            if (File.Exists("Delivery.xml"))
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Deliivery>));
                FileStream Stream = new FileStream("Delivery.xml", FileMode.Open);
                delivery = (List<Deliivery>)xml.Deserialize(Stream);
                Stream.Close();
            }

        }

        private void User_cart_Load(object sender, EventArgs e)
        {

        }

        private void UserPhoneNom_TextChanged(object sender, EventArgs e)
        {
            Double TotalPurchased = 0;
            XmlDocument doc = new XmlDocument();
            doc.Load("CustomersCart.xml");
            XmlNodeList Cart = doc.GetElementsByTagName("CustomerCart");
            String total_price = Cart[0].ChildNodes[1].InnerText;
            TotalPurchased = Convert.ToDouble(total_price);
            string discount_val = null;
            if (File.Exists("Customers.xml"))
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load("Customers.xml");
                XmlNodeList ListOfCustomerPhone = xmldoc.GetElementsByTagName("phone");
                for (int c = 0; c < ListOfCustomerPhone.Count; c++)
                {
                    if (ListOfCustomerPhone[c].InnerText.Equals(UserPhoneNom.Text))
                    {
                        char[] discount_value = ListOfCustomerPhone[c].ParentNode.ChildNodes[3].InnerText.ToCharArray();
                        for (int count = 0; count < discount_value.Length; count++)
                        {
                            if (discount_value[count] != '%')
                            {
                                discount_val += discount_value[count];
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (Convert.ToInt32(discount_val) > 0)
                        {
                            MessageBox.Show("you have Discount " + ListOfCustomerPhone[c].ParentNode.ChildNodes[3].InnerText);

                        }

                    }
                   
                }
                Double discount = Convert.ToDouble(discount_val);
                if (discount != 0)
                {
                    TotalPurchased = TotalPurchased - (TotalPurchased * (discount / 100));
                }
                Total_purchase.Text = TotalPurchased.ToString();
            }
        }

        private void Total_purchase_TextChanged(object sender, EventArgs e)
        {
            Total_purchase.ReadOnly = true;
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            int NomOfOrders = 0;
            Double TotalPurchased = 0;
            String Discount = "0";
            String Customer_phone = UserPhoneNom.Text;
            String order_Address = address_txt.Text;
          if (UserPhoneNom.Text!="" && address_txt.Text!="")
          { 
            //// Get listOFOrders and totalPrice ////

            XmlDocument doc = new XmlDocument();
            doc.Load("CustomersCart.xml");
            XmlNodeList Cart = doc.GetElementsByTagName("CustomerCart");
            String total_price = Cart[0].ChildNodes[1].InnerText;
            TotalPurchased= Convert.ToDouble(Total_purchase.Text);
            XmlNodeList ListOfOrders = doc.GetElementsByTagName("food");              

            /// get deliveryboys'IDs in the customer Area

            bool Area_found = false;
            Deliivery deliver = new Deliivery();
            XmlDocument xml = new XmlDocument();
            var IDs = new List<DeliverBoysID>();
            xml.Load("DeliveryBoys.xml");
            XmlNodeList Area_list = xml.GetElementsByTagName("Assigned_Area");
            for (int c = 0; c < Area_list.Count; c++)
            {
                XmlNodeList Parent = Area_list[c].ParentNode.ChildNodes;
                if (Area_list[c].InnerText.Equals(order_Address))
                {
                    DeliverBoysID IDS = new DeliverBoysID(Parent[1].InnerText);
                    IDs.Add(IDS);
                    Area_found = true;
                }
            }

            if (!Area_found)
            {
                MessageBox.Show("Sorry, we do not have a delivery service for this area");
                this.Hide();
            }

            else
            {
                // Update menu by changing the available quantity of the items which the customer ordered
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load("Menu.xml");
                XmlNodeList menu = xmldoc.GetElementsByTagName("ID");
                for (int i = 0; i < menu.Count; i++)
                {
                    for (int j = 0; j < ListOfOrders.Count; j++)
                    {
                        if (menu[i].InnerText.Equals(ListOfOrders[j].ChildNodes[0].InnerText))
                        {
                            int qty = Convert.ToInt32(menu[i].ParentNode.ChildNodes[2].InnerText);
                            int Quantity = Convert.ToInt32(ListOfOrders[j].ChildNodes[2].InnerText);
                            qty -= Quantity;
                            menu[i].ParentNode.ChildNodes[2].InnerText = qty.ToString();
                            xmldoc.Save("Menu.xml");
                        }
                    }
                }



                // Choose deliveryboy Randomly
                var Random = new Random();
                int index = Random.Next(IDs.Count);
                DeliverBoys_ID.Add(IDs[index]);
                // nom of deliveryboy's Orders
                int Nom = 0;
                xml.Load("DeliveryBoys.xml");
                XmlNodeList DeliveryBoysIDs = xml.GetElementsByTagName("ID");
                for (int c = 0; c < DeliveryBoysIDs.Count; c++)
                {
                    XmlNodeList Parent = DeliveryBoysIDs[c].ParentNode.ChildNodes;
                    if (DeliveryBoysIDs[c].InnerText.Equals(IDs[index].ID))
                    {
                        Nom = Convert.ToInt32(Parent[4].InnerText);
                        Nom++;
                        Parent[4].InnerText = Nom.ToString();
                        xml.Save("DeliveryBoys.xml");
                    }
                }



                if (File.Exists("Delivery.xml"))
                {
                    XmlDocument xml_document = new XmlDocument();
                    XmlNodeList area = null;
                    xml_document.Load("Delivery.xml");
                    XmlNodeList Available_areas = xml_document.GetElementsByTagName("Area_Code");
                    bool Area_Found = false;
                    for (int c = 0; c < Available_areas.Count; c++)
                    {
                        if (Available_areas[c].InnerText.Equals(order_Address))
                        {
                            area = Available_areas[c].ParentNode.ChildNodes;
                            Area_Found = true;
                            break;
                        }
                    }
                    if (Area_Found)
                    {
                        XmlElement child = xml_document.CreateElement("ID");
                        child.InnerText = IDs[index].ID;
                        bool deliveryboy_found = false;
                        XmlNodeList ids = xml_document.GetElementsByTagName("ID");
                        for (int i = 0; i < ids.Count; i++)
                        {
                            if (ids[i].InnerText.Equals(child.InnerText))
                            {
                                deliveryboy_found = true;
                                break;
                            }
                        }

                        if (!deliveryboy_found)
                        {
                            // add deliveryboy's id to the list of deliveriboys'IDs of this Area
                            XmlNode parent = area[1].ChildNodes[0];
                            parent.AppendChild(child);
                            xml_document.Save("Delivery.xml");

                            // check if the customer already exist or this is the first time 
                            if (File.Exists("Customers.xml"))
                            {
                                bool customer_found = false;
                                XmlDocument document = new XmlDocument();
                                document.Load("Customers.xml");
                                XmlNodeList customers_phone = document.GetElementsByTagName("phone");
                                for (int i = 0; i < customers_phone.Count; i++)
                                {
                                    XmlNodeList Root = customers_phone[i].ParentNode.ChildNodes;
                                    if (customers_phone[i].InnerText.Equals(Customer_phone))
                                    {
                                        //Num of Customer's lastOrders
                                        int Num = Convert.ToInt32(Root[1].InnerText);
                                        Num++;
                                        //update customer's numofOrders
                                        Root[1].InnerText = Num.ToString();
                                        //  Customer's TotalPurcashed
                                        Double total_purchase = Convert.ToInt32(Root[2].InnerText);
                                        total_purchase += TotalPurchased;
                                        //update customer's TotalPurcashed
                                        Root[2].InnerText = total_purchase.ToString();
                                        if (Num >= 3 || Convert.ToDouble(Root[2].InnerText) > 1000)
                                        {
                                            Root[3].InnerText = "15%";
                                        }
                                        if (Num >= 6 || Convert.ToDouble(Root[2].InnerText) > 1500)
                                        {
                                            Root[3].InnerText = "25%";
                                        }
                                        if (Num >= 9 || Convert.ToDouble(Root[2].InnerText) > 2000)
                                        {
                                            Root[3].InnerText = "35%";
                                        }
                                        customer_found = true;
                                        document.Save("Customers.xml");
                                        break;
                                    }
                                }
                                if (!customer_found)
                                {
                                    CustomerDetails CD = new CustomerDetails(Customer_phone, NomOfOrders, TotalPurchased, Discount);
                                    customer.Add(CD);
                                    XmlSerializer s = new XmlSerializer(customer.GetType());
                                    FileStream stream = new FileStream("Customers.xml", FileMode.Create);
                                    s.Serialize(stream, customer);
                                    stream.Close();
                                }

                            }
                            else
                            {
                                CustomerDetails CD = new CustomerDetails(Customer_phone, NomOfOrders, TotalPurchased, Discount);
                                customer.Add(CD);
                                XmlSerializer s = new XmlSerializer(customer.GetType());
                                FileStream stream = new FileStream("Customers.xml", FileMode.Create);
                                s.Serialize(stream, customer);
                                stream.Close();
                            }

                        }
                        else
                        {

                            if (File.Exists("Customers.xml"))
                            {
                                bool customer_found = false;
                                XmlDocument document = new XmlDocument();
                                document.Load("Customers.xml");
                                XmlNodeList customers_phone = document.GetElementsByTagName("phone");
                                for (int i = 0; i < customers_phone.Count; i++)
                                {
                                    XmlNodeList Root = customers_phone[i].ParentNode.ChildNodes;
                                    if (customers_phone[i].InnerText.Equals(Customer_phone))
                                    {
                                        //Num of Customer's lastOrders
                                        int Num = Convert.ToInt32(Root[1].InnerText);
                                        Num++;
                                        //update customer's numofOrders
                                        Root[1].InnerText = Num.ToString();
                                        //  Customer's TotalPurcashed
                                        Double total_purchase = Convert.ToDouble(Root[2].InnerText);
                                        total_purchase += TotalPurchased;
                                        //update customer's TotalPurcashed
                                        Root[2].InnerText = total_purchase.ToString();
                                        if (Num >= 3 || Convert.ToDouble(Root[2].InnerText) > 1000)
                                        {
                                            Root[3].InnerText = "15%";
                                        }
                                        if (Num >= 6 || Convert.ToDouble(Root[2].InnerText) > 1500)
                                        {
                                            Root[3].InnerText = "25%";
                                        }
                                        if (Num >= 9 || Convert.ToDouble(Root[2].InnerText) > 2000)
                                        {
                                            Root[3].InnerText = "35%";
                                        }
                                        document.Save("Customers.xml");
                                        customer_found = true;
                                        break;
                                    }
                                }
                                if (!customer_found)
                                {
                                    CustomerDetails CD = new CustomerDetails(Customer_phone, NomOfOrders, TotalPurchased, Discount);
                                    customer.Add(CD);
                                    XmlSerializer s = new XmlSerializer(customer.GetType());
                                    FileStream stream = new FileStream("Customers.xml", FileMode.Create);
                                    s.Serialize(stream, customer);
                                    stream.Close();
                                }

                            }
                            else
                            {
                                CustomerDetails CD = new CustomerDetails(Customer_phone, NomOfOrders, TotalPurchased, Discount);
                                customer.Add(CD);
                                XmlSerializer s = new XmlSerializer(customer.GetType());
                                FileStream stream = new FileStream("Customers.xml", FileMode.Create);
                                s.Serialize(stream, customer);
                                stream.Close();
                            }

                        }
                    }

                    else
                    {
                        // add new DeliveryAREA //
                        deliver = new Deliivery(order_Address);
                        deliver.ListOfDeliverBoysID = DeliverBoys_ID;
                        delivery.Add(deliver);
                        XmlSerializer Xml = new XmlSerializer(delivery.GetType());
                        FileStream Stream = new FileStream("Delivery.xml", FileMode.OpenOrCreate);
                        Xml.Serialize(Stream, delivery);
                        Stream.Close();



                        if (File.Exists("Customers.xml"))
                        {
                            bool customer_found = false;
                            XmlDocument document = new XmlDocument();
                            document.Load("Customers.xml");
                            XmlNodeList customers_phone = document.GetElementsByTagName("phone");
                            for (int i = 0; i < customers_phone.Count; i++)
                            {
                                XmlNodeList Root = customers_phone[i].ParentNode.ChildNodes;
                                if (customers_phone[i].InnerText.Equals(Customer_phone))
                                {
                                    //Num of Customer's lastOrders
                                    int Num = Convert.ToInt32(Root[1].InnerText);
                                    Num++;
                                    //update customer's numofOrders
                                    Root[1].InnerText = Num.ToString();
                                    //  Customer's TotalPurcashed
                                    Double total_purchase = Convert.ToDouble(Root[2].InnerText);
                                    total_purchase += TotalPurchased;
                                    //update customer's TotalPurcashed
                                    Root[2].InnerText = total_purchase.ToString();
                                    if (Num >= 3 || Convert.ToDouble(Root[2].InnerText) > 1000)
                                    {
                                        Root[3].InnerText = "15%";
                                    }
                                    if (Num >= 6 || Convert.ToDouble(Root[2].InnerText) > 1500)
                                    {
                                        Root[3].InnerText = "25%";
                                    }
                                    if (Num >= 9 || Convert.ToDouble(Root[2].InnerText) > 2000)
                                    {
                                        Root[3].InnerText = "35%";
                                    }
                                    document.Save("Customers.xml");
                                    customer_found = true;
                                    break;
                                }
                            }
                            if (!customer_found)
                            {
                                CustomerDetails CD = new CustomerDetails(Customer_phone, NomOfOrders, TotalPurchased, Discount);
                                customer.Add(CD);
                                XmlSerializer s = new XmlSerializer(customer.GetType());
                                FileStream stream = new FileStream("Customers.xml", FileMode.Create);
                                s.Serialize(stream, customer);
                                stream.Close();
                            }

                        }
                        else
                        {
                            CustomerDetails CD = new CustomerDetails(Customer_phone, NomOfOrders, TotalPurchased, Discount);
                            customer.Add(CD);
                            XmlSerializer s = new XmlSerializer(customer.GetType());
                            FileStream stream = new FileStream("Customers.xml", FileMode.Create);
                            s.Serialize(stream, customer);
                            stream.Close();
                        }

                    }
                    // clear Customer Cart 
                    MessageBox.Show("Done");
                    Total_purchase.Text = "";
                    XmlDocument docu = new XmlDocument();
                    docu.Load("CustomersCart.xml");
                    XmlElement root = docu.DocumentElement;
                    root.RemoveAll();
                    docu.Save("CustomersCart.xml");
                    DGV_customerCart.Rows.Clear();
                }
                if (!File.Exists("Delivery.xml"))
                {

                    deliver = new Deliivery(order_Address);
                    deliver.ListOfDeliverBoysID = DeliverBoys_ID;
                    delivery.Add(deliver);
                    XmlSerializer Xml = new XmlSerializer(delivery.GetType());
                    FileStream Stream = new FileStream("Delivery.xml", FileMode.OpenOrCreate);
                    Xml.Serialize(Stream, delivery);
                    Stream.Close();
                    if (File.Exists("Customers.xml"))
                    {
                        bool customer_found = false;
                        XmlDocument document = new XmlDocument();
                        document.Load("Customers.xml");
                        XmlNodeList customers_phone = document.GetElementsByTagName("phone");
                        for (int i = 0; i < customers_phone.Count; i++)
                        {
                            XmlNodeList Root = customers_phone[i].ParentNode.ChildNodes;
                            if (customers_phone[i].InnerText.Equals(Customer_phone))
                            {
                                //Num of Customer's lastOrders
                                int Num = Convert.ToInt32(Root[1].InnerText);
                                Num++;
                                //update customer's numofOrders
                                Root[1].InnerText = Num.ToString();
                                //  Customer's TotalPurcashed
                                Double total_purchase = Convert.ToDouble(Root[2].InnerText);
                                total_purchase += TotalPurchased;
                                //update customer's TotalPurcashed
                                Root[2].InnerText = total_purchase.ToString();
                                if (Num >= 3 || Convert.ToDouble(Root[2].InnerText) > 1000)
                                {
                                    Root[3].InnerText = "15%";
                                }
                                if (Num >= 6 || Convert.ToDouble(Root[2].InnerText) > 1500)
                                {
                                    Root[3].InnerText = "25%";
                                }
                                if (Num >= 9 || Convert.ToDouble(Root[2].InnerText) > 2000)
                                {
                                    Root[3].InnerText = "35%";
                                }
                                document.Save("Customers.xml");
                                customer_found = true;
                                break;
                            }
                        }
                        if (!customer_found)
                        {
                            CustomerDetails CD = new CustomerDetails(Customer_phone, NomOfOrders, TotalPurchased, Discount);
                            customer.Add(CD);
                            XmlSerializer s = new XmlSerializer(customer.GetType());
                            FileStream stream = new FileStream("Customers.xml", FileMode.Create);
                            s.Serialize(stream, customer);
                            stream.Close();
                        }

                    }
                    else
                    {
                        CustomerDetails CD = new CustomerDetails(Customer_phone, NomOfOrders, TotalPurchased, Discount);
                        customer.Add(CD);
                        XmlSerializer s = new XmlSerializer(customer.GetType());
                        FileStream stream = new FileStream("Customers.xml", FileMode.Create);
                        s.Serialize(stream, customer);
                        stream.Close();
                    }

                    MessageBox.Show("Done");
                    UserPhoneNom.Text = " ";
                    Total_purchase.Text = " ";
                    XmlDocument docu = new XmlDocument();
                    docu.Load("CustomersCart.xml");
                    XmlElement root = docu.DocumentElement;
                    root.RemoveAll();
                    docu.Save("CustomersCart.xml");
                    DGV_customerCart.Rows.Clear();
                }

            }
               
               
          }
          else
          {
             MessageBox.Show("Please Fill your data to Order");
          }
            
        }

        private void UserPhoneNom_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void UserPhoneNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                
            }
        }

        
    }
}




