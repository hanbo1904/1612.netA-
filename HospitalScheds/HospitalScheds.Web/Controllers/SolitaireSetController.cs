﻿using System;
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

        public IActionResult Adds(SolitaireSet solitaireSet)
        {
            string jsonm = Newtonsoft.Json.JsonConvert.SerializeObject(solitaireSet);
            var result = HelperHttpClient.GetAll("post", "/api/solitaireSet", jsonm);
            return Json(result);
        }

        public IActionResult Add()
        {
            return View();
        }

        public int Delete(int ids)
        {
            int i = _solitaireSetServerce.DelSolitaire(ids);
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