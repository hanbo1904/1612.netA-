using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using HospitalScheds.IServerce;
using HospitalScheds.Model;
using HospitalScheds.Serverce;

namespace HospitalScheds.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendancesController : ControllerBase
    {
        /// <summary>
        /// 定义私有变量
        /// </summary>
        public IAttendancestatisticssummaryServerce _attendancestatisticssummaryServerce;

        /// <summary>
        /// 构造函数注入
        /// </summary>
        /// <param name="organization"></param>
        public AttendancesController(IAttendancestatisticssummaryServerce attendancestatisticssummaryServerce)
        {
            _attendancestatisticssummaryServerce = attendancestatisticssummaryServerce;
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="announcementform"></param>
        /// <returns></returns>
        [HttpPost]
        public int Add(Attendancestatisticssummary attendancestatisticssummary)
        {
            int i = _attendancestatisticssummaryServerce.Add(attendancestatisticssummary);
            return i;
        }


        /// <summary>
        /// 显示分页
        /// </summary>
        /// <param name="announcementform"></param> 
        /// <returns></returns>
        [HttpGet]
        public List<Attendancestatisticssummary> Index()
        {
            var list = _attendancestatisticssummaryServerce.Getattendances();
            return list;
        }


        /// <summary>
        /// 反填数据
        /// </summary>
        /// <param name="announcementform"></param>
        /// <returns></returns> 

        //public Attendancestatisticssummary Byid(int id)
        //{
        //    //Attendancestatisticssummary ann = _attendancestatisticssummaryServerce.attendances(id);
        //    return;
        //}


        /// <summary>
        ///删除
        /// </summary>
        /// <param name="announcementform"></param>
        /// <returns></returns> 
        [HttpDelete]
        public int Delete(int id)
        {
            int i = _attendancestatisticssummaryServerce.Delete(id);
            return i;
        }


        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="announcementform"></param>
        /// <returns></returns> 
        [HttpPut]
        public int Update(Attendancestatisticssummary attendancestatisticssummary, int id)
        {
            int i = _attendancestatisticssummaryServerce.Update(attendancestatisticssummary, id);
            return i;
        }
    }
}