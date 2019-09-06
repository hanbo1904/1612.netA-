using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HospitalScheds.Model;
using HospitalScheds.IServerce;
using HospitalScheds.IServerce;
namespace HospitalScheds.Web.Controllers
{
    public class AnnountController : Controller
    {
        /// <summary>
        /// 定义私有变量
        /// </summary>
        private readonly IAnnouncementformServerce announcementformServerce;
        /// <summary>
        /// 构造函数注入
        /// </summary>
        /// <param name="_announcementformServerce"></param>
        public AnnountController(IAnnouncementformServerce _announcementformServerce)
        {
            _announcementformServerce = announcementformServerce;
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