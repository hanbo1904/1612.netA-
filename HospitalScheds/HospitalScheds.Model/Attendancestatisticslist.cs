using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    //考勤统计明细表
    public class Attendancestatisticslist : BaseEntity
    {
        public int ID { get; set; }                         //ID
        public string Personnel { get; set; }               //人员
        public DateTime Attendancetime { get; set; }        //考勤时间
        public string Classes { get; set; }                 //班次
        public DateTime Sheettime { get; set; }             //出勤时间
        public DateTime Clockin { get; set; }               //上班打卡
        public string Clockinfinis { get; set; }            //上班打卡结束
        public DateTime Clockout { get; set; }              //下班打卡
        public string Clockoutfinis { get; set; }           //下班打卡结束
    }
}
