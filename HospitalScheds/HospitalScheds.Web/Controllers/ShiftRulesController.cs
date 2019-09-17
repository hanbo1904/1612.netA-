using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


using HospitalScheds.Model;
using HospitalScheds.IServerce;
using HospitalScheds.Serverce;
using HospitalScheds.Common;
using System.Net.Http;
using System.Net.Http.Headers;

namespace HospitalScheds.Web.Controllers
{
   

public class ShiftRulesController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public JsonResult AddR(ShiftRules shiftRules)
    {
        string jsonm = Newtonsoft.Json.JsonConvert.SerializeObject(shiftRules);
        var result = HelperHttpClient.GetAll("post", "/api/ShiftRules", jsonm);
        return Json(result);
    }
    public IActionResult Add()
    {
        return View();
    }
    public JsonResult Update(int id)
    {
        var result = HelperHttpClient.GetAll("put", "/api/ShiftRules", id);
        return Json(result);
    }
    public IActionResult Update()
    {
        return View();
    }
}
}