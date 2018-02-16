using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankForm.Models
{
    public partial class BankAccount
    {
        public BankAccount() { }

        [Required (ErrorMessage="BSB field is required")]
        [RegularExpression("[1-9]{3}",ErrorMessage="BSB must consist of 3 numbers only.")]
        public string BSB { get; set; }
        [Required (ErrorMessage = "Account number field is required")]
        [RegularExpression("[1-9]{11}", ErrorMessage = "Account number must consist of 11 numbers only.")]
        public string AccountNumber { get; set; }
        [Required (ErrorMessage = "Account name field is required")]
        public string AccountName { get; set; }
        [Required (ErrorMessage = "Reference field is required")]
        public string Reference { get; set; }
    }
}