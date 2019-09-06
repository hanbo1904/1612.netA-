using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    /// <summary>
    /// 特殊工时
    /// </summary>
    public class Specialworkinghours 
    {
        public int ID { get; set; }//ID
        public string Personnel { get; set; }//人员
        public int Total_productive_hours { get; set; }//总工时
        public int Time_over_runs { get; set; }//加班时间
        public int Less_class_time { get; set; }//欠班时间
        public int Super_11_h { get; set; }//超11h
        public int Seven_drop { get; set; }//7点之前
        public int preceding_20 { get; set; }//20点之前
    }
}
