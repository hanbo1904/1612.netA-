using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    //班次规则表
    public class ShiftRules 
    {
        public int id { get; set; }                  //ID
        public string shiftScorise { get; set; }     //班次规则
        public int isEffect { get; set; }             //是否生效
    }
}
