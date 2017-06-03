using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMG_Progra1
{
    class Payment
    {
        private int id_payment;
        private int place;
        private DateTime date;
        private int user;
        private int fee;

        public Payment(int id_payment, int place, DateTime date, int user, int fee)
        {
            this.id_payment = id_payment;
            this.place = place;
            this.date = date;
            this.user = user;
            this.fee = fee;
        }

        public int ID
        {
            get
            {
                return id_payment;
            }

            set
            {
                id_payment = value;
            }
        }

        public Payment Save()
        {
            String query = String.Format("INSERT INTO [dbo].[payment] "
                       + "([id_place]"
                       + ",[date]"
                       + ",[id_user]"
                       + ",[id_fee])"
                 + "VALUES"
                       + "('{0}'"
                       + ",'{1}'"
                       + ",'{2}'"
                       + ",'{3}')",
                       this.place, this.date.ToString("d"), this.user, this.fee);
            Console.Write("{0}", query);
            Connection.exec(query);
            return this;
        }

        public Payment Update()
        {
            String query = String.Format("UPDATE [dbo].[payment] "
                   + "SET [id_place] = '{0}'"
                   + ",[date] = '{1}'"
                   + ",[id_user] = '{2}'"
                   + ",[id_fee] = '{3}'"
             + " WHERE [id_payment] = {4} ",
                    this.place, this.date.ToString("d"), this.user, this.fee, this.id_payment);
            Console.Write("{0}", query);
            Connection.exec(query);

            return this;
        }

    }
}
