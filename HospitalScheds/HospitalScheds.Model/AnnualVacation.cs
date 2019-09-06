using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    //年假申请设置
    public class AnnualVacation : BaseEntity
    {
        public int Id { get; set; }                    //主键id
        public DateTime Being { get; set; }            //开始时间
        public DateTime Stop { get; set; }             //结束时间
        public DateTime Fixation { get; set; }         //固定年假
        public DateTime ApplicationBeing { get; set; } //申请开始
    }
}
