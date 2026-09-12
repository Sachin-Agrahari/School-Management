using Microsoft.AspNetCore.Mvc;
using SchoolManagementERP.Interface;
using System.Text.Json.Serialization;
namespace SchoolManagementERP.Controllers;
public class StudentsController : Controller
{
    private readonly IStudent _Istudent;
    public StudentsController(IStudent student)
    {
        _Istudent = student;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult GetStudentData()
    {
        var res = _Istudent.GetStudentData();
        return Json(res);
    }

}