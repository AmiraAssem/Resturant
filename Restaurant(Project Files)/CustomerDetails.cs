using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Restaurant_Project_Files_
{
    [Serializable]
    public class CustomerDetails
    {

        public String phone { get; set; }
        public int NumOfLastOrders { get; set; }
        public Double TotalPurchased { get; set; }
        public String Discount { get; set; }
        public CustomerDetails()
        {

        }
        public CustomerDetails(String PhoneNom ,int NumOfLastOrders , Double TotalPurchased , String Discount)
        {
            this.phone = PhoneNom;
            this.NumOfLastOrders = NumOfLastOrders;
            this.TotalPurchased = TotalPurchased;
            this.Discount = Discount;

        }
    }

   

    

}
