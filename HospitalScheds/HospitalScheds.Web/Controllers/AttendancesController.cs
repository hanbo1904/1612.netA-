using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using HospitalScheds.Model;
using HospitalScheds.IServerce;
using HospitalScheds.Serverce;
using HospitalScheds.Common;

namespace HospitalScheds.Web.Controllers
{
    public class AttendancesController : Controller
    {
        public IAttendancestatisticssummaryServerce _attendancestatisticssummaryServerce; 
        public AttendancesController(IAttendancestatisticssummaryServerce attendancestatisticssummaryServerce)
        {
            _attendancestatisticssummaryServerce = attendancestatisticssummaryServerce;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Adds(Attendancestatisticssummary attendancestatisticssummary)
        {
            string jsonm = Newtonsoft.Json.JsonConvert.SerializeObject(attendancestatisticssummary);
            var result = HelperHttpClient.GetAll("post", "/api/solitaireSet", jsonm);
            return Json(result);
        }

        public IActionResult Add()
        {
            return View();
        }

        public int Delete(int ids)
        {
            int i = _attendancestatisticssummaryServerce.Delete(ids);
            return i;
        }

        public IActionResult Updates(int id)
        {
            var result = HelperHttpClient.GetAll("put", "/api/solitaireSet", id);
            return Json(result);
        }

        public IActionResult Update()
        {
            return View();
        }
    }
}