using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.Model;
using System.Data;
namespace HospitalScheds.IServerce
{
   public  interface IAttendancestatisticslistServerce
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="attendancestatisticslist"></param>
        /// <returns></returns>
        int Add(Announcementform attendancestatisticslist);

        /// <summary>
        /// 显示分页
        /// </summary>
        /// <typeparam name="attendancestatisticslist"></typeparam>
        /// <param name="Name"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
         List<Announcementform> attendancestatisticslist();

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int Delete(int id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="dd"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        int Update(Announcementform attendancestatisticslist, int id);

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Announcementform attendancestatisticslist(int id);


    }
}
