﻿using System;
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
    public class MajorgroupController : Controller
    {
        private IMajorgroupServerce _majorgroupServerce;
        public MajorgroupController(IMajorgroupServerce majorgroupServerce)
        {
            _majorgroupServerce = majorgroupServerce;
        }
        public IActionResult Index()
        {
            return View();
        }
        public int Delete(int ids)
        {
            int i = _majorgroupServerce.Delete(ids);
            return i;
        }
        public JsonResult Adds(Majorgrouping majorgrouping)
        {
            string jsonm = Newtonsoft.Json.JsonConvert.SerializeObject(majorgrouping);
            var result = HelperHttpClient.GetAll("post", "/api/majorgroup", jsonm);
            return Json(result);
        }
        public IActionResult Add()
        {
            return View();
        }
        public JsonResult Updates(int id)
        {
            //string jsonm = Newtonsoft.Json.JsonConvert.SerializeObject(announcementform);
            var result = HelperHttpClient.GetAll("put", "/api/majorgroup", id);
            return Json(result);
        }
        public IActionResult Update()
        {
            return View();
        }
    }
}