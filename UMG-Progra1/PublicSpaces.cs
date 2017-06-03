using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMG_Progra1
{
    class PublicSpaces : Place
    {
        static public string POOL_TYPE = "POOL_TYPE";
        static public string GYM_TYPE = "GYM_TYPE";
        static public string ROOM_TYPE = "ROOM_TYPE";
        static public string GRILL_TYPE = "GRILL_TYPE";
        public PublicSpaces(int id_place, string location, string number, int user, DateTime start_date, DateTime end_date, int fee, int capacity, string status) : 
            base (id_place, location, number, "Espacio Publico", user, start_date, end_date, fee, capacity, status)
        {

        }
    }
}
