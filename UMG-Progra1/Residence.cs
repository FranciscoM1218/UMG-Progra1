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
        public Residence(int id_place, string location, string number, int user, DateTime start_date, DateTime end_date, int fee, int capacity, string status) : 
            base (id_place, location, number, "Residencia", user, start_date, end_date, fee, capacity, status)
        {
            
        }
    }
}
