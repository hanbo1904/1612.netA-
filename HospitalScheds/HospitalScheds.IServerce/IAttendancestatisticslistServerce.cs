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
        int Add(Attendancestatisticslist attendancestatisticslist);

        /// <summary>
        /// 显示分页
        /// </summary>
        /// <typeparam name="attendancestatisticslist"></typeparam>
        /// <param name="Name"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
         PageModel<Attendancestatisticslist> attendancestatisticslist(String Name = "", int pageIndex = 0, int pageSize = 3);

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
        int Update(Attendancestatisticslist attendancestatisticslist, int id);

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        List<Attendancestatisticslist> attendancestatisticslist();


    }
}
