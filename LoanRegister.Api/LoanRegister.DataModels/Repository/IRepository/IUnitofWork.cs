using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanRegister.DataModels.Repository.IRepository
{
    public interface IUnitofWork
    {
        ILoanRegisterRepository LoanRegisterRepository { get; }
        void save();
    }
}
