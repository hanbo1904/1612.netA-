using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    //考勤统计
    public class Attendance : BaseEntity
    {
        public int Id { get; set; }                    //主键ID
        public string Start { get; set; }              //每个月开始
        public string Finish { get; set; }             //结束
    }
}
