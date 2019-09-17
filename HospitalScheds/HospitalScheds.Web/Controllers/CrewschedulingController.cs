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
        private ICrewschedulingServerce _crewschedulingServerce;

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
        public JsonResult Adds(Crewscheduling crewscheduling)
        {
            string jsonm = Newtonsoft.Json.JsonConvert.SerializeObject(crewscheduling);
            var result = HelperHttpClient.GetAll("post", "/api/Crewscheduling", jsonm);
            return Json(result);
        }

        public JsonResult Updates(int id)
        {
            var result = HelperHttpClient.GetAll("put", "/api/Crewscheduling", id);
            return Json(result);
        }
        public IActionResult Update()
        {
            return View();
        }
        public int Delete(int id)
        {
            int i = _crewschedulingServerce.DeleteCrewscheduling(id);
            return i;
        }
    }
}