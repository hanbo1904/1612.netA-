using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    //班次设置表
    public class ShiftsSetting 
    {
        public int id { get; set; }              //ID
        public string name { get; set; }
        public string colorshift { get; set; }      //班次颜色
        public DateTime officehours { get; set; }     //班时间 D  mteimeTt
        public DateTime closingtime { get; set; }     //下班时间
        public int workingday { get; set; }      //有效工作日
        public int designformulas { get; set; }  //计算工时
        public int ispunch { get; set; }         //是否打卡
        public int shifttype { get; set; }       //班次类型
        public int shiftorder { get; set; }      //班次顺序
        
    }
}

