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
    public class AttendancestatisticslistController : Controller
    {
        /// <summary>
        /// 定义私有变量
        /// </summary>
        private IAttendancestatisticslistServerce _attendancestatisticslistServerce;
        /// <summary>
        /// 构造函数注入
        /// </summary>
        /// <param name="organization"></param>
        public AttendancestatisticslistController(IAttendancestatisticslistServerce attendancestatisticslistServerce)
        {
            _attendancestatisticslistServerce = attendancestatisticslistServerce;
        }
        public IActionResult Index()
        {
            return View();
        }

        public int Delete(int ids)
        {
            int i = _attendancestatisticslistServerce.Delete(ids);
            return i;
        }

        public JsonResult Adds(Attendancestatisticslist attendancestatisticslist)
        {
            string jsonm = Newtonsoft.Json.JsonConvert.SerializeObject(attendancestatisticslist);
            var result = HelperHttpClient.GetAll("post", "/api/attendancestatisticslist", jsonm);
            return Json(result);
        }
        public IActionResult Add()
        {
            return View();
        }
        public JsonResult Updates(int id)
        {
            var result = HelperHttpClient.GetAll("put", "/api/attendancestatisticslist", id);
            return Json(result);
        }
        public IActionResult Update()
        {
            return View();
        }
    }
}