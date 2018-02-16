using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BankForm.Models;

namespace BankForm.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(BankAccount myBankAccount)
        {
            var myBankAccountControl = new BankAccountControl();
            if (myBankAccountControl.SaveAccountInformation(myBankAccount))
            {
                return View("Success");
            }
            else
            {
                return View("error");
            }
        }
    }
}