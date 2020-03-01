using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Project_Files_
{
    [Serializable]
   public  class CustomerCart
    {
       
        public List<food> listofFood { get; set; }
        public Double Total_Price { get; set; }

        public CustomerCart()
        {

        }
        public CustomerCart( Double Total_Price)
        {
          
            this.Total_Price = Total_Price;
            listofFood = new List<food>();

        }
    }
    public class food
    {
        public String id { get; set; }
        public Double price { get; set; }
        public int Quantity { get; set; }

        public food()
        {

        }
        public food(String id, Double price, int Quantity)
        {
            this.id = id;
            this.price = price;
            this.Quantity = Quantity;

        }
        public String getid()
        {
            return this.id;
        }

    }
}
