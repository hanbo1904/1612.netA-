using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    /// <summary>
    /// 人员排班
    /// </summary>
    public class Crewscheduling 
    {
        public int id { get; set; }//ID
        public string crewsname { get; set; }//姓名
        public string monday { get; set; }//星期一
        public string tuesday { get; set; }//星期二
        public string wednesday { get; set; }//星期三
        public string thursday { get; set; }//星期四
        public string friday { get; set; }//星期五
        public string saturday { get; set; }//星期六
        public string sunday { get; set; }//星期日
        public int classes { get; set; }//班次
        public string Remark { get; set; }//备注
    }
}
