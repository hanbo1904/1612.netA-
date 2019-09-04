using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    //专业分组设置
    public class Majorgrouping
    {
        public int Id { get; set; }                    //ID
        public string Professional { get; set; }       //专业组颜色
        public string MajorgroupingName { get; set; }  //名称
        public string Therelevant { get; set; }        //相关科室
        public string Teaching { get; set; }           //带教
        public string MajorgroupingLeader { get; set; }//组长
        public string MajorgroupingCrew { get; set; }  //组员
    }                                                  
}
