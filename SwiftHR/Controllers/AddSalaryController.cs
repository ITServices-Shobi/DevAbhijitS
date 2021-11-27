using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwiftHR.Controllers
{
    public class AddSalaryController : Controller
    {

        // GET: AddSalaryController
        public ActionResult AddSalary()
        {
            //EmpMasters empMasters = new EmpMasters();
            //empMasters = GetEmpMasterDetails();

            //if (IsAllowPageAccess("AddEmployee"))
            //    return View("AddEmployee", empMasters);
            //else
            //    return RedirectToAction("AccessDenied", "Home");
            return View("AddSalary");
        }

        // GET: ApproveSalary
        public ActionResult ApproveSalary()
        {
            //EmpMasters empMasters = new EmpMasters();
            //empMasters = GetEmpMasterDetails();

            //if (IsAllowPageAccess("AddEmployee"))
            //    return View("AddEmployee", empMasters);
            //else
            //    return RedirectToAction("AccessDenied", "Home");
            return View("ApproveSalary");
        }

        // GET: Reimbursement
        public ActionResult Reimbursement()
        {
            //EmpMasters empMasters = new EmpMasters();
            //empMasters = GetEmpMasterDetails();

            //if (IsAllowPageAccess("AddEmployee"))
            //    return View("AddEmployee", empMasters);
            //else
            //    return RedirectToAction("AccessDenied", "Home");
            return View("Reimbursement");
        }
    }
}
