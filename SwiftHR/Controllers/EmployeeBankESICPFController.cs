using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwiftHR.Controllers
{
    public class EmployeeBankESICPFController : Controller
    {

        // GET: EmployeeBankESICPFController
        public ActionResult EmployeeBankESICPF()
        {
            //EmpMasters empMasters = new EmpMasters();
            //empMasters = GetEmpMasterDetails();

            //if (IsAllowPageAccess("AddEmployee"))
            //    return View("AddEmployee", empMasters);
            //else
            //    return RedirectToAction("AccessDenied", "Home");
            return View("AddEmployeeBankESICPF");
        }

    }
}
