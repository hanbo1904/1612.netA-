using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using HospitalScheds.Model;
using HospitalScheds.IServerce;
namespace HospitalScheds.Web.Controllers
{
    public class ShiftsSettingController : Controller
    {
        /// <summary>
        /// 定义私有变量
        /// </summary>
        private readonly IAnnouncementformServerce shiftsSettingServerce;

        /// <summary>
        /// 构造函数注入
        /// </summary>
        /// <param name="_shiftsSettingServerce"></param>
        public ShiftsSettingController(IAnnouncementformServerce _shiftsSettingServerce)
        {
            _shiftsSettingServerce = shiftsSettingServerce;
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