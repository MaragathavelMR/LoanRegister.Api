using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanRegister.Models
{
    public class LoanDetails
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(100)]
        public string FirstName { get; set; }
        [MaxLength(100)]
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        public long Mobile { get; set; }
        public string ProfileImageUrl { get; set; }
        public int GenderId { get; set; }
        [ForeignKey("GenderId")]
        [ValidateNever]
        public Gender Gender { get; set; }
        public AddressDetails AddressDetails { get; set; }
    }
}
