using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HospitalScheds.Web.Controllers
{
    public class CrewschedulingController : Controller
    {
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
            var result = HelperHttpClient.GetAll("put", "/api/Crewscheduling", id);
            return Json(result);
        }
        public int Delete(int ids)
        {
            int i = _crewschedulingServerce.DeleteCrewscheduling(ids);
            return i;
        }
    }
}