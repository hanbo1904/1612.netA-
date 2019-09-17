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

    public class CrewschedulingController : Controller
    {
        /// <summary>
        /// 定义私有变量
        /// </summary>
        private ICrewschedulingServerce _crewschedulingServerce;


        /// <summary>
        /// 构造函数注入
        /// </summary>
        /// <param name="organization"></param>
        public CrewschedulingController(ICrewschedulingServerce crewschedulingServerce)
        {
            _crewschedulingServerce = crewschedulingServerce;
        }

        public IActionResult Index()
        {
            return View();
        }
        public JsonResult Adds(Crewscheduling crewscheduling)
        {
            string jsonm = Newtonsoft.Json.JsonConvert.SerializeObject(crewscheduling);
            var result = HelperHttpClient.GetAll("post", "/api/Crewscheduling", jsonm);
            return Json(result);
        }
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Update(int id)
        {
            var result = HelperHttpClient.GetAll("put", "/api/Crewscheduling", id);
            return Json(result);
        }
        public int Delete(int id)
        {
            int i = _crewschedulingServerce.DeleteCrewscheduling(id);
            return i;
        }
    }
}