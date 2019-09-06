using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model 
{
    //排班规则设置表
    public class SchedulingRules 
    {
        public int ID { get; set; }                   //ID
        public int DateTimesOne { get; set; }         //时间1
        public int ShiftsOne { get; set; }            //班次1
        public int DateTimesTwo { get; set; }         //时间2
        public int DateTimesThree { get; set; }       //时间3
        public int ShiftsTwo { get; set; }            //班次2
    }
}
