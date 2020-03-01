using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Restaurant_Project_Files_
{
    [Serializable]
   public class Food
    {
        public String ID { get; set; }
        public  String price { get; set; }
        public String Available_Quantity { get; set; }

        public Food()
        {

        }
       
        public Food(String ID , String price , String Available_Quantity)
        {
            this.ID = ID;
            this.price = price;
            this.Available_Quantity = Available_Quantity;
        }
        
    }
}
