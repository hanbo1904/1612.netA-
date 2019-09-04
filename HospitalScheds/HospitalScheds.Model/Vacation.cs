using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    //假期申请
    public class Vacation
    {
        public int Id { get; set; }          //ID
        public int Day { get; set; }         //每日申请
        public int Week { get; set; }        //每周申请
        public int Month { get; set; }       //每月申请
        public int Latest { get; set; }      //最晚申请
        public int Affirm { get; set; }      //确认申请时间，
    }
}
