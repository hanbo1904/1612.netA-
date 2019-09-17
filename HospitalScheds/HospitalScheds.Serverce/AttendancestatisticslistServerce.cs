using System;
using System.Collections.Generic;
using System.Text;
using HospitalScheds.Model;
using HospitalScheds.IServerce;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HospitalScheds.Serverce
{
    public class AttendancestatisticslistServerce : IAttendancestatisticslistServerce
    {
        DataContext db = new DataContext();
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="attendancestatisticslist"></param>
        /// <returns></returns>
        public int Add(Attendancestatisticslist attendancestatisticslist)
        {
            db.Attendancestatisticslist.Add(attendancestatisticslist);
            int i = db.SaveChanges();
            return i;
        }

       
        /// <summary>
        /// 显示分页
        /// </summary>
        /// <returns></returns>
        public List<Attendancestatisticslist> attendancestatisticslist()
        {
            var list = db.Attendancestatisticslist.ToList();
            return list;
        }

        /// <summary>
        /// 返填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Attendancestatisticslist attendancestatisticslist(int id)
        {
            var lsit = db.Attendancestatisticslist.Find(id);
            return lsit;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            var list = db.Attendancestatisticslist.Find(id);
            db.Attendancestatisticslist.Remove(list);
            int i = db.SaveChanges();
            return i;
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="attendancestatisticslist"></param>
        /// <param name="id"></param>
        /// <returns></returns>

        public int Update(Attendancestatisticslist attendancestatisticslist, int id)
        {
            db.Entry(attendancestatisticslist).State = EntityState.Modified;
            int i = db.SaveChanges();
            return i;
        }
    }
}
