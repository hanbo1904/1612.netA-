using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.Model;
using System.Data;
namespace HospitalScheds.IServerce
{
  public interface IAnnouncementformServerce
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="announcementform"></param>
        /// <returns></returns>
        int Add(Attendancestatisticslist announcementform);

        /// <summary>
        /// 显示分页
        /// </summary>
        /// <typeparam name="announcementform"></typeparam>
        /// <param name="Name"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        List<Attendancestatisticslist> GetAnnount();

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int Delete(int ids);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="dd"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        int Update(Attendancestatisticslist announcementform, int id);

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Attendancestatisticslist BackFill(int id);

    }
}
