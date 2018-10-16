using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class BillInfo
    {
        private int iD;
        private int billiD;
        private int foodID;
        private int Count;

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

        public int BilliD
        {
            get
            {
                return billiD;
            }

            set
            {
                billiD = value;
            }
        }

        public int FoodID
        {
            get
            {
                return foodID;
            }

            set
            {
                foodID = value;
            }
        }

        public int Count1
        {
            get
            {
                return Count;
            }

            set
            {
                Count = value;
            }
        }
        public BillInfo(int id, int billID, int foodID,int count)
        {
            this.ID = id;
            this.BilliD = billID;
            this.FoodID = foodID;
            this.Count1 = count;
        }
    }
}
