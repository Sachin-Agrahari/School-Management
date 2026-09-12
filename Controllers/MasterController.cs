using Microsoft.AspNetCore.Mvc;
using SchoolManagementERP.DataAccess;
using SchoolManagementERP.Interface;

namespace SchoolManagementERP.Controllers
{
    public class MasterController : Controller
    {
        private readonly IMaster _Master;

        public MasterController(IMaster master)
        {
            _Master = master;
        }

        public IActionResult GetMenuList()
        {
            var res = _Master.GetMenuList();
            return Json(res);
        }
    }
}
