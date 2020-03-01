using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Restaurant_Project_Files_
{
    [Serializable]
   public class DeliveryBoy
    {
        public String name { get; set; }

        public String ID { get; set; }

        public String Phone { get; set; }

        public String Assigned_Area { get; set; }
        public int NumOfOrders { get; set; }

        public DeliveryBoy()
        {

        }
        public DeliveryBoy(String name, String ID , String Phone, String Assigned_Area , int NumOfOrders)
        {
            this.name = name;
            this.ID = ID;
            this.Phone = Phone;
            this.Assigned_Area = Assigned_Area;
            this.NumOfOrders = NumOfOrders;
        }

    }
}
