using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwiftHR.Controllers
{
    public class ComponentGroupController : Controller
    {

        // GET: ComponentGroupController
        public ActionResult ComponentGroup()
        {
            //EmpMasters empMasters = new EmpMasters();
            //empMasters = GetEmpMasterDetails();

            //if (IsAllowPageAccess("AddEmployee"))
            //    return View("AddEmployee", empMasters);
            //else
            //    return RedirectToAction("AccessDenied", "Home");
            return View("AddComponentGroup");
        }

    }
}
