using System;
using System.Collections.Generic;
using System.Text;
using HospitalScheds.Model;
using HospitalScheds.IServerce;

using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace HospitalScheds.Serverce
{
    /// <summary>
    /// 考勤管理
    /// </summary>
    public class AttendanceServerce : IAttendanceServerce
    {
        DataContext db = new DataContext();
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="attendance"></param>
        /// <returns></returns>
        public int AddAttendance(Attendance attendance)
        {
            db.Attendance.Add(attendance);
            int i = db.SaveChanges();
            return i;
        }

        /// <summary>
        ///  修改
        /// </summary>
        /// <param name="announcementform"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Update(Attendance attendance, int id)
        {
            db.Entry(attendance).State = EntityState.Modified;
            int i = db.SaveChanges();
            return i;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public int DeleteAttendance(int id)
        {
            var list = db.Attendance.Find(id);
            db.Attendance.Remove(list);
            int i = db.SaveChanges();
            return i;
        }



        public PageModel<Attendance> GetAttendance(string Name = "", int pageIndex = 1, int pageSize = 3)
        {
            if (Name == null)
            {
                Name = "";
            }
            PageModel<Attendance> pagemodel = new PageModel<Attendance>();
            int totalcount = db.Attendance.Where(m => m.Start.Contains(Name)).ToList().Count();
            //分页
            var list = db.Attendance.Where(m => m.Start.Contains(Name)).ToList().Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            pagemodel.TotalCount = totalcount;
            pagemodel.Data = list;
            return pagemodel;
        }

        public Attendance GetModel(int id)
        {
            var lsit = db.Attendance.Find(id);
            return lsit;
        }
    }
}
