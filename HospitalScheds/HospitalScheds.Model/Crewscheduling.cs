using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    /// <summary>
    /// 人员排班
    /// </summary>
    public class Crewscheduling : BaseEntity
    {
        public int ID { get; set; }//ID
        public string CrewsName { get; set; }//姓名
        public string Monday { get; set; }//星期一
        public string Tuesday { get; set; }//星期二
        public string Wednesday { get; set; }//星期三
        public string Thursday { get; set; }//星期四
        public string Friday { get; set; }//星期五
        public string Saturday { get; set; }//星期六
        public string Sunday { get; set; }//星期日
        public int classes { get; set; }//班次
        public string Remark { get; set; }//备注
    }
}
