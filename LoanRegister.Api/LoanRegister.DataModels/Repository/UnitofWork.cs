using LoanRegister.DataModels.Data;
using LoanRegister.DataModels.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanRegister.DataModels.Repository
{
    public class UnitofWork:IUnitofWork
    {
        private readonly ApplicationDbContext _db;
        public UnitofWork(ApplicationDbContext db)
        {
            _db = db;
            LoanRegisterRepository = new LoanRegisterRepository(_db);
        }

        public ILoanRegisterRepository LoanRegisterRepository { get;private set; }

        public void save()
        {
            _db.SaveChanges();
        }
    }
}
