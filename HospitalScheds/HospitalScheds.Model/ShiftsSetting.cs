using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    //班次设置表
    public class ShiftsSetting 
    {
        public int Id { get; set; }              //ID
        public string Name { get; set; }
        public string ColorShift { get; set; }      //班次颜色
        public DateTime OfficeHours { get; set; }     //班时间 D  mteimeTt
        public DateTime ClosingTime { get; set; }     //下班时间
        public int WorkingDay { get; set; }      //有效工作日
        public int DesignFormulas { get; set; }  //计算工时
        public int IsPunch { get; set; }         //是否打卡
        public int ShiftType { get; set; }       //班次类型
        public int ShiftOrder { get; set; }      //班次顺序
        
    }
}

