using LoanRegister.DataModels.Data;
using LoanRegister.DataModels.Repository.IRepository;
using LoanRegister.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanRegister.DataModels.Repository
{
    public class LoanRegisterRepository:Repository<LoanDetails>, ILoanRegisterRepository
    {
        private readonly ApplicationDbContext _db;
        public LoanRegisterRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }
    }
}
