using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceProject.Data
{
    public class Transaction
    {
        private String Location;
        private String Processing_Date;
        private float Amount;


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
    }


}
