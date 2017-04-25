using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CustomerReport.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CardId { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
        public string EmailId { get; set; }
        public string Gender { get; set; }
        public string Points { get; set; }
        public int CreditLimit { get; set; }
    }
}