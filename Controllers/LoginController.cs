using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementERP.Controllers;
public class LoginController : Controller
{
    [HttpGet] public IActionResult Index() => View();
    [HttpPost] public IActionResult Index(string username, string password, string role)
    {
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        { ViewBag.Error = "Please enter username and password."; return View(); }
        HttpContext.Session.SetString("UserName", username);
        HttpContext.Session.SetString("Role", role ?? "Admin");
        return RedirectToAction("Index", "Dashboard");
    }
    public IActionResult Logout() { HttpContext.Session.Clear(); return RedirectToAction("Index"); }
}
