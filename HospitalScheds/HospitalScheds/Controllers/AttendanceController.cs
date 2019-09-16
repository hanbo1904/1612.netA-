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
    public class AttendanceController : ControllerBase
    {
        /// <summary>
        /// 定义私有变量
        /// </summary>
        private IAttendanceServerce _AttendanceServerce;

        /// <summary>
        /// 构造函数注入
        /// </summary>
        /// <param name="organization"></param>
        public AttendanceController(IAttendanceServerce attendanceServerce)
        {
            _AttendanceServerce = attendanceServerce;
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="announcementform"></param>
        /// <returns></returns>
        [HttpPost]
        public int Add(Attendance attendance)
        {
            int i = _AttendanceServerce.AddAttendance(attendance);
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
            var list = _AttendanceServerce.GetAttendance(Name, pageIndex, pageSize);
            return list;
        }
        /// <summary>
        /// 反填数据
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns> 
        [HttpGet("Get")]
        public ActionResult<Attendance> Get(int id)
        {
            Attendance ann = _AttendanceServerce.GetModel(id);
            return ann;
        }
        /// <summary>
        ///删除
        /// </summary>
        /// <param name="announcementform"></param>
        /// <returns></returns> 
        [HttpDelete]
        public int DeleteAttendance(int id)
        {
            int i = _AttendanceServerce.DeleteAttendance(id);
            return i;
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="announcementform"></param>
        /// <returns></returns> 
        [HttpPut]
        public int Update(Attendance attendance, int id)
        {
            int i = _AttendanceServerce.Update(attendance, id);
            return i;
        }
    }
    /// <summary>
    /// 法定节日
    /// </summary>
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
        public int Add(Statutoryholiday statutoryholiday)
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
        public PageModel<Statutoryholiday> Index(string Name = "", int pageIndex = 0, int pageSize = 3)
        {
            var list = _StatutoryholidayServerce.GetStatutoryholiday(Name, pageIndex, pageSize);
            return list;
        }
    }
}