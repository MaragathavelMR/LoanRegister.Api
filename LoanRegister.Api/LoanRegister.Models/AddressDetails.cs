using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanRegister.Models
{
    public class AddressDetails
    {
        public Guid Id { get; set; }
        [MaxLength(100)]
        public string PhysicalAddress { get; set; }
        [MaxLength(100)]
        public string PostalAddress { get; set; }
        public Guid LoanerID { get; set; }
        [ForeignKey("Id")]
        public LoanDetails LoanDetails { get; set; }
    }
}
