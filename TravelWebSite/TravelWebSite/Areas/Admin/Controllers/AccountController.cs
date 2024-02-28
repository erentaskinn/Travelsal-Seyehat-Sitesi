using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Travel_BussinessLayer.Abstract.AbstractUow;
using Travels_EntityLayer.Concrete;
using TravelWebSite.Areas.Admin.Models;

namespace TravelWebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index (AccountVm model)
        {
            var valueSender = _accountService.TGetbyId(model.SenderId);
            var valueReceiver=_accountService.TGetbyId(model.ReceiverId);

            valueSender.Balance-=model.Amount;
            valueReceiver.Balance+=model.Amount;
            List<Account> modifiedAccounts = new List<Account>() 
            {
                valueSender,
                valueReceiver
            };
            _accountService.TMultiUpdate(modifiedAccounts);
            return View();
        }
    }
}
