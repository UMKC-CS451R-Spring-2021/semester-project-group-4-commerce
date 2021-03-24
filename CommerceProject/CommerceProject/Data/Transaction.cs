using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace CommerceProject.Data
{
    public class Transaction
    {
        private int Trans_Num;
        private int Account_Num;
        private String Processing_Date;
        private String Type;
        private float Amount;
        private String Description;
        private float Balance;
        private String Location;




        public Transaction(float _Amount, String _Processing_Date, String _Location)
        {
            Amount = _Amount;
            Processing_Date = _Processing_Date;
            Location = _Location;
        }

        public Transaction()
        {

        }
        public String getLocation()
        {
            return Location;
        }
        public String getDate()
        {
            return Processing_Date;
        }
        public float get_Amount()
        {
            return Amount;
        }

        public int get_TransNum()
        {
            return Trans_Num;
        }
        public int get_AccountNum()
        {
            return Account_Num;
        }

        public String getType()
        {
            return Type;
        }

        public String getDescription()
        {
            return Description;
        }

        public float getBalance()
        {
            return Balance;
        }
    }


}
