using Microsoft.AspNetCore.Mvc;

namespace LoanRegister.Api.Controllers
{
    public class LoanRegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegisterLoanDetails()
        {
            return RedirectToAction("Index");
        }
    }
}
