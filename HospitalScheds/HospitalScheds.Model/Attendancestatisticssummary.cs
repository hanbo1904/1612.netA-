using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    //考勤统计汇总
    public class Attendancestatisticssummary
    {
        public int ID { get; set; }                   //ID
        public string Personnel { get; set; }         //人员
        public string AttendanceDays { get; set; }    //出勤天数
        public string AbsenteeismDays { get; set; }   //缺勤天数
        public string Belate { get; set; }            //迟到天数
        public string Leaveearly { get; set; }        //早退天数
        public string Lackcark { get; set; }          //缺卡
        public string Absenteeism { get; set; }       //旷工
        public string Annualleave { get; set; }       //年假
        public string Sickleave { get; set; }         //病假
        public string casualleave { get; set; }       //事假
        public string Maternityleave { get; set; }    //产假
        public string Marriageleave { get; set; }     //婚假
        public string Funeralleave { get; set; }      //丧假
        public string Homeleave { get; set; }         //探亲假
    }
}
