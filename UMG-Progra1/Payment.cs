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
        private Place place;
        private DateTime date;
        private User user;
        private Fee fee;

        public Payment(int id_payment, Place place, DateTime date, User user, Fee fee)
        {
            this.id_payment = id_payment;
            this.place = place;
            this.date = date;
            this.user = user;
            this.fee = fee;
        }
    }
}
