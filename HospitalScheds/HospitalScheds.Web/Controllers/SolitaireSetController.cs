using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using HospitalScheds.Model;
using HospitalScheds.IServerce;
using HospitalScheds.Serverce;

namespace HospitalScheds.Web.Controllers
{
    public class SolitaireSetController : Controller
    {
        public ISolitaireSetServerce _solitaireSetServerce;
        public SolitaireSetController(ISolitaireSetServerce solitaireSetServerce)
        {
            _solitaireSetServerce = solitaireSetServerce;
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
            return View();
        }
    }
}