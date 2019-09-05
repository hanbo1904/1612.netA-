using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.Model;
using System.Data;

namespace HospitalScheds.IServerce
{
   public  interface IAttendancestatisticssummaryServerce
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="attendancestatisticssummary"></param>
        /// <returns></returns>
        int Add(Attendancestatisticssummary attendancestatisticssummary);

        /// <summary>
        /// 显示分页
        /// </summary>
        /// <typeparam name="attendancestatisticssummary"></typeparam>
        /// <param name="Name"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        PageModel<Attendancestatisticssummary> attendancestatisticssummary (String Name = "", int pageIndex = 0, int pageSize = 3);

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
        int Update(Attendancestatisticssummary attendancestatisticssummary, int id);

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        List<Attendancestatisticssummary> attendancestatisticssummary();


    }
}
