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
    public class SchedulingRulesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult AddR(SchedulingRules schedulingRules)
        {
            string jsonm = Newtonsoft.Json.JsonConvert.SerializeObject(schedulingRules);
            var result = HelperHttpClient.GetAll("post", "/api/SchedulingRules", jsonm);
            return Json(result);
        }
        public IActionResult Add()
        {
            return View();
        }
        public JsonResult Update(int id)
        {
            var result = HelperHttpClient.GetAll("put", "/api/SchedulingRules", id);
            return Json(result);
        }
        public IActionResult Update()
        {
            return View();
        }
    }
}