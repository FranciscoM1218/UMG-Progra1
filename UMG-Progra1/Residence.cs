using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMG_Progra1
{
    class Residence : Place
    {
        static public string APARTMENT_TYPE = "APARTMENT_TYPE";
        static public string HOUSE_TYPE = "HOUSE_TYPE";
        public Residence(int id_place, string location, string number, string type, User owner, DateTime start_date, DateTime end_date, Fee fee, int capacity, string status) : 
            base (id_place, location, number, type, owner, start_date, end_date, fee, capacity, status)
        {
            
        }
    }
}
