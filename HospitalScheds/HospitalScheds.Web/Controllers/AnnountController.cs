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
    public class AnnountController : Controller
    {
        /// <summary>
        /// 定义私有变量
        /// </summary>
        private IAnnouncementformServerce _announcementformServerce;
        /// <summary>
        /// 构造函数注入
        /// </summary>
        /// <param name="organization"></param>
        public AnnountController(IAnnouncementformServerce announcementformServerce)
        {
            _announcementformServerce = announcementformServerce;
        }
        public IActionResult Index()
        {     
            return View();
        }
        public int Delete(int ids)
        {
            int i = _announcementformServerce.Delete(ids);
            return i;
        }
        public JsonResult Adds(Announcementform announcementform)   
        {
            string jsonm = Newtonsoft.Json.JsonConvert.SerializeObject(announcementform);
            var result = HelperHttpClient.GetAll("post", "/api/annount", jsonm);
            return Json(result);
        }
        public IActionResult Add()
        {
            return View();
        }
        public JsonResult Updates(int id)
        {
            var result = HelperHttpClient.GetAll("put", "/api/annount", id);
            return Json(result);
        }
        public IActionResult Update()
        {
            return View();
        }
    }
}