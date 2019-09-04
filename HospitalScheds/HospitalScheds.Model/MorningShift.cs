using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    /// <summary>
    /// 早班人员列表
    /// </summary>
    public class MorningShift
    {
        public int ID { get; set; }//ID
        public string Name { get; set; }//姓名
        public int Professionalskill { get; set; }//专业技能
        public string Productivehours { get; set; }//总工时
        public string Overtime { get; set; }//加班时间
        public string Oweclasstime { get; set; }//欠班时间
        public string Closingtime { get; set; }//昨日下班时间
        public int Energylevel { get; set; }//能级
    }
}
