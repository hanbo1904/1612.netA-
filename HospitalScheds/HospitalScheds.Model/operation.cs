using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    /// <summary>
    /// 手术排班
    /// </summary>
    public class operation 
    {
        public int ID { get; set; }//ID
        public string operationroom { get; set; }//手术间
        public string were { get; set; }//台次
        public int inpatientward { get; set; }//病区
        public int termofoperation { get; set; }//手术名称
        public int operatordoctor { get; set; }//主刀医生
        public int instrument { get; set; }//器械
        public int tour { get; set; }//巡回
        public string Anaesthetist { get; set; }//麻师
        public string patientname { get; set; }//患者姓名
        public string Sex { get; set; }//性别
        public string Age { get; set; }//年龄
        public string Remark { get; set; }//备注
    }
}
