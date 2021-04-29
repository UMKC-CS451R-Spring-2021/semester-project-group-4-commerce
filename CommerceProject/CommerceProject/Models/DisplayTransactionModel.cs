using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceProject.Models
{
    public class DisplayTransactionModel
    {

        public int Account_Num { get; set; }

        public String Processing_Date { get; set; }      // potential datatype problem

        public String Type { get; set; }

        [Required]
        [Range(1, 10000, ErrorMessage = "Minimum value is $1.00. Maximum is $10,000")]
        public decimal Amount { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "100 characters or less.")]
        public String Description { get; set; }

        public decimal Balance { get; set; }

        [Required]
        [MinLength(4, ErrorMessage = "Minimum 4 characters for Location.")]
        public String Location { get; set; }
    }
}
