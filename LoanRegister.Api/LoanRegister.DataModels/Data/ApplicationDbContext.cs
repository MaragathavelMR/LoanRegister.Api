using LoanRegister.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanRegister.DataModels.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }
        public DbSet<LoanDetails> LoanDetails { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<AddressDetails> AddressDetails { get; set; }

    }
}
