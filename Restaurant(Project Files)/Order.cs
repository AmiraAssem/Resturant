using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Restaurant_Project_Files_
{
    public partial class Order : Form
    {
        List<CustomerCart> customers = new List<CustomerCart>();
        List<CustomerDetails> customer = new List<CustomerDetails>();
        List<Deliivery> delivery = new List<Deliivery>();
        List<DeliverBoysID> DeliverBoys_ID = new List<DeliverBoysID>();
        Deliivery del = new Deliivery();
        public Order()
        {
            InitializeComponent();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            //int NomOfOrders = 0;
            //Double TotalPurcashed = 0;
            //String Discount = "0";
            //// String Customer_phone = UserPhoneNom.Text;
            //// order_Address take the customer order’s Address
            //XmlNode order_Address = null;
            //// get list of the customer's order
            //XmlNodeList ListOfOrders = null;
            //XmlDocument doc = new XmlDocument();
            //doc.Load("CustomersCart.xml");
            //XmlNode CustomersCart = doc.SelectSingleNode("");

            ////XmlNodeList CustomersCart= doc.GetElementsByTagName("CustomerCart");
            ////for (int i = 0; i < CustomersCart.Count; i++)
            ////{
            ////    XmlNode Root = CustomersCart[i].ParentNode;
            ////    if (CustomersCart[i].InnerText.Equals(Customer_phone))
            ////    {
            ////        order_Address = Customers_Phone[i].ParentNode.ChildNodes[1];
            ////        ListOfOrders = Customers_Phone[i].ParentNode.ChildNodes[2].ChildNodes;
            ////        TotalPurcashed = Convert.ToDouble(Customers_Phone[i].ParentNode.ChildNodes[3].InnerText);
            ////    }
            ////}
            //bool Area_found = false;
            //Deliivery deliver = new Deliivery();
            //XmlDocument xml = new XmlDocument();
            //var IDs = new List<DeliverBoysID>();
            //xml.Load("DeliveryBoys.xml");
            //XmlNodeList Area_list = xml.GetElementsByTagName("Assigned_Area");
            //for (int c = 0; c < Area_list.Count; c++)
            //{
            //    XmlNodeList Parent = Area_list[c].ParentNode.ChildNodes;
            //    if (Area_list[c].InnerText.Equals(order_Address.InnerText))
            //    {
            //        DeliverBoysID IDS = new DeliverBoysID(Parent[1].InnerText);
            //        IDs.Add(IDS);
            //        Area_found = true;
            //    }
            //}

            //if (!Area_found)
            //{
            //    MessageBox.Show("Sorry, we do not have a delivery service for this area");
            //    this.Hide();
            //}

            //else
            //{
            //    XmlDocument xmldoc = new XmlDocument();
            //    xmldoc.Load("Menu.xml");
            //    XmlNodeList menu = xmldoc.GetElementsByTagName("ID");
            //    for (int i = 0; i < menu.Count; i++)
            //    {
            //        for (int j = 0; j < ListOfOrders.Count; j++)
            //        {
            //            if (menu[i].InnerText.Equals(ListOfOrders[j].ChildNodes[0].InnerText))
            //            {
            //                int qty = Convert.ToInt32(menu[i].ParentNode.ChildNodes[2].InnerText);
            //                int Quantity = Convert.ToInt32(ListOfOrders[j].ChildNodes[2].InnerText);
            //                qty -= Quantity;
            //                menu[i].ParentNode.ChildNodes[2].InnerText = qty.ToString();
            //                xmldoc.Save("Menu.xml");
            //            }
            //        }
            //    }
            //    // nom of Orders
            //    int Nom = 0;
            //    var Random = new Random();
            //    int index = Random.Next(IDs.Count);
            //    DeliverBoys_ID.Add(IDs[index]);
            //    xml.Load("DeliveryBoys.xml");
            //    XmlNodeList DeliveryBoysIDs = xml.GetElementsByTagName("ID");
            //    for (int c = 0; c < DeliveryBoysIDs.Count; c++)
            //    {
            //        XmlNodeList Parent = DeliveryBoysIDs[c].ParentNode.ChildNodes;
            //        if (DeliveryBoysIDs[c].InnerText.Equals(IDs[index].ID))
            //        {
            //            Nom = Convert.ToInt32(Parent[4].InnerText);
            //            Nom++;
            //            Parent[4].InnerText = Nom.ToString();
            //            xml.Save("DeliveryBoys.xml");
            //        }
            //    }
            //    if (File.Exists("Delivery.xml"))
            //    {
            //        XmlDocument xml_document = new XmlDocument();
            //        XmlNodeList area = null;
            //        xml_document.Load("Delivery.xml");
            //        XmlNodeList Available_areas = xml_document.GetElementsByTagName("Area_Code");
            //        bool Area_Found = false;
            //        for (int c = 0; c < Available_areas.Count; c++)
            //        {
            //            if (Available_areas[c].InnerText.Equals(order_Address.InnerText))
            //            {
            //                area = Available_areas[c].ParentNode.ChildNodes;
            //                Area_Found = true;
            //                break;
            //            }
            //        }
            //        if (Area_Found)
            //        {
            //            XmlElement child = xml_document.CreateElement("ID");
            //            child.InnerText = IDs[index].ID;
            //            bool deliveryboy_found = false;
            //            XmlNodeList ids = xml_document.GetElementsByTagName("ID");
            //            for (int i = 0; i < ids.Count; i++)
            //            {
            //                if (ids[i].InnerText.Equals(child.InnerText))
            //                {
            //                    deliveryboy_found = true;
            //                    break;
            //                }
            //            }

            //            if (!deliveryboy_found)
            //            {
            //                XmlNode parent = area[1].ChildNodes[0];
            //                parent.AppendChild(child);
            //                xml_document.Save("Delivery.xml");
            //                if (File.Exists("Customers.xml"))
            //                {
            //                    bool customer_found = false;
            //                    XmlDocument document = new XmlDocument();
            //                    document.Load("Customers.xml");
            //                    XmlNodeList customers_phone = document.GetElementsByTagName("phone");
            //                    for (int i = 0; i < customers_phone.Count; i++)
            //                    {
            //                        XmlNodeList Root = customers_phone[i].ParentNode.ChildNodes;
            //                        if (customers_phone[i].InnerText.Equals(Customer_phone))
            //                        {
            //                            //Num of Customer's lastOrders
            //                            int Num = Convert.ToInt32(Root[1].InnerText);
            //                            Num++;
            //                            //update customer's numofOrders
            //                            Root[1].InnerText = Num.ToString();
            //                            //  Customer's TotalPurcashed
            //                            Double total_purchase = Convert.ToInt32(Root[2].InnerText);
            //                            total_purchase += TotalPurcashed;
            //                            //update customer's TotalPurcashed
            //                            Root[2].InnerText = total_purchase.ToString();
            //                            if (Num >= 3)
            //                            {
            //                                Root[3].InnerText = "10%";
            //                            }
            //                            else if (Num >= 6)
            //                            {
            //                                Root[3].InnerText = "15%";
            //                            }
            //                            else if (Num >= 9)
            //                            {
            //                                Root[3].InnerText = "20%";
            //                            }
            //                            customer_found = true;
            //                            document.Save("Customers.xml");
            //                            break;
            //                        }
            //                    }
            //                    if (!customer_found)
            //                    {
            //                        CustomerDetails CD = new CustomerDetails(Customer_phone, NomOfOrders, TotalPurcashed, Discount);
            //                        customer.Add(CD);
            //                        XmlSerializer s = new XmlSerializer(customer.GetType());
            //                        FileStream stream = new FileStream("Customers.xml", FileMode.Create);
            //                        s.Serialize(stream, customer);
            //                        stream.Close();
            //                    }

            //                }
            //                else
            //                {
            //                    CustomerDetails CD = new CustomerDetails(Customer_phone, NomOfOrders, TotalPurcashed, Discount);
            //                    customer.Add(CD);
            //                    XmlSerializer s = new XmlSerializer(customer.GetType());
            //                    FileStream stream = new FileStream("Customers.xml", FileMode.Create);
            //                    s.Serialize(stream, customer);
            //                    stream.Close();
            //                }

            //            }
            //            else
            //            {
            //                if (File.Exists("Customers.xml"))
            //                {
            //                    bool customer_found = false;
            //                    XmlDocument document = new XmlDocument();
            //                    document.Load("Customers.xml");
            //                    XmlNodeList customers_phone = document.GetElementsByTagName("phone");
            //                    for (int i = 0; i < customers_phone.Count; i++)
            //                    {
            //                        XmlNodeList Root = customers_phone[i].ParentNode.ChildNodes;
            //                        if (customers_phone[i].InnerText.Equals(Customer_phone))
            //                        {
            //                            //Num of Customer's lastOrders
            //                            int Num = Convert.ToInt32(Root[1].InnerText);
            //                            Num++;
            //                            //update customer's numofOrders
            //                            Root[1].InnerText = Num.ToString();
            //                            //  Customer's TotalPurcashed
            //                            int total_purchase = Convert.ToInt32(Root[2].InnerText);
            //                            total_purchase += Convert.ToInt32(TotalPurcashed);
            //                            //update customer's TotalPurcashed
            //                            Root[2].InnerText = total_purchase.ToString();
            //                            if (Num >= 3)
            //                            {
            //                                Root[3].InnerText = "10%";
            //                            }
            //                            else if (Num >= 6)
            //                            {
            //                                Root[3].InnerText = "15%";
            //                            }
            //                            else if (Num >= 9)
            //                            {
            //                                Root[3].InnerText = "20%";
            //                            }
            //                            document.Save("Customers.xml");
            //                            customer_found = true;
            //                            break;
            //                        }
            //                    }
            //                    if (!customer_found)
            //                    {
            //                        CustomerDetails CD = new CustomerDetails(Customer_phone, NomOfOrders, TotalPurcashed, Discount);
            //                        customer.Add(CD);
            //                        XmlSerializer s = new XmlSerializer(customer.GetType());
            //                        FileStream stream = new FileStream("Customers.xml", FileMode.Create);
            //                        s.Serialize(stream, customer);
            //                        stream.Close();
            //                    }

            //                }
            //                else
            //                {
            //                    CustomerDetails CD = new CustomerDetails(Customer_phone, NomOfOrders, TotalPurcashed, Discount);
            //                    customer.Add(CD);
            //                    XmlSerializer s = new XmlSerializer(customer.GetType());
            //                    FileStream stream = new FileStream("Customers.xml", FileMode.Create);
            //                    s.Serialize(stream, customer);
            //                    stream.Close();
            //                }

            //            }
            //        }

            //        else
            //        {
            //            deliver = new Deliivery(order_Address.InnerText);
            //            deliver.DeliverBoysID = new List<DeliverBoysID>(DeliverBoys_ID);
            //            delivery.Add(deliver);
            //            XmlSerializer Xml = new XmlSerializer(delivery.GetType());
            //            FileStream Stream = new FileStream("Delivery.xml", FileMode.OpenOrCreate);
            //            Xml.Serialize(Stream, delivery);
            //            Stream.Close();
            //            if (File.Exists("Customers.xml"))
            //            {
            //                bool customer_found = false;
            //                XmlDocument document = new XmlDocument();
            //                document.Load("Customers.xml");
            //                XmlNodeList customers_phone = document.GetElementsByTagName("phone");
            //                for (int i = 0; i < customers_phone.Count; i++)
            //                {
            //                    XmlNodeList Root = customers_phone[i].ParentNode.ChildNodes;
            //                    if (customers_phone[i].InnerText.Equals(Customer_phone))
            //                    {
            //                        //Num of Customer's lastOrders
            //                        int Num = Convert.ToInt32(Root[1].InnerText);
            //                        Num++;
            //                        //update customer's numofOrders
            //                        Root[1].InnerText = Num.ToString();
            //                        //  Customer's TotalPurcashed
            //                        int total_purchase = Convert.ToInt32(Root[2].InnerText);
            //                        total_purchase += Convert.ToInt32(TotalPurcashed);
            //                        //update customer's TotalPurcashed
            //                        Root[2].InnerText = total_purchase.ToString();
            //                        if (Num >= 3)
            //                        {
            //                            Root[3].InnerText = "10%";
            //                        }
            //                        else if (Num >= 6)
            //                        {
            //                            Root[3].InnerText = "15%";
            //                        }
            //                        else if (Num >= 9)
            //                        {
            //                            Root[3].InnerText = "20%";
            //                        }
            //                        document.Save("Customers.xml");
            //                        customer_found = true;
            //                        break;
            //                    }
            //                }
            //                if (!customer_found)
            //                {
            //                    CustomerDetails CD = new CustomerDetails(Customer_phone, NomOfOrders, TotalPurcashed, Discount);
            //                    customer.Add(CD);
            //                    XmlSerializer s = new XmlSerializer(customer.GetType());
            //                    FileStream stream = new FileStream("Customers.xml", FileMode.Create);
            //                    s.Serialize(stream, customer);
            //                    stream.Close();
            //                }

            //            }
            //            else
            //            {
            //                CustomerDetails CD = new CustomerDetails(Customer_phone, NomOfOrders, TotalPurcashed, Discount);
            //                customer.Add(CD);
            //                XmlSerializer s = new XmlSerializer(customer.GetType());
            //                FileStream stream = new FileStream("Customers.xml", FileMode.Create);
            //                s.Serialize(stream, customer);
            //                stream.Close();
            //            }




            //        }
            //        MessageBox.Show("Done");
            //        Total_purchase.Text = "";
            //        XmlDocument docu = new XmlDocument();
            //        docu.Load("CustomersCart.xml");
            //        XmlElement root = docu.DocumentElement;
            //        root.RemoveAll();
            //        docu.Save("CustomersCart.xml");
            //        DGV_customerCart.Rows.Clear();
            //    }
            //    if (!File.Exists("Delivery.xml"))
            //    {

            //        deliver = new Deliivery(order_Address.InnerText);
            //        deliver.DeliverBoysID = DeliverBoys_ID;
            //        delivery.Add(deliver);
            //        XmlSerializer Xml = new XmlSerializer(delivery.GetType());
            //        FileStream Stream = new FileStream("Delivery.xml", FileMode.OpenOrCreate);
            //        Xml.Serialize(Stream, delivery);
            //        Stream.Close();
            //        if (File.Exists("Customers.xml"))
            //        {
            //            bool customer_found = false;
            //            XmlDocument document = new XmlDocument();
            //            document.Load("Customers.xml");
            //            XmlNodeList customers_phone = document.GetElementsByTagName("phone");
            //            for (int i = 0; i < customers_phone.Count; i++)
            //            {
            //                XmlNodeList Root = customers_phone[i].ParentNode.ChildNodes;
            //                if (customers_phone[i].InnerText.Equals(Customer_phone))
            //                {
            //                    //Num of Customer's lastOrders
            //                    int Num = Convert.ToInt32(Root[1].InnerText);
            //                    Num++;
            //                    //update customer's numofOrders
            //                    Root[1].InnerText = Num.ToString();
            //                    //  Customer's TotalPurcashed
            //                    int total_purchase = Convert.ToInt32(Root[2].InnerText);
            //                    total_purchase += Convert.ToInt32(TotalPurcashed);
            //                    //update customer's TotalPurcashed
            //                    Root[2].InnerText = total_purchase.ToString();
            //                    if (Num >= 3)
            //                    {
            //                        Root[3].InnerText = "10%";
            //                    }
            //                    else if (Num >= 6)
            //                    {
            //                        Root[3].InnerText = "15%";
            //                    }
            //                    else if (Num >= 9)
            //                    {
            //                        Root[3].InnerText = "20%";
            //                    }
            //                    document.Save("Customers.xml");
            //                    customer_found = true;
            //                    break;
            //                }
            //            }
            //            if (!customer_found)
            //            {
            //                CustomerDetails CD = new CustomerDetails(Customer_phone, NomOfOrders, TotalPurcashed, Discount);
            //                customer.Add(CD);
            //                XmlSerializer s = new XmlSerializer(customer.GetType());
            //                FileStream stream = new FileStream("Customers.xml", FileMode.Create);
            //                s.Serialize(stream, customer);
            //                stream.Close();
            //            }

            //        }
            //        else
            //        {
            //            CustomerDetails CD = new CustomerDetails(Customer_phone, NomOfOrders, TotalPurcashed, Discount);
            //            customer.Add(CD);
            //            XmlSerializer s = new XmlSerializer(customer.GetType());
            //            FileStream stream = new FileStream("Customers.xml", FileMode.Create);
            //            s.Serialize(stream, customer);
            //            stream.Close();
            //        }

            //        MessageBox.Show("Done");
            //        XmlDocument docu = new XmlDocument();
            //        docu.Load("CustomersCart.xml");
            //        XmlElement root = docu.DocumentElement;
            //        root.RemoveAll();
            //        docu.Save("CustomersCart.xml");
                   
            //    }

            //}

        }
    }
}
