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
        public PublicSpaces(int id_place, string location, string number, string type, User owner, DateTime start_date, DateTime end_date, Fee fee, int capacity, string status) : 
            base (id_place, location, number, type, owner, start_date, end_date, fee, capacity, status)
        {

        }
    }
}
