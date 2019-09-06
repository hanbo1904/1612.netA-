using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    /// <summary>
    /// 手术申请表
    /// </summary>
    public class SurgeryFor : BaseEntity
    {
        public int ID { get; set; }//ID
        public int Setnumber { get; set; }//台次
        public int Administrativeoffice { get; set; }//科室
        public int Operation { get; set; }//手术名称
        public int Diagnose { get; set; }//诊断
        public string SickenName { get; set; }//患者姓名
        public int Age { get; set; }//年龄
        public string Sex { get; set; }//性别
        public int Anesthesia { get; set; }//麻醉医生
        public int Bednumber { get; set; }//床号
    }
}
