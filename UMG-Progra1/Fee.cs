using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMG_Progra1
{
    class Fee
    {
        private int id_fee;
        private string type;
        private float amount;
        private DateTime date;

        public Fee(int id_fee, string type, float amount, DateTime date)
        {
            this.id_fee = id_fee;
            this.type = type;
            this.amount = amount;
            this.date = date;
        }
           
    }
}
