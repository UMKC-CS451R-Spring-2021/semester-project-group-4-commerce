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
        public float Amount { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "100 characters or less.")]
        public String Description { get; set; }

        public float Balance { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "Minimum 5 characters for Location.")]
        public String Location { get; set; }
    }
}
