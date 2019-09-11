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


        //public JsonResult Indexs(string Name = "")
        //{
        //    //string pagelist = Newtonsoft.Json.JsonConvert.SerializeObject(Name);
        //    var result = HelperHttpClient.GetAll("get", "/api/annount",Name);
        //    return Json(result);
        //} 
        public IActionResult Index()
        {     
            return View();
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
            //string jsonm = Newtonsoft.Json.JsonConvert.SerializeObject(announcementform);
            var result = HelperHttpClient.GetAll("put", "/api/annount", id);
            return Json(result);
        }
        public IActionResult Update()
        {
            return View();
        }
        //public JsonResult Indexs(string Name = "", int pageIndex = 0, int pageSize = 3)
        //{
        //    string jsonm = Newtonsoft.Json.JsonConvert.SerializeObject(Name, pageIndex, pageSize);

        //}

             
        
    }
}