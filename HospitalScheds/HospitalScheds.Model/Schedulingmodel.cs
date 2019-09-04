using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    /// <summary>
    /// 手术排班(护士)
    /// </summary>
    public class Schedulingmodel
    {
        public int ID { get; set; }//ID
        public int Operation { get; set; }//手术间
        public int Administrative { get; set; }//科室
        public int Instrument { get; set; }//器械
        public int Itinerate { get; set; }//巡回
        public DateTime Officetime { get; set; }//上班时间
    }
}
