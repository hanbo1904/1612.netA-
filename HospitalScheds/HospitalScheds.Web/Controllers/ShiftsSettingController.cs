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
    public class ShiftsSettingController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }


        public JsonResult Adds(ShiftsSetting shiftsSetting)
        {
            string jsonm = Newtonsoft.Json.JsonConvert.SerializeObject(shiftsSetting);
            var result = HelperHttpClient.GetAll("post", "/api/shiftssetting", jsonm);
            return Json(result);
        }

        public IActionResult Add()
        {
            return View();
        }

     

        public IActionResult Update()
        {
            return View();
        }
    }
}