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
        protected int user;
        protected DateTime start_date;
        protected DateTime end_date;
        protected int fee;
        protected int capacity;
        protected string status;

        public Place(int id_place, string location, string number, string type, int user, DateTime start_date, DateTime end_date, int fee, int capacity, string status)
        {
            this.id_place = id_place;
            this.location = location;
            this.number = number;
            this.type = type;
            this.user = user;
            this.start_date = start_date;
            this.end_date = end_date;
            this.fee = fee;
            this.capacity = capacity;
            this.status = status;
        }

        public int ID
        {
            get
            {
                return id_place;
            }

            set
            {
                id_place = value;
            }
        }

        public Place Save()
        {
            String query = String.Format("INSERT INTO [dbo].[place] "
                       + "([location]"
                       + ",[number]"
                       + ",[type]"
                       + ",[id_user]"
                       + ",[star_date]"
                       + ",[end_date]"
                       + ",[id_fee]"
                       + ",[capacity]"
                       + ",[status])"
                 + "VALUES"
                       + "('{0}'"
                       + ",'{1}'"
                       + ",'{2}'"
                       + ",{3}"
                       + ",'{4}'"
                       + ",'{5}'"
                       + ",{6}"
                       + ",{7}"
                       + ",'{8}')",
                       this.location, this.number, this.type, this.user, this.start_date.ToString("d"), this.end_date.ToString("d"), this.fee, this.capacity, this.status);
            Console.Write("{0}", query);
            Connection.exec(query);
            return this;
        }
        public Place Update()
        {
                String query = String.Format("UPDATE [dbo].[place] "
                       + "SET [location] = '{0}'"
                       + ",[number] = '{1}'"
                       + ",[id_user] = '{2}'"
                       + ",[star_date] = '{3}'"
                       + ",[end_date] = '{4}'"
                       + ",[id_fee] = {5}"
                       + ",[capacity] = {6}"
                       + ",[status] = '{7}'"
                 + " WHERE [id_place] = {8} ",
                       this.location, this.number, this.user, this.start_date.ToString("d"), this.end_date.ToString("d"), this.fee, this.capacity, this.status, this.id_place);
            Console.Write("{0}", query);
            Connection.exec(query);

            return this;
        }
    }
}
