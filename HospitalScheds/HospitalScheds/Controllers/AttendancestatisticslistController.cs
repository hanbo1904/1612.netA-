using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using HospitalScheds.IServerce;
using HospitalScheds.Model;


namespace HospitalScheds.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendancestatisticslistController : ControllerBase
    {
        /// <summary>
        /// 定义私有变量
        /// </summary>
        private IAttendancestatisticslistServerce _attendancestatisticslistServerce;


        /// <summary>
        /// 构造函数注入
        /// </summary>
        /// <param name="organization"></param>
        public AttendancestatisticslistController(IAttendancestatisticslistServerce attendancestatisticslistServerce)
        {
            _attendancestatisticslistServerce = attendancestatisticslistServerce;
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="attendancestatisticslist"></param>
        /// <returns></returns>
        [HttpPost]
        public int Add(Announcementform attendancestatisticslist)
        {
            int i = _attendancestatisticslistServerce.Add(attendancestatisticslist);
            return i;
        }

        /// <summary>
        /// 显示分页
        /// </summary>
        /// <param name="attendancestatisticslist"></param> 
        /// <returns></returns>
        [HttpGet]
        public List<Announcementform> Indexs()
        {
            var list = _attendancestatisticslistServerce.attendancestatisticslist();
            return list;
        }
        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult<Announcementform> BackFill(int id)
        {
            Announcementform annount = _attendancestatisticslistServerce.attendancestatisticslist(id);
            return annount;
        }

        /// <summary>
        ///删除
        /// </summary>
        /// <param name="attendancestatisticslist"></param>
        /// <returns></returns> 
        [HttpDelete]
        public int Delete(int id)
        {
            int i = _attendancestatisticslistServerce.Delete(id);
            return i;
        }


        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="attendancestatisticslist"></param>
        /// <returns></returns> 
        [HttpPut]
        public int Update(Announcementform attendancestatisticslist, int id)
        {
            int i = _attendancestatisticslistServerce.Update(attendancestatisticslist, id);
            return i;
        }
    }
}