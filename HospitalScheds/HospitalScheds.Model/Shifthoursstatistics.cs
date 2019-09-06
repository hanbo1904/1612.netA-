using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    /// <summary>
    /// 班次工时统计
    /// </summary>
    public class Shifthoursstatistics : BaseEntity
    {
        public int ID { get; set; }//ID
        public string personnel { get; set; }//人员
        public int second_line { get; set; }//二线
        public int Early { get; set; }//早班
        public int On_duty { get; set; }//值班
        public int night_shift_off { get; set; }//下夜班
        public int Class_pay_2 { get; set; }//二薪班
        public int For_class { get; set; }//备班
        public int Class_three_pay { get; set; }//三薪班
        public int total_productive_hours { get; set; }//总工时
    }
}
