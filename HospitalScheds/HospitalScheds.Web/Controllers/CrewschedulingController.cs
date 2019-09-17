using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalScheds.Common;
using HospitalScheds.IServerce;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Update()
        {
            var result = HelperHttpClient.GetAll("put", "/api/Crewscheduling","");
            return Json(result);
        }
        public int Delete(int ids)
        {
            int i = _crewschedulingServerce.DeleteCrewscheduling(ids);
            return i;
        }
    }
}