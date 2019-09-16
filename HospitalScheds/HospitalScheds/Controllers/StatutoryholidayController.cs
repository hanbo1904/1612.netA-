using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using HospitalScheds.Model;
using HospitalScheds.IServerce;
using HospitalScheds.Serverce;
using HospitalScheds.Common;
using System.Net.Http;
using System.Net.Http.Headers;

namespace HospitalScheds.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatutoryholidayController : ControllerBase
    {
        /// <summary>
        /// 定义私有变量
        /// </summary>
        private IStatutoryholidayServerce _StatutoryholidayServerce;

        /// <summary>
        /// 构造函数注入
        /// </summary>
        /// <param name="organization"></param>
        public StatutoryholidayController(IStatutoryholidayServerce statutoryholidayServerce)
        {
            _StatutoryholidayServerce = statutoryholidayServerce;
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="announcementform"></param>
        /// <returns></returns>
        [HttpPost]
        public int Add(StatutoryholidayServerce statutoryholiday)
        {
            int i = _StatutoryholidayServerce.AddStatutoryholiday(statutoryholiday);
            return i;
        }
        /// <summary>
        /// 显示分页
        /// </summary>
        /// <param name="announcementform"></param> 
        /// <returns></returns>
        [HttpGet]
        public PageModel<Attendance> Index(string Name = "", int pageIndex = 0, int pageSize = 3)
        {
            var list = _StatutoryholidayServerce.GetStatutoryholiday(Name, pageIndex, pageSize);
            return list;
        }
    }
}