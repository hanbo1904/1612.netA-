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
    public class AttendanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult Adds(Attendance attendance)
        {
            string jsonm = Newtonsoft.Json.JsonConvert.SerializeObject(attendance);
            var result = HelperHttpClient.GetAll("post", "/api/attendance", jsonm);
            return Json(result);
        }
        public JsonResult Adds(Attendance attendance)
        {
            string jsonm = Newtonsoft.Json.JsonConvert.SerializeObject(attendance);
            var result = HelperHttpClient.GetAll("post", "/api/attendance", jsonm);
            return Json(result);
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}