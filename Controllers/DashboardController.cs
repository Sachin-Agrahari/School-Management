using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace SchoolManagementERP.Controllers;
public class DashboardController : Controller
{
 public IActionResult Index(){ if(string.IsNullOrEmpty(HttpContext.Session.GetString("Role"))) return RedirectToAction("Index","Login"); ViewBag.Role=HttpContext.Session.GetString("Role"); ViewBag.UserName=HttpContext.Session.GetString("UserName"); return View(); }
}
