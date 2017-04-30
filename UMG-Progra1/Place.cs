using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMG_Progra1
{
    class Place
    {
        protected int id_place;
        protected string location;
        protected string number;
        protected string type;
        protected User owner;
        protected DateTime start_date;
        protected DateTime end_date;
        protected Fee fee;
        protected int capacity;
        protected string status;

        public Place(int id_place, string location, string number, string type, User owner, DateTime start_date, DateTime end_date, Fee fee, int capacity, string status)
        {
            this.id_place = id_place;
            this.location = location;
            this.number = number;
            this.type = type;
            this.owner = owner;
            this.start_date = start_date;
            this.end_date = end_date;
            this.fee = fee;
            this.capacity = capacity;
            this.status = status;
        }


    }
}
