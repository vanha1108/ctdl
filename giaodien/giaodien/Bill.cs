using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Bill
    {
        private int status;
        private DateTime? dateCheckOut;
        private DateTime? dateCheckIn;
        private int iD;

        public DateTime? DateCheckIn
        {
            get
            {
                return dateCheckIn;
            }

            set
            {
                dateCheckIn = value;
            }
        }

        public int ID
        {
            get
            {
                return iD;
            }

            set
            {
                iD = value;
            }
        }

        public DateTime? DateCheckOut
        {
            get
            {
                return dateCheckOut;
            }

            set
            {
                dateCheckOut = value;
            }
        }

        public int Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }
        public Bill(int id,DateTime? dateCheckin, DateTime? dateCheckOut,int status)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckin;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
        }
        public Bill(DataRow row)
        {
            dateCheckin;
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["dateCheckin"];
            this.DateCheckOut = (DateTime?)row["dateCheckOut"];
            this.Status = (int)row["status"];
        }
    }
}
