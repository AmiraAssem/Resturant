using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Project_Files_
{
    [Serializable]
    public class Deliivery
    {
      public   String Area_Code { set; get; }
      public   List <DeliverBoysID> ListOfDeliverBoysID { set; get; }

        public Deliivery()
        {

        }
        public Deliivery(String Area_Code)
        {
            this.Area_Code = Area_Code;
            ListOfDeliverBoysID = new List<DeliverBoysID>();

        }
       
    }
    public class DeliverBoysID
    {
        public String ID { get; set; }

        public DeliverBoysID()
        {

        }
        public DeliverBoysID(String ID)
        {
            this.ID = ID;
        }

    }


}
