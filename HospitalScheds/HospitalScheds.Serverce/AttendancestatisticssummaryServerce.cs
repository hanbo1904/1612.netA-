using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HospitalScheds.IServerce;
using HospitalScheds.Model;

/// <summary>
/// 考勤统计汇总
/// </summary>
namespace HospitalScheds.Serverce
{
    public class AttendancestatisticssummaryServerce : IAttendancestatisticssummaryServerce 
    {
        DataContext db = new DataContext();
        public int Add(Attendancestatisticssummary attendancestatisticssummary)
        {
            db.Attendancestatisticssummary.Add(attendancestatisticssummary);
            int i = db.SaveChanges();
            return i;
        }

        public List<Attendancestatisticssummary> Getattendances() 
        {
            List<Attendancestatisticssummary> list = db.Attendancestatisticssummary.ToList();
            return list;
        }

        public List<Attendancestatisticssummary> attendances() 
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            var list = db.Attendancestatisticssummary.Find(id);
            db.Attendancestatisticssummary.Remove(list);
            int i = db.SaveChanges();
            return i;
        }

        public int Update(Attendancestatisticssummary attendancestatisticssummary, int id)
        {
            throw new NotImplementedException();
        }
    }
}
